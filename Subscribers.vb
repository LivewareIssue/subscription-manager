Imports System.Collections.Generic
Imports Eureka.Common.Addons.Eureka.Common.Addons
Imports Sage.Common.Controls
Imports Sage.Common.Data

Public Class Subscribers
    Private mode As OpenMode
    Private selectedAddon As EurekaCommonAddon
    Private parentWindow As CommonAddon

    Public Sub New(parentWindow As CommonAddon, selectedAddon As EurekaCommonAddon, mode As OpenMode)
        InitializeComponent()
        Me.parentWindow = parentWindow
        Me.selectedAddon = selectedAddon
        Me.mode = mode
    End Sub

    Private Sub PopulateSubscribersGrid()
        'Clear the grid
        SubscribersGrid.DataSource = Nothing
        SubscribersGrid.RefreshContents()

        'Create a new data-source
        Dim subscriptions As New EurekaSubscriptions
        subscriptions.Query.Filters.Add(New Sage.ObjectStore.Filter(EurekaSubscription.FIELD_EUREKACOMMONADDONDBKEY, FilterOperator.Equal, selectedAddon.EurekaCommonAddon))

        'Mapping fromn grid-column indices to table headers
        Dim columnMapping As New Dictionary(Of Integer, String) From {
            {0, "Customer.Name"},
            {1, "EurekaBillingFrequency.Name"},
            {2, "ExpiryDate"},
            {3, "CostPerBillingCycle"}
        }

        If subscriptions.Count > 0 Then
            SubscribersGrid.DataSource = subscriptions

            'Assign each grid-column to its respective column from the data-source
            For Each pair As KeyValuePair(Of Integer, String) In columnMapping
                SubscribersGrid.Columns(pair.Key).DisplayMember = pair.Value
                SubscribersGrid.Columns(pair.Key).ValueMember = pair.Value
            Next
        End If

    End Sub

    Private Sub SelectedItemChanged()
        AddButton.Enabled = (mode <> OpenMode.View)
        ViewButton.Enabled = (SubscribersGrid.SelectedItems.Count = 1)
        EditButton.Enabled = (mode <> OpenMode.View) And (SubscribersGrid.SelectedItems.Count = 1)
        RemoveButton.Enabled = (mode <> OpenMode.View) And (SubscribersGrid.SelectedItems.Count > 0)
    End Sub

    Private Sub Subscriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case mode
            Case OpenMode.Add
                If selectedAddon.Name = "" Then
                    Text = "Managing Subscribers of New Addon"
                Else
                    Text = $"Managing Subscribers of ""{selectedAddon.Name}"""
                End If
            Case OpenMode.Edit
                Text = $"Managing Subscribers of ""{selectedAddon.Name}"""
            Case OpenMode.View
                Text = $"Viewing Subscribers of ""{selectedAddon.Name}"""
        End Select

        PopulateSubscribersGrid()
        SelectedItemChanged()
    End Sub

    Private Sub SubscriptionsGrid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SubscribersGrid.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Delete
                RemoveButton.PerformClick()
            Case System.Windows.Forms.Keys.Enter
                ViewButton.PerformClick()
        End Select
    End Sub

    Private Sub SubscriptionsGrid_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SubscribersGrid.MouseDoubleClick
        If SubscribersGrid.SelectedItems.Count = 1 Then
            EditButton.PerformClick()
        End If
    End Sub

    Private Sub SubscriptionsGrid_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SubscribersGrid.MouseClick
        SelectedItemChanged()
    End Sub

    Private Sub SubscriptionsGrid_SelectedIndexChanged(sender As Object, e As Sage.Common.Controls.ListItemEventArgs) Handles SubscribersGrid.SelectedIndexChanged
        SelectedItemChanged()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Call New Subscriber(parentWindow, selectedAddon).ShowDialog()
        PopulateSubscribersGrid()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        If SubscribersGrid.SelectedItems.Count = 1 Then
            Call New Subscriber(parentWindow, selectedAddon, CType(SubscribersGrid.SelectedItems(0).DataSource, EurekaSubscription), OpenMode.View).ShowDialog()
        Else
            MsgBox("Select a row to view.", MsgBoxStyle.OkOnly, "Subscriptions")
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If SubscribersGrid.SelectedItems.Count = 1 Then
            Call New Subscriber(parentWindow, selectedAddon, CType(SubscribersGrid.SelectedItems(0).DataSource, EurekaSubscription), OpenMode.Edit).ShowDialog()
        Else
            MsgBox("Select a row to edit.", MsgBoxStyle.OkOnly, "Subscriptions")
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If SubscribersGrid.SelectedItems.Count > 0 Then
            Dim prompt As String = $"You are about to delete {SubscribersGrid.SelectedItems.Count} row(s)." + Environment.NewLine + Environment.NewLine + "Click yes To permentantly delete these rows. You won't be able to undo these changes"

            If (MsgBox(prompt, MsgBoxStyle.YesNo, "Remove Subscriber(s)") = MsgBoxResult.Yes) Then
                For Each selectedItem As ListItem In SubscribersGrid.SelectedItems.Clone

                    parentWindow.changes.Add($"Unsubscribed ""{CType(selectedItem.DataSource, EurekaSubscription).Customer.Name}""")
                    CType(selectedItem.DataSource, EurekaSubscription).Delete()
                Next

                parentWindow.subscriptionsModified = True
            End If
        Else
            MsgBox("Select one or more rows to delete.", MsgBoxStyle.OkOnly, "Subscriptions")
        End If
    End Sub
End Class