Imports System
Imports System.Collections
Imports System.ComponentModel
Imports Sage.Common.Data
Imports Sage.ObjectStore

Namespace Eureka.Common.Addons
    
    Public Class EurekaCustomerSageAccount
        Inherits PersistentEurekaCustomerSageAccount
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal connectionData As Sage.ObjectStore.ConnectionData, ByVal metaDataType As System.Type)
            MyBase.New(connectionData, metaDataType)
        End Sub
    End Class
End Namespace
