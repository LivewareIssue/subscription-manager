Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons
    
    <System.Runtime.Serialization.DataContractAttribute(IsReference:=true, [Namespace]:="http://schemas.sage.com/sage200/2011/")>  _
    Public Class EurekaCommonAddons
        Inherits PersistentEurekaCommonAddons
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable Default Property Item(ByVal index As Integer) As EurekaCommonAddon
            Get
                Return CType(MyBase.Item(index),EurekaCommonAddon)
            End Get
            Set
                MyBase.Item(index) = value
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Overrides Property Owner() As Sage.ObjectStore.PersistentObject
            Get
                If (Me.Query.Owner Is Nothing) Then
                    Me.Query.Owner = New EurekaCommonAddon()
                End If
                Return Me.Query.Owner
            End Get
            Set
                Throw New System.ArgumentException("You are not allowed to change the Owner property of a collection")
            End Set
        End Property
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable ReadOnly Property First() As EurekaCommonAddon
            Get
                Return CType(MyBase.First,EurekaCommonAddon)
            End Get
        End Property
    End Class
End Namespace
