Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons
    
    Public Class EurekaCommonAddon
        Inherits PersistentEurekaCommonAddon
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub
        
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
        Public Shadows Overridable ReadOnly Property EurekaSubscriptions() As EurekaSubscriptions
            Get
                If MyBase._EurekaSubscription_EurekaCommonAddonObject.IsNull Then
                    MyBase._EurekaSubscription_EurekaCommonAddonObject.ValueRaw = MyBase.GetForeignObjects(New EurekaSubscriptions(), "EurekaCommonAddon", "EurekaCommonAddon")
                End If
                Return CType(MyBase._EurekaSubscription_EurekaCommonAddonObject.Value,EurekaSubscriptions)
            End Get
        End Property
    End Class
End Namespace
