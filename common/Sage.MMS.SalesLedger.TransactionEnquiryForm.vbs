Imports System
Imports System.Windows.Forms
Imports Sage200Scripts
Imports Sage.Common.Amendability
Imports Eureka.Common.Addons
Imports Sage.MMS.Controls

Module addInModule
    Public Sub Main
        Dim subscriptionsButton As Sage.Common.Controls.Button = CType(Form.FindControlByName("subscriptionsButton").UnderlyingControl, Sage.Common.Controls.Button)

		AddHandler subscriptionsButton.Click, AddressOf SubscribersButton_Click
    End Sub
	
	Public Sub SubscribersButton_Click(sender as object, e as System.EventArgs)
		Dim customerLookup As Sage.MMS.Controls.CustomerInvoiceLookup = CType(Form.FindControlByName("customerLookup").UnderlyingControl, Sage.MMS.Controls.CustomerInvoiceLookup)
	
		Call New Eureka.Common.Addons.Subscriptions(customerLookup.Customer).ShowDialog()
	End Sub
End Module