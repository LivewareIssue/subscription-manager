Imports System.Collections.Generic
Imports Eureka.Common.Addons.Eureka.Common.Addons
Imports Sage.Accounting.SalesLedger
Imports Sage.Common.Controls
Imports Sage.Common.Data

Public Class Subscriptions

    Private selectedCustomer As Customer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(selectedCustomer As Customer)
        InitializeComponent()
        Me.selectedCustomer = selectedCustomer
    End Sub

    Private Sub PopulateSubscriptionsGrid()
        'Clear the grid
        SubscriptionsGrid.DataSource = Nothing
        SubscriptionsGrid.RefreshContents()

        'Create a new data-source
        Dim subscriptions As New EurekaSubscriptions

        'Mapping fromn grid-column indices to table headers
        Dim columnMapping As New Dictionary(Of Integer, String) From {
            {0, "Customer.Name"},
            {1, "EurekaCommonAddon.Name"},
            {2, "EurekaCommonAddon.Description"},
            {3, "EurekaCommonAddon.OneOffCost"},
            {4, "EurekaCommonAddon.MonthlyCost"},
            {5, "EurekaCommonAddon.OneOffStandaloneCost"},
            {6, "EurekaCommonAddon.MonthlyStandaloneCost"},
            {7, "EurekaBillingFrequency.Name"},
            {8, "ExpiryDate"},
            {9, "CostPerBillingCycle"}
        }

        If IsNothing(selectedCustomer) Then
            'subscriptions.Query.Sorts.Add(New Sage.ObjectStore.Sort("Customer.Name"))
        Else
            SubscriptionsGrid.Columns(0).Visible = False
            subscriptions.Query.Filters.Add(New Sage.ObjectStore.Filter(EurekaSubscription.FIELD_CUSTOMERDBKEY, FilterOperator.Equal, selectedCustomer.SLCustomerAccount))
        End If

        'subscriptions.Query.Sorts.Add(New Sage.ObjectStore.Sort("EurekaCommonAddon.Name"))

        If subscriptions.Count > 0 Then
            SubscriptionsGrid.DataSource = subscriptions

            'Assign each grid-column to its respective column from the data-source
            For Each pair As KeyValuePair(Of Integer, String) In columnMapping
                SubscriptionsGrid.Columns(pair.Key).DisplayMember = pair.Value
                SubscriptionsGrid.Columns(pair.Key).ValueMember = pair.Value
            Next
        End If

    End Sub

    Private Sub SelectedItemChanged()
        'Toggle which buttons are enabled depending on how many rows are selected within the grid
        ViewButton.Enabled = SubscriptionsGrid.SelectedItems.Count = 1
        EditButton.Enabled = SubscriptionsGrid.SelectedItems.Count = 1
        RemoveButton.Enabled = SubscriptionsGrid.SelectedItems.Count > 0
    End Sub

    Private Sub Subscriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(selectedCustomer) Then
            Text = "Subscriptions"
        Else
            Text = $"Managing Subscriptions of {selectedCustomer.Name}"
        End If

        PopulateSubscriptionsGrid()
        SelectedItemChanged()
    End Sub

#Region "SubscriptionsGrid Event-Handlers"
    Private Sub SubscriptionsGrid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SubscriptionsGrid.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Delete
                RemoveButton.PerformClick()
            Case System.Windows.Forms.Keys.Enter
                ViewButton.PerformClick()
        End Select
    End Sub

    Private Sub SubscriptionsGrid_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SubscriptionsGrid.MouseDoubleClick
        EditButton.PerformClick()
    End Sub

    Private Sub SubscriptionsGrid_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SubscriptionsGrid.MouseClick
        SelectedItemChanged()
    End Sub

    Private Sub SubscriptionsGrid_SelectedIndexChanged(sender As Object, e As Sage.Common.Controls.ListItemEventArgs) Handles SubscriptionsGrid.SelectedIndexChanged
        SelectedItemChanged()
    End Sub
#End Region

#Region "Button Event-Handlers"
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If IsNothing(selectedCustomer) Then
            Call New Subscription().ShowDialog()
        Else
            Call New Subscription(selectedCustomer, OpenMode.Add).ShowDialog()
        End If

        PopulateSubscriptionsGrid()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Call New Subscription(CType(SubscriptionsGrid.SelectedItems(0).DataSource, EurekaSubscription), OpenMode.View).ShowDialog()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Call New Subscription(CType(SubscriptionsGrid.SelectedItems(0).DataSource, EurekaSubscription), OpenMode.Edit).ShowDialog()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim prompt As String = $"You are about to delete {SubscriptionsGrid.SelectedItems.Count} row(s)." + Environment.NewLine + Environment.NewLine + "Click yes To permentantly delete these rows. You won't be able to undo these changes"

        If (MsgBox(prompt, MsgBoxStyle.YesNo, "Remove Subscription(s)") = MsgBoxResult.Yes) Then
            For Each selectedItem As ListItem In SubscriptionsGrid.SelectedItems.Clone
                CType(selectedItem.DataSource, EurekaSubscription).Delete()
            Next
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub
#End Region

End Class