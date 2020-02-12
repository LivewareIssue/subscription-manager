Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Accounting
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons

    <Sage.ObjectStore.Builder.PersistentObjectAttribute(TableName:="EurekaSubscription", Name:="EurekaSubscription"),
     System.Runtime.Serialization.DataContractAttribute(IsReference:=True, [Namespace]:="http://schemas.sage.com/sage200/2011/"),
     Sage.ObjectStore.Builder.ParentRelationshipAttribute(ParentObject:="Customer", ParentKey:="SLCustomerAccountID", ChildKey:="CustomerID", InsertOperation:=Sage.ObjectStore.Builder.InsertOperation.CheckParentExists, DeleteOperation:=Sage.ObjectStore.Builder.DeleteOperation.CheckForAnyChildren, ChildColumn:="SLCustomerAccountID"),
     Sage.ObjectStore.Builder.ParentRelationshipAttribute(ParentObject:="EurekaBillingFrequency", ParentKey:="EurekaBillingFrequencyID", ChildKey:="EurekaBillingFrequencyID", InsertOperation:=Sage.ObjectStore.Builder.InsertOperation.CheckParentExists, DeleteOperation:=Sage.ObjectStore.Builder.DeleteOperation.CheckForAnyChildren),
     Sage.ObjectStore.Builder.ParentRelationshipAttribute(ParentObject:="EurekaCommonAddon", ParentKey:="EurekaCommonAddonID", ChildKey:="EurekaCommonAddonID", InsertOperation:=Sage.ObjectStore.Builder.InsertOperation.CheckParentExists, DeleteOperation:=Sage.ObjectStore.Builder.DeleteOperation.CheckForAnyChildren)>
    Public Class PersistentEurekaSubscription
        Inherits Sage.ObjectStore.PersistentObject

        '''<summary>
        '''EurekaSubscriptionID Field Name
        '''</summary>
        Public Const FIELD_EUREKASUBSCRIPTION As String = "EurekaSubscription"

        Protected _EurekaSubscription As Sage.ObjectStore.Field

        '''<summary>
        '''CustomerID Field Name
        '''</summary>
        Public Const FIELD_CUSTOMERDBKEY As String = "CustomerDbKey"

        '''<summary>
        '''The ID of the customer account that owns the subscription
        '''</summary>
        Protected _Customer As Sage.ObjectStore.Field

        '''<summary>
        '''CustomerID Field Name Foreign
        '''</summary>
        Public Const FIELD_CUSTOMEROBJECT As String = "Customer"

        '''<summary>
        '''Customer Foreign Object
        '''</summary>
        Protected _CustomerObject As Sage.ObjectStore.Field

        '''<summary>
        '''EurekaCommonAddonID Field Name
        '''</summary>
        Public Const FIELD_EUREKACOMMONADDONDBKEY As String = "EurekaCommonAddonDbKey"

        '''<summary>
        '''The ID of the common addon that the customer is subscribed to
        '''</summary>
        Protected _EurekaCommonAddon As Sage.ObjectStore.Field

        '''<summary>
        '''EurekaCommonAddonID Field Name Foreign
        '''</summary>
        Public Const FIELD_EUREKACOMMONADDONOBJECT As String = "EurekaCommonAddon"

        '''<summary>
        '''EurekaCommonAddon Foreign Object
        '''</summary>
        Protected _EurekaCommonAddonObject As Sage.ObjectStore.Field

        '''<summary>
        '''ExpiryDate Field Name
        '''</summary>
        Public Const FIELD_EXPIRYDATE As String = "ExpiryDate"

        '''<summary>
        '''The date on which the customer's subscription expires
        '''</summary>
        Protected _ExpiryDate As Sage.ObjectStore.Field

        '''<summary>
        '''CostPerBillingCycle Field Name
        '''</summary>
        Public Const FIELD_COSTPERBILLINGCYCLE As String = "CostPerBillingCycle"

        Protected _CostPerBillingCycle As Sage.ObjectStore.Field

        '''<summary>
        '''EurekaBillingFrequencyID Field Name
        '''</summary>
        Public Const FIELD_EUREKABILLINGFREQUENCYDBKEY As String = "EurekaBillingFrequencyDbKey"

        Protected _EurekaBillingFrequency As Sage.ObjectStore.Field

        '''<summary>
        '''EurekaBillingFrequencyID Field Name Foreign
        '''</summary>
        Public Const FIELD_EUREKABILLINGFREQUENCYOBJECT As String = "EurekaBillingFrequency"

        '''<summary>
        '''EurekaBillingFrequency Foreign Object
        '''</summary>
        Protected _EurekaBillingFrequencyObject As Sage.ObjectStore.Field

        '''<summary>
        '''LicenseKey Field Name
        '''</summary>
        Public Const FIELD_LICENSEKEY As String = "LicenseKey"

        Protected _LicenseKey As Sage.ObjectStore.Field

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(ColumnName:="EurekaSubscriptionID", IsReadOnly:=True, AllowOverwrite:=Sage.ObjectStore.Builder.AllowOverwriteType.Equal, IsPrimaryKey:=True, IsIndexed:=True, IsUnique:=True, DbType:=System.Data.DbType.Int64, Precision:=11)>
        Public Overridable ReadOnly Property EurekaSubscription() As Sage.Common.Data.DbKey
            Get
                Return Me._EurekaSubscription.GetDbKey
            End Get
        End Property

        '''<summary>
        '''The ID of the customer account that owns the subscription
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_Customer", ColumnName:="SLCustomerAccountID", Description:="The ID of the customer account that owns the subscription", IsNullable:=True, DbType:=System.Data.DbType.Int64, Precision:=11, LinkedFieldName:="Customer")>
        Public Overridable Property CustomerDbKey() As Sage.Common.Data.DbKey
            Get
                Return Me._Customer.GetDbKey
            End Get
            Set
                If (Value <> Me._Customer.GetDbKey) Then
                    Me._CustomerObject.Value = Nothing
                End If
                Me._Customer.Value = Value
            End Set
        End Property

        '''<summary>
        '''The ID of the customer account that owns the subscription
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_CustomerObject", DbType:=System.Data.DbType.[Object], IsNullable:=True, IsTransient:=True, LinkedFieldName:="CustomerDbKey")>
        Public Overridable Property Customer() As PersistentCustomer
            Get
                If Me._CustomerObject.IsNull Then
                    Me._CustomerObject.ValueRaw = Me.GetForeignObject(New PersistentCustomer(), Me._Customer.GetDbKey)
                End If
                Return CType(Me._CustomerObject.Value, PersistentCustomer)
            End Get
            Set
                Me._CustomerObject.Value = Value
                If (Value Is Nothing) Then
                    Me._Customer.Value = Nothing
                Else
                    Me._Customer.Value = Me.Customer.PrimaryKey.Value
                End If
            End Set
        End Property

        '''<summary>
        '''The ID of the common addon that the customer is subscribed to
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_EurekaCommonAddon", ColumnName:="EurekaCommonAddonID", Description:="The ID of the common addon that the customer is subscribed to", IsNullable:=True, DbType:=System.Data.DbType.Int64, Precision:=11, LinkedFieldName:="EurekaCommonAddon")>
        Public Overridable Property EurekaCommonAddonDbKey() As Sage.Common.Data.DbKey
            Get
                Return Me._EurekaCommonAddon.GetDbKey
            End Get
            Set
                If (Value <> Me._EurekaCommonAddon.GetDbKey) Then
                    Me._EurekaCommonAddonObject.Value = Nothing
                End If
                Me._EurekaCommonAddon.Value = Value
            End Set
        End Property

        '''<summary>
        '''The ID of the common addon that the customer is subscribed to
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_EurekaCommonAddonObject", DbType:=System.Data.DbType.[Object], IsNullable:=True, IsTransient:=True, LinkedFieldName:="EurekaCommonAddonDbKey")>
        Public Overridable Property EurekaCommonAddon() As PersistentEurekaCommonAddon
            Get
                If Me._EurekaCommonAddonObject.IsNull Then
                    Me._EurekaCommonAddonObject.ValueRaw = Me.GetForeignObject(New PersistentEurekaCommonAddon(), Me._EurekaCommonAddon.GetDbKey)
                End If
                Return CType(Me._EurekaCommonAddonObject.Value, PersistentEurekaCommonAddon)
            End Get
            Set
                Me._EurekaCommonAddonObject.Value = Value
                If (Value Is Nothing) Then
                    Me._EurekaCommonAddon.Value = Nothing
                Else
                    Me._EurekaCommonAddon.Value = Me.EurekaCommonAddon.PrimaryKey.Value
                End If
            End Set
        End Property

        '''<summary>
        '''The date on which the customer's subscription expires
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="The date on which the customer's subscription expires", DbType:=System.Data.DbType.[Date])>
        Public Overridable Property ExpiryDate() As Date
            Get
                Return Me._ExpiryDate.GetDateTime
            End Get
            Set
                Me._ExpiryDate.Value = Value
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[Decimal], Precision:=18)>
        Public Overridable Property CostPerBillingCycle() As Decimal
            Get
                Return Me._CostPerBillingCycle.GetDecimal
            End Get
            Set
                Me._CostPerBillingCycle.Value = Value
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_EurekaBillingFrequency", ColumnName:="EurekaBillingFrequencyID", DbType:=System.Data.DbType.Int64, Precision:=11, LinkedFieldName:="EurekaBillingFrequency")>
        Public Overridable Property EurekaBillingFrequencyDbKey() As Sage.Common.Data.DbKey
            Get
                Return Me._EurekaBillingFrequency.GetDbKey
            End Get
            Set
                If (Value <> Me._EurekaBillingFrequency.GetDbKey) Then
                    Me._EurekaBillingFrequencyObject.Value = Nothing
                End If
                Me._EurekaBillingFrequency.Value = Value
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_EurekaBillingFrequencyObject", DbType:=System.Data.DbType.[Object], IsNullable:=True, IsTransient:=True, LinkedFieldName:="EurekaBillingFrequencyDbKey")>
        Public Overridable Property EurekaBillingFrequency() As PersistentEurekaBillingFrequency
            Get
                If Me._EurekaBillingFrequencyObject.IsNull Then
                    Me._EurekaBillingFrequencyObject.ValueRaw = Me.GetForeignObject(New PersistentEurekaBillingFrequency(), Me._EurekaBillingFrequency.GetDbKey)
                End If
                Return CType(Me._EurekaBillingFrequencyObject.Value, PersistentEurekaBillingFrequency)
            End Get
            Set
                Me._EurekaBillingFrequencyObject.Value = Value
                If (Value Is Nothing) Then
                    Me._EurekaBillingFrequency.Value = Nothing
                Else
                    Me._EurekaBillingFrequency.Value = Me.EurekaBillingFrequency.PrimaryKey.Value
                End If
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[String], Precision:=2147483647)>
        Public Overridable Property LicenseKey() As String
            Get
                Return Me._LicenseKey.GetString
            End Get
            Set
                Me._LicenseKey.Value = Value
            End Set
        End Property
    End Class

    <System.Runtime.Serialization.DataContractAttribute(IsReference:=True, [Namespace]:="http://schemas.sage.com/sage200/2011/")>
    Public Class PersistentEurekaSubscriptions
        Inherits Sage.ObjectStore.PersistentObjectCollection

        Public Sub New()
            MyBase.New
        End Sub

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Default Public Overridable Shadows Property Item(ByVal index As Integer) As PersistentEurekaSubscription
            Get
                Return CType(MyBase.Item(index), PersistentEurekaSubscription)
            End Get
            Set
                MyBase.Item(index) = Value
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Overrides Property Owner() As Sage.ObjectStore.PersistentObject
            Get
                If (Me.Query.Owner Is Nothing) Then
                    Me.Query.Owner = New PersistentEurekaSubscription()
                End If
                Return Me.Query.Owner
            End Get
            Set
                Throw New System.ArgumentException("You are not allowed to change the Owner property of a collection")
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Overridable Shadows ReadOnly Property First() As PersistentEurekaSubscription
            Get
                Return CType(MyBase.First, PersistentEurekaSubscription)
            End Get
        End Property
    End Class
End Namespace
