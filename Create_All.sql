USE [Eureka]
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=N'EurekaCommonAddon')
	BEGIN
		CREATE TABLE dbo.EurekaCommonAddon (
			EurekaCommonAddonID BIGINT,
			Name VARCHAR(60) NOT NULL,
			Description VARCHAR(MAX) NOT NULL,
			OneOffCost DECIMAL(18,2) NOT NULL,
			MonthlyCost DECIMAL(18,2) NOT NULL,
			OneOffStandaloneCost DECIMAL(18,2) NOT NULL,
			MonthlyStandaloneCost DECIMAL(18,2) NOT NULL,

			CONSTRAINT PK_EurekaCommonAddon PRIMARY KEY (EurekaCommonAddonID)
		)
	END
GO

USE [Eureka]
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=N'EurekaBillingFrequency')
	BEGIN
		CREATE TABLE dbo.EurekaBillingFrequency (
			EurekaBillingFrequencyID BIGINT,
			Name VARCHAR(60) NOT NULL,

			CONSTRAINT PK_EurekaBillingFrequency PRIMARY KEY (EurekaBillingFrequencyID)
		)

		INSERT INTO dbo.EurekaBillingFrequency VALUES
			('1', 'One-Off'),
			('2', 'Monthly'),
			('3', 'One-Off (Standalone)'),
			('4', 'Monthly (Standalone)')
	END
GO

USE [Eureka]
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=N'EurekaSubscription')
	BEGIN
		CREATE TABLE dbo.EurekaSubscription (
			EurekaSubscriptionID BIGINT,
			SLCustomerAccountID BIGINT,
			EurekaCommonAddonID BIGINT,
			EurekaBillingFrequencyID BIGINT,
			ExpiryDate DATE NOT NULL,
			CostPerBillingCycle DECIMAL(18,2) NOT NULL,
			LicenseKey VARCHAR(MAX) NOT NULL

			CONSTRAINT PK_EurekaSubscription PRIMARY KEY (EurekaSubscriptionID),
			CONSTRAINT FK_SLCustomerAccount FOREIGN KEY (SLCustomerAccountID) REFERENCES dbo.SLCustomerAccount ON DELETE CASCADE,
			CONSTRAINT FK_EurekaCommonAddon FOREIGN KEY (EurekaCommonAddonID) REFERENCES dbo.EurekaCommonAddon ON DELETE CASCADE,
			CONSTRAINT FK_EurekaBillingFrequency FOREIGN KEY (EurekaBillingFrequencyID) REFERENCES dbo.EurekaBillingFrequency
		)
	END
GO

USE [Eureka]
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME=N'EurekaSageAccountSubscriptions')
	Exec('CREATE VIEW dbo.EurekaSageAccountSubscriptions AS
		  SELECT dbo.SLCustomerAccount.CustomerAccountNumber, dbo.SLCustomerAccount.CustomerAccountName, CRM.dbo.Marketing.mrkt_SageAccountNumber AS SageAccountNumber, CRM.dbo.Marketing.mrkt_Sage200SerialNumber AS Sage200SerialNumber, dbo.EurekaCommonAddon.Name AS LicensedAddonName, dbo.EurekaSubscription.ExpiryDate, dbo.EurekaSubscription.LicenseKey
		  FROM dbo.EurekaCommonAddon
			  INNER JOIN dbo.EurekaSubscription
			  	  ON dbo.EurekaCommonAddon.EurekaCommonAddonID = dbo.EurekaSubscription.EurekaCommonAddonID
			  INNER JOIN CRM.dbo.Company
			  INNER JOIN CRM.dbo.Account
				  ON CRM.dbo.Company.Comp_CompanyId = CRM.dbo.Account.Acc_CompanyId
			  INNER JOIN dbo.SLCustomerAccount
				  ON CRM.dbo.Account.Acc_intforeignid = dbo.SLCustomerAccount.SLCustomerAccountID
			  INNER JOIN CRM.dbo.Marketing
				  ON CRM.dbo.Company.Comp_CompanyId = CRM.dbo.Marketing.Mrkt_CompanyId
				  ON dbo.EurekaSubscription.SLCustomerAccountID = dbo.SLCustomerAccount.SLCustomerAccountID
		  WHERE (CRM.dbo.Marketing.mrkt_SALPBusinessPartner = N''Current'')')
GO

USE [Eureka]
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME=N'EurekaCustomerSageAccounts')
	Exec('CREATE VIEW dbo.EurekaCustomerSageAccounts AS
		  SELECT dbo.SLCustomerAccount.SLCustomerAccountID, dbo.SLCustomerAccount.CustomerAccountNumber, dbo.SLCustomerAccount.CustomerAccountName, CRM.dbo.Marketing.mrkt_SageAccountNumber AS SageAccountNumber, CRM.dbo.Marketing.mrkt_Sage200SerialNumber AS Sage200SerialNumber
          FROM CRM.dbo.Company
	          INNER JOIN CRM.dbo.Account
		          ON CRM.dbo.Company.Comp_CompanyId = CRM.dbo.Account.Acc_CompanyId
	          INNER JOIN dbo.SLCustomerAccount
		          ON CRM.dbo.Account.Acc_intforeignid = dbo.SLCustomerAccount.SLCustomerAccountID
	          INNER JOIN CRM.dbo.Marketing
		          ON CRM.dbo.Company.Comp_CompanyId = CRM.dbo.Marketing.Mrkt_CompanyId
          WHERE (CRM.dbo.Marketing.mrkt_SALPBusinessPartner = N''Current'')')
GO

USE [master]
IF NOT EXISTS (SELECT name FROM master.sys.server_principals WHERE name = N'EurekaSubscriber')
	BEGIN
		CREATE LOGIN [EurekaSubscriber] WITH PASSWORD=N'cgfDHNa3/v/8d@?wjM7FH3ap', DEFAULT_DATABASE=[Eureka]
	END
GO

USE [Eureka]
IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name =N'EurekaSubscriber')
	BEGIN
		CREATE USER [EurekaSubscriber] FOR LOGIN [EurekaSubscriber]
	END
GO

USE [Eureka]
GRANT SELECT ON "dbo"."EurekaSageAccountSubscriptions" TO [EurekaSubscriber]
GO

USE [CRM]
IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name =N'EurekaSubscriber')
	BEGIN
		CREATE USER [EurekaSubscriber] FOR LOGIN [EurekaSubscriber]
	END
GO

USE [CRM]
GRANT SELECT ON "dbo"."Account" TO [EurekaSubscriber]
GRANT SELECT ON "dbo"."Company" TO [EurekaSubscriber]
GRANT SELECT ON "dbo"."Marketing" TO [EurekaSubscriber]
GO

USE [CRM]
IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name =N'Eureka_MMSUser')
	BEGIN
		CREATE USER [Eureka_MMSUser] FOR LOGIN [Eureka_MMSUser]
	END
GO

USE [CRM]
GRANT SELECT ON "dbo"."Account" TO [Eureka_MMSUser]
GRANT SELECT ON "dbo"."Company" TO [Eureka_MMSUser]
GRANT SELECT ON "dbo"."Marketing" TO [Eureka_MMSUser]
GO