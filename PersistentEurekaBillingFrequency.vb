Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons
    
    <Sage.ObjectStore.Builder.PersistentObjectAttribute(TableName:="EurekaBillingFrequency", Name:="EurekaBillingFrequency"),  _
     System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/"),  _
     Sage.ObjectStore.Builder.ChildRelationshipAttribute(ParentKey:="EurekaBillingFrequencyID", ChildObject:="EurekaSubscription", ChildKey:="EurekaBillingFrequencyID", InsertOperation:=Sage.ObjectStore.Builder.InsertOperation.CheckParentExists, DeleteOperation:=Sage.ObjectStore.Builder.DeleteOperation.CheckForAnyChildren)>  _
    Public Class PersistentEurekaBillingFrequency
        Inherits Sage.ObjectStore.PersistentObject
        
        '''<summary>
        '''EurekaBillingFrequencyID Field Name
        '''</summary>
        Public Const FIELD_EUREKABILLINGFREQUENCY As String = "EurekaBillingFrequency"
        
        Protected _EurekaBillingFrequency As Sage.ObjectStore.Field
        
        '''<summary>
        '''Name Field Name
        '''</summary>
        Public Const FIELD_NAME As String = "Name"
        
        Protected _Name As Sage.ObjectStore.Field
        
        Public Const FIELD_EUREKASUBSCRIPTION_EUREKABILLINGFREQUENCYOBJECT As String = "EurekaSubscriptions"
        
        '''<summary>
        '''EurekaSubscription Foreign Object
        '''</summary>
        Protected _EurekaSubscription_EurekaBillingFrequencyObject As Sage.ObjectStore.Field
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(ColumnName:="EurekaBillingFrequencyID", IsReadOnly:=true, AllowOverwrite:=Sage.ObjectStore.Builder.AllowOverwriteType.Equal, IsPrimaryKey:=true, IsIndexed:=true, IsUnique:=true, DbType:=System.Data.DbType.Int64, Precision:=11)>  _
        Public Overridable ReadOnly Property EurekaBillingFrequency() As Sage.Common.Data.DbKey
            Get
                Return Me._EurekaBillingFrequency.GetDbKey
            End Get
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(DbType:=System.Data.DbType.[String], Precision:=60)>  _
        Public Overridable Property Name() As String
            Get
                Return Me._Name.GetString
            End Get
            Set
                Me._Name.Value = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_EurekaSubscription_EurekaBillingFrequencyObject", DbType:=System.Data.DbType.[Object], IsNullable:=true, IsTransient:=true)>  _
        Public Overridable ReadOnly Property EurekaSubscriptions() As PersistentEurekaSubscriptions
            Get
                If Me._EurekaSubscription_EurekaBillingFrequencyObject.IsNull Then
                    Me._EurekaSubscription_EurekaBillingFrequencyObject.ValueRaw = Me.GetForeignObjects(New PersistentEurekaSubscriptions(), "EurekaBillingFrequency", "EurekaBillingFrequency")
                End If
                Return CType(Me._EurekaSubscription_EurekaBillingFrequencyObject.Value,PersistentEurekaSubscriptions)
            End Get
        End Property
    End Class
    
    <System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/")>  _
    Public Class PersistentEurekaBillingFrequencies
        Inherits Sage.ObjectStore.PersistentObjectCollection
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable Default Property Item(ByVal index As Integer) As PersistentEurekaBillingFrequency
            Get
                Return CType(MyBase.Item(index),PersistentEurekaBillingFrequency)
            End Get
            Set
                MyBase.Item(index) = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Overrides Property Owner() As Sage.ObjectStore.PersistentObject
            Get
                If (Me.Query.Owner Is Nothing) Then
                    Me.Query.Owner = New PersistentEurekaBillingFrequency()
                End If
                Return Me.Query.Owner
            End Get
            Set
                Throw New System.ArgumentException("You are not allowed to change the Owner property of a collection")
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable ReadOnly Property First() As PersistentEurekaBillingFrequency
            Get
                Return CType(MyBase.First,PersistentEurekaBillingFrequency)
            End Get
        End Property
    End Class
End Namespace
