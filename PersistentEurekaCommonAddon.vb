Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons
    
    <Sage.ObjectStore.Builder.PersistentObjectAttribute(TableName:="EurekaCommonAddon", Name:="EurekaCommonAddon"),  _
     System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/"),  _
     Sage.ObjectStore.Builder.ChildRelationshipAttribute(ParentKey:="EurekaCommonAddonID", ChildObject:="EurekaSubscription", ChildKey:="EurekaCommonAddonID", InsertOperation:=Sage.ObjectStore.Builder.InsertOperation.CheckParentExists, DeleteOperation:=Sage.ObjectStore.Builder.DeleteOperation.CheckForAnyChildren)>  _
    Public Class PersistentEurekaCommonAddon
        Inherits Sage.ObjectStore.PersistentObject
        
        '''<summary>
        '''EurekaCommonAddonID Field Name
        '''</summary>
        Public Const FIELD_EUREKACOMMONADDON As String = "EurekaCommonAddon"
        
        Protected _EurekaCommonAddon As Sage.ObjectStore.Field
        
        '''<summary>
        '''Name Field Name
        '''</summary>
        Public Const FIELD_NAME As String = "Name"
        
        '''<summary>
        '''The name of the common add-on
        '''</summary>
        Protected _Name As Sage.ObjectStore.Field
        
        '''<summary>
        '''Description Field Name
        '''</summary>
        Public Const FIELD_DESCRIPTION As String = "Description"
        
        '''<summary>
        '''A description of the common add-on's functionality
        '''</summary>
        Protected _Description As Sage.ObjectStore.Field
        
        '''<summary>
        '''OneOffCost Field Name
        '''</summary>
        Public Const FIELD_ONEOFFCOST As String = "OneOffCost"
        
        '''<summary>
        '''The price of purchasing the add-on outright
        '''</summary>
        Protected _OneOffCost As Sage.ObjectStore.Field
        
        '''<summary>
        '''MonthlyCost Field Name
        '''</summary>
        Public Const FIELD_MONTHLYCOST As String = "MonthlyCost"
        
        '''<summary>
        '''The price paid monthly for use of the add-on
        '''</summary>
        Protected _MonthlyCost As Sage.ObjectStore.Field
        
        '''<summary>
        '''OneOffStandaloneCost Field Name
        '''</summary>
        Public Const FIELD_ONEOFFSTANDALONECOST As String = "OneOffStandaloneCost"
        
        '''<summary>
        '''The price of purchasing the add-on outright, as a standalone application
        '''</summary>
        Protected _OneOffStandaloneCost As Sage.ObjectStore.Field
        
        '''<summary>
        '''MonthlyStandaloneCost Field Name
        '''</summary>
        Public Const FIELD_MONTHLYSTANDALONECOST As String = "MonthlyStandaloneCost"
        
        '''<summary>
        '''The price paid monthly for use of the add-on, as a standalone application
        '''</summary>
        Protected _MonthlyStandaloneCost As Sage.ObjectStore.Field
        
        Public Const FIELD_EUREKASUBSCRIPTION_EUREKACOMMONADDONOBJECT As String = "EurekaSubscriptions"
        
        '''<summary>
        '''EurekaSubscription Foreign Object
        '''</summary>
        Protected _EurekaSubscription_EurekaCommonAddonObject As Sage.ObjectStore.Field
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(ColumnName:="EurekaCommonAddonID", IsReadOnly:=true, AllowOverwrite:=Sage.ObjectStore.Builder.AllowOverwriteType.Equal, IsPrimaryKey:=true, IsIndexed:=true, IsUnique:=true, DbType:=System.Data.DbType.Int64, Precision:=11)>  _
        Public Overridable ReadOnly Property EurekaCommonAddon() As Sage.Common.Data.DbKey
            Get
                Return Me._EurekaCommonAddon.GetDbKey
            End Get
        End Property
        
        '''<summary>
        '''The name of the common add-on
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="The name of the common add-on", DbType:=System.Data.DbType.[String], Precision:=60)>  _
        Public Overridable Property Name() As String
            Get
                Return Me._Name.GetString
            End Get
            Set
                Me._Name.Value = value
            End Set
        End Property
        
        '''<summary>
        '''A description of the common add-on's functionality
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="A description of the common add-on's functionality", DbType:=System.Data.DbType.[String], Precision:=2147483647)>  _
        Public Overridable Property Description() As String
            Get
                Return Me._Description.GetString
            End Get
            Set
                Me._Description.Value = value
            End Set
        End Property
        
        '''<summary>
        '''The price of purchasing the add-on outright
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="The price of purchasing the add-on outright", DbType:=System.Data.DbType.[Decimal], Precision:=18)>  _
        Public Overridable Property OneOffCost() As Decimal
            Get
                Return Me._OneOffCost.GetDecimal
            End Get
            Set
                Me._OneOffCost.Value = value
            End Set
        End Property
        
        '''<summary>
        '''The price paid monthly for use of the add-on
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="The price paid monthly for use of the add-on", DbType:=System.Data.DbType.[Decimal], Precision:=18)>  _
        Public Overridable Property MonthlyCost() As Decimal
            Get
                Return Me._MonthlyCost.GetDecimal
            End Get
            Set
                Me._MonthlyCost.Value = value
            End Set
        End Property
        
        '''<summary>
        '''The price of purchasing the add-on outright, as a standalone application
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="The price of purchasing the add-on outright, as a standalone application", DbType:=System.Data.DbType.[Decimal], Precision:=18)>  _
        Public Overridable Property OneOffStandaloneCost() As Decimal
            Get
                Return Me._OneOffStandaloneCost.GetDecimal
            End Get
            Set
                Me._OneOffStandaloneCost.Value = value
            End Set
        End Property
        
        '''<summary>
        '''The price paid monthly for use of the add-on, as a standalone application
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(Description:="The price paid monthly for use of the add-on, as a standalone application", DbType:=System.Data.DbType.[Decimal], Precision:=18)>  _
        Public Overridable Property MonthlyStandaloneCost() As Decimal
            Get
                Return Me._MonthlyStandaloneCost.GetDecimal
            End Get
            Set
                Me._MonthlyStandaloneCost.Value = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden),  _
         Sage.ObjectStore.Builder.MetaDataFieldAttribute(FieldPropertyName:="_EurekaSubscription_EurekaCommonAddonObject", DbType:=System.Data.DbType.[Object], IsNullable:=true, IsTransient:=true)>  _
        Public Overridable ReadOnly Property EurekaSubscriptions() As PersistentEurekaSubscriptions
            Get
                If Me._EurekaSubscription_EurekaCommonAddonObject.IsNull Then
                    Me._EurekaSubscription_EurekaCommonAddonObject.ValueRaw = Me.GetForeignObjects(New PersistentEurekaSubscriptions(), "EurekaCommonAddon", "EurekaCommonAddon")
                End If
                Return CType(Me._EurekaSubscription_EurekaCommonAddonObject.Value,PersistentEurekaSubscriptions)
            End Get
        End Property
    End Class
    
    <System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/")>  _
    Public Class PersistentEurekaCommonAddons
        Inherits Sage.ObjectStore.PersistentObjectCollection
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable Default Property Item(ByVal index As Integer) As PersistentEurekaCommonAddon
            Get
                Return CType(MyBase.Item(index),PersistentEurekaCommonAddon)
            End Get
            Set
                MyBase.Item(index) = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Overrides Property Owner() As Sage.ObjectStore.PersistentObject
            Get
                If (Me.Query.Owner Is Nothing) Then
                    Me.Query.Owner = New PersistentEurekaCommonAddon()
                End If
                Return Me.Query.Owner
            End Get
            Set
                Throw New System.ArgumentException("You are not allowed to change the Owner property of a collection")
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable ReadOnly Property First() As PersistentEurekaCommonAddon
            Get
                Return CType(MyBase.First,PersistentEurekaCommonAddon)
            End Get
        End Property
    End Class
End Namespace
