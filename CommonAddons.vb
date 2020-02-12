Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports Eureka.Common.LicenseManager
Imports Sage.Common.Controls

Public Class CommonAddons
    Private Sub PopulateCommonAddonsGrid()
        'Clear the grid
        CommonAddonsGrid.DataSource = Nothing
        CommonAddonsGrid.RefreshContents()

        'Create a new data-source
        Dim commonAddons As New Eureka.Common.Addons.EurekaCommonAddons
        commonAddons.Query.Sorts.Add(New Sage.ObjectStore.Sort(Eureka.Common.Addons.PersistentEurekaCommonAddon.FIELD_NAME))

        'Mapping fromn grid-column indices to table headers
        Dim myColumnMapping As New Dictionary(Of Integer, String) From {
            {0, "Name"},
            {1, "Description"},
            {2, "OneOffCost"},
            {3, "MonthlyCost"},
            {4, "OneOffStandaloneCost"},
            {5, "MonthlyStandaloneCost"}
        }

        If commonAddons.Count > 0 Then
            CommonAddonsGrid.DataSource = commonAddons

            'Assign each grid-column to its respective column from the data-source
            For Each pair As KeyValuePair(Of Integer, String) In myColumnMapping
                CommonAddonsGrid.Columns(pair.Key).DisplayMember = pair.Value
                CommonAddonsGrid.Columns(pair.Key).ValueMember = pair.Value
            Next
        End If

        SelectedItemChanged()
    End Sub

    Private Sub SelectedItemChanged()
        'Toggle which buttons are enabled depending on how many rows are selected within the grid
        ViewButton.Enabled = CommonAddonsGrid.SelectedItems.Count = 1
        EditButton.Enabled = CommonAddonsGrid.SelectedItems.Count = 1
        RemoveButton.Enabled = CommonAddonsGrid.SelectedItems.Count > 0
    End Sub

    Private Sub CommonAddons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCommonAddonsGrid()
    End Sub

#Region "CommonAddonsGrid Event-Handlers"
    Private Sub CommonAddonsGrid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CommonAddonsGrid.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Delete
                RemoveButton.PerformClick()
            Case System.Windows.Forms.Keys.Enter
                ViewButton.PerformClick()
        End Select
    End Sub

    Private Sub CommonAddonsGrid_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CommonAddonsGrid.MouseDoubleClick
        EditButton.PerformClick()
    End Sub

    Private Sub CommonAddonsGrid_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CommonAddonsGrid.MouseClick
        SelectedItemChanged()
    End Sub

    Private Sub CommonAddonsGrid_SelectedIndexChanged(sender As Object, e As ListItemEventArgs) Handles CommonAddonsGrid.SelectedIndexChanged
        SelectedItemChanged()
    End Sub
#End Region

#Region "Button Event-Handlers"
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Call New CommonAddon().ShowDialog()
        PopulateCommonAddonsGrid()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Call New CommonAddon(CType(CommonAddonsGrid.SelectedItems(0).DataSource, Eureka.Common.Addons.EurekaCommonAddon), OpenMode.View).ShowDialog()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Call New CommonAddon(CType(CommonAddonsGrid.SelectedItems(0).DataSource, Eureka.Common.Addons.EurekaCommonAddon), OpenMode.Edit).ShowDialog()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim prompt As String = $"You are about to delete {CommonAddonsGrid.SelectedItems.Count} row(s)." + Environment.NewLine + Environment.NewLine + "Click yes To permentantly delete these rows. You won't be able to undo these changes"

        If (MsgBox(prompt, MsgBoxStyle.YesNo, "Remove Addon(s)") = MsgBoxResult.Yes) Then
            For Each selectedItem As ListItem In CommonAddonsGrid.SelectedItems.Clone
                CType(selectedItem.DataSource, Eureka.Common.Addons.EurekaCommonAddon).Delete()
            Next
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub
#End Region

End Class