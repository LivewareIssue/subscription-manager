Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Accounting.SalesLedger
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons

    Public Class EurekaSubscription
        Inherits PersistentEurekaSubscription

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub

        '''<summary>
        '''The ID of the customer account that owns the subscription
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Overridable Shadows Property Customer() As Customer
            Get
                If (_CustomerObject.Value Is Nothing) Then
                    If MyBase._Customer.GetDbKey.IsNull Then
                        _CustomerObject.ValueRaw = CustomerFactory.Factory.CreateNew
                    Else
                        _CustomerObject.ValueRaw = CustomerFactory.Factory.Fetch(MyBase._Customer.GetDbKey)
                    End If
                End If
                Return CType(_CustomerObject.Value, Customer)
            End Get
            Set
                _CustomerObject.Value = Value
                If (Value Is Nothing) Then
                    MyBase._Customer.Value = Nothing
                Else
                    MyBase._Customer.Value = Value.PrimaryKey.Value
                End If
            End Set
        End Property

        '''<summary>
        '''The ID of the common addon that the customer is subscribed to
        '''</summary>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Overridable Shadows Property EurekaCommonAddon() As EurekaCommonAddon
            Get
                If MyBase._EurekaCommonAddonObject.IsNull Then
                    MyBase._EurekaCommonAddonObject.ValueRaw = MyBase.GetForeignObject(New EurekaCommonAddon(), MyBase._EurekaCommonAddon.GetDbKey)
                End If
                Return CType(MyBase._EurekaCommonAddonObject.Value, EurekaCommonAddon)
            End Get
            Set
                MyBase.EurekaCommonAddon = Value
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Overridable Shadows Property EurekaBillingFrequency() As EurekaBillingFrequency
            Get
                If MyBase._EurekaBillingFrequencyObject.IsNull Then
                    MyBase._EurekaBillingFrequencyObject.ValueRaw = MyBase.GetForeignObject(New EurekaBillingFrequency(), MyBase._EurekaBillingFrequency.GetDbKey)
                End If
                Return CType(MyBase._EurekaBillingFrequencyObject.Value, EurekaBillingFrequency)
            End Get
            Set
                MyBase.EurekaBillingFrequency = Value
            End Set
        End Property
    End Class
End Namespace
