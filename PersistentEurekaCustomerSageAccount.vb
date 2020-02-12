Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons
    
    <Sage.ObjectStore.Builder.PersistentObjectAttribute(TableName:="EurekaCustomerSageAccounts", Name:="EurekaCustomerSageAccount"),  _
     System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/")>  _
    Public Class PersistentEurekaCustomerSageAccount
        Inherits Sage.ObjectStore.PersistentObject
        
        '''<summary>
        '''CustomerAccountNumber Field Name
        '''</summary>
        Public Const FIELD_CUSTOMERACCOUNTNUMBER As String = "CustomerAccountNumber"
        
        Protected _CustomerAccountNumber As Sage.ObjectStore.Field
        
        '''<summary>
        '''CustomerAccountName Field Name
        '''</summary>
        Public Const FIELD_CUSTOMERACCOUNTNAME As String = "CustomerAccountName"
        
        Protected _CustomerAccountName As Sage.ObjectStore.Field
        
        '''<summary>
        '''SageAccountNumber Field Name
        '''</summary>
        Public Const FIELD_SAGEACCOUNTNUMBER As String = "SageAccountNumber"
        
        Protected _SageAccountNumber As Sage.ObjectStore.Field
        
        '''<summary>
        '''Sage200SerialNumber Field Name
        '''</summary>
        Public Const FIELD_SAGE200SERIALNUMBER As String = "Sage200SerialNumber"
        
        Protected _Sage200SerialNumber As Sage.ObjectStore.Field
        
        '''<summary>
        '''SLCustomerAccountID Field Name
        '''</summary>
        Public Const FIELD_SLCUSTOMERACCOUNT As String = "SLCustomerAccount"
        
        Protected _SLCustomerAccount As Sage.ObjectStore.Field
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[String], Precision:=8)>  _
        Public Overridable Property CustomerAccountNumber() As String
            Get
                Return Me._CustomerAccountNumber.GetString
            End Get
            Set
                Me._CustomerAccountNumber.Value = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[String], Precision:=60)>  _
        Public Overridable Property CustomerAccountName() As String
            Get
                Return Me._CustomerAccountName.GetString
            End Get
            Set
                Me._CustomerAccountName.Value = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[String], Precision:=20)>  _
        Public Overridable Property SageAccountNumber() As String
            Get
                Return Me._SageAccountNumber.GetString
            End Get
            Set
                Me._SageAccountNumber.Value = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[String], Precision:=20)>  _
        Public Overridable Property Sage200SerialNumber() As String
            Get
                Return Me._Sage200SerialNumber.GetString
            End Get
            Set
                Me._Sage200SerialNumber.Value = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(ColumnName:="SLCustomerAccountID", IsNullable:=true, AllowOverwrite:=Sage.ObjectStore.Builder.AllowOverwriteType.Equal, DbType:=System.Data.DbType.Int64, Precision:=11)>  _
        Public Overridable Property SLCustomerAccount() As Long
            Get
                Return Me._SLCustomerAccount.GetInt64
            End Get
            Set
                Me._SLCustomerAccount.Value = value
            End Set
        End Property
    End Class
    
    <System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/")>  _
    Public Class PersistentEurekaCustomerSageAccounts
        Inherits Sage.ObjectStore.PersistentObjectCollection
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable Default Property Item(ByVal index As Integer) As PersistentEurekaCustomerSageAccount
            Get
                Return CType(MyBase.Item(index),PersistentEurekaCustomerSageAccount)
            End Get
            Set
                MyBase.Item(index) = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Overrides Property Owner() As Sage.ObjectStore.PersistentObject
            Get
                If (Me.Query.Owner Is Nothing) Then
                    Me.Query.Owner = New PersistentEurekaCustomerSageAccount()
                End If
                Return Me.Query.Owner
            End Get
            Set
                Throw New System.ArgumentException("You are not allowed to change the Owner property of a collection")
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable ReadOnly Property First() As PersistentEurekaCustomerSageAccount
            Get
                Return CType(MyBase.First,PersistentEurekaCustomerSageAccount)
            End Get
        End Property
    End Class
End Namespace
