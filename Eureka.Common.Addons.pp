<?xml version="1.0" encoding="utf-8"?>
<Project xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" SchemaVersion="1.0" AddOnName="Eureka.Common.Addons" Guid="d80060cd-caf0-42e8-b427-110407b96e60" Version="1.15" ComponentName="Eureka.Common.Addons" TargetFolder="C:\Work\Eureka.Common.Addons">
  <AddOnDescriptionData><![CDATA[]]></AddOnDescriptionData>
  <Files>
    <File xsi:type="PPAssemblyFile" Type="ClientSideAssembly" FileType="AssemblyFile" Path=".\obj\Debug\Eureka.Common.Addons.dll" Folder="Assemblies" />
    <File xsi:type="PPDBScript" Type="DBScript" FileType="DBScript" Path=".\Create_All.sql" Folder="Database Extension Scripts" />
    <File Type="FormCustomisation" FileType="FormCustomisation" Path=".\common\Sage.MMS.SalesLedger.TransactionEnquiryForm.xml" Folder="Form Customisations" />
    <File Type="FormScript" FileType="FormScript" Path=".\common\Sage.MMS.SalesLedger.TransactionEnquiryForm.vbs" Folder="Form Scripts" />
    <File Type="MenuDifferentialFile" FileType="MenuDifferentialFile" Path=".\menu.dif" Folder="Menu Differential Files" />
    <File Type="FormCustomisation" FileType="ObjectStoreFile" Path=".\Sage200SchemaExtensions.xml" Folder="ObjectStore Extensions" />
    <File xsi:type="PPResourceFile" Type="FormCustomisation" FileType="Resource" Path=".\id_dsa.xml" Folder="Resources" />
  </Files>
  <DefinesFeatures>
    <DefinedFeature Name="Common Addons" Guid="d35b5454-4e36-4c33-b4f4-ee295eb6930e">
      <Targets>
        <Target Name="Common Addons" Guid="19cad96f-e0d9-48d1-8507-78c4862dfbde" Type="VBForm" Action="Eureka.Common.Addons.CommonAddons" Launcher="Sage.MMS.Launcher.Stub">
          <Description />
        </Target>
      </Targets>
    </DefinedFeature>
    <DefinedFeature Name="Subscriptions" Guid="2c657cb9-fc2b-49af-ac19-fa67655ff92e">
      <Targets>
        <Target Name="Subscriptions" Guid="f6c2e6e2-afcc-4838-8345-277ad1000c69" Type="VBForm" Action="Eureka.Common.Addons.Subscriptions" Launcher="Sage.MMS.Launcher.Stub">
          <Description />
        </Target>
      </Targets>
    </DefinedFeature>
  </DefinesFeatures>
  <DigitallySignPackage>false</DigitallySignPackage>
</Project>