Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports Eureka.Common.Addons.Eureka.Common.Addons
Imports Sage.Common.Data
Imports Sage.ObjectStore.Controls

Public Class CommonAddon
    Private mode As OpenMode
    Private selectedAddon As EurekaCommonAddon
    Private initialSubscriptions As New List(Of EurekaSubscription)

    Public changes As New List(Of String)
    Public subscriptionsModified As Boolean = False

    Public Sub New()
        InitializeComponent()
        selectedAddon = New EurekaCommonAddon
        selectedAddon.Update()
        mode = OpenMode.Add
    End Sub

    Public Sub New(selectedAddon As EurekaCommonAddon, mode As OpenMode)
        InitializeComponent()
        Me.selectedAddon = selectedAddon
        Me.mode = mode

        If (mode = OpenMode.Edit) Then
            Dim subscriptions As New EurekaSubscriptions
            subscriptions.Query.Filters.Add(New Sage.ObjectStore.Filter(EurekaSubscription.FIELD_EUREKACOMMONADDONDBKEY, FilterOperator.Equal, selectedAddon.EurekaCommonAddon))

            For Each subscription As EurekaSubscription In subscriptions
                initialSubscriptions.Add(subscription)
            Next
        End If
    End Sub

    Private Sub Populate(selectedAddon As EurekaCommonAddon)
        NameTextBox.Text = selectedAddon.Name
        DescriptionTextBox.Text = selectedAddon.Description
        OneOffCostTextBox.Text = selectedAddon.OneOffCost
        MonthlyCostTextBox.Text = selectedAddon.MonthlyCost
        OneOffStandaloneCostTextBox.Text = selectedAddon.OneOffStandaloneCost
        MonthlyStandaloneCostTextBox.Text = selectedAddon.MonthlyStandaloneCost
    End Sub

    Private Function IsValid() As Boolean

        Dim constraints As Integer() = New Integer(4) {
            NameTextBox.Text.Any,
            IsNumeric(OneOffCostTextBox.Text),
            IsNumeric(MonthlyCostTextBox.Text),
            IsNumeric(OneOffStandaloneCostTextBox.Text),
            IsNumeric(MonthlyStandaloneCostTextBox.Text)
        }

        Return constraints.Aggregate(Function(valid, constraint) valid And constraint)
    End Function

    Private Sub CommonAddon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case mode
            Case OpenMode.Add
                Text = "Add Common Addon"
            Case OpenMode.Edit
                Text = $"Editing ""{selectedAddon.Name}"""
                Populate(selectedAddon)
                NameTextBox.Enabled = False
            Case OpenMode.View
                Text = $"Viewing ""{selectedAddon.Name}"""
                Populate(selectedAddon)
                AcceptButton = CancelButton
                NameTextBox.Enabled = False
                DescriptionTextBox.Enabled = False
                OneOffCostTextBox.Enabled = False
                MonthlyCostTextBox.Enabled = False
                OneOffStandaloneCostTextBox.Enabled = False
                MonthlyStandaloneCostTextBox.Enabled = False
        End Select
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        selectedAddon.Name = NameTextBox.Text
        ValidateFormData(sender, e)
    End Sub

    Private Sub ValidateFormData(sender As Object, e As EventArgs) Handles OneOffCostTextBox.TextChanged, MonthlyCostTextBox.TextChanged, OneOffStandaloneCostTextBox.TextChanged, MonthlyStandaloneCostTextBox.TextChanged
        'Enable saving only when the form data constitutes a valid addon
        SaveButton.Enabled = (mode <> OpenMode.View) And IsValid()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        selectedAddon.Description = DescriptionTextBox.Text
        selectedAddon.OneOffCost = OneOffCostTextBox.Text
        selectedAddon.MonthlyCost = MonthlyCostTextBox.Text
        selectedAddon.OneOffStandaloneCost = OneOffStandaloneCostTextBox.Text
        selectedAddon.MonthlyStandaloneCost = MonthlyStandaloneCostTextBox.Text
        selectedAddon.Update()
        Close()
    End Sub

    Private Sub SubscribersButton_Click(sender As Object, e As EventArgs) Handles SubscribersButton.Click
        Call New Subscribers(Me, selectedAddon, mode).ShowDialog()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Select Case mode
            Case OpenMode.Add
                Dim subscriptions As New EurekaSubscriptions
                subscriptions.Query.Filters.Add(New Sage.ObjectStore.Filter(EurekaSubscription.FIELD_EUREKACOMMONADDONDBKEY, FilterOperator.Equal, selectedAddon.EurekaCommonAddon))

                Dim i As Integer
                For i = 0 To subscriptions.Count - 1
                    subscriptions(i).Delete()
                Next

                selectedAddon.Delete()
            Case OpenMode.Edit
                If subscriptionsModified Then
                    If (New KeepChanges(changes).ShowDialog = MsgBoxResult.No) Then
                        Dim subscriptions As New EurekaSubscriptions
                        subscriptions.Query.Filters.Add(New Sage.ObjectStore.Filter(EurekaSubscription.FIELD_EUREKACOMMONADDONDBKEY, FilterOperator.Equal, selectedAddon.EurekaCommonAddon))

                        For i As Integer = 0 To subscriptions.Count - 1
                            subscriptions(0).Delete()
                        Next

                        For Each initialSubscription As EurekaSubscription In initialSubscriptions
                            Dim restoredSubscription As New EurekaSubscription With {
                                .Customer = initialSubscription.Customer,
                                .EurekaCommonAddon = initialSubscription.EurekaCommonAddon,
                                .EurekaBillingFrequency = initialSubscription.EurekaBillingFrequency,
                                .ExpiryDate = initialSubscription.ExpiryDate,
                                .CostPerBillingCycle = initialSubscription.CostPerBillingCycle
                            }

                            restoredSubscription.Update()
                        Next
                    End If
                End If
        End Select
    End Sub

    Private Sub FormatNumberTextBox(sender As Object, e As EventArgs) Handles OneOffCostTextBox.Validated, OneOffStandaloneCostTextBox.Validated, MonthlyStandaloneCostTextBox.Validated, MonthlyCostTextBox.Validated
        Dim textBox As NumberTextBox = CType(sender, NumberTextBox)

        If (IsNumeric(textBox.Text)) Then
            textBox.Text = String.Format("{0:F2}", Double.Parse(textBox.Text))
        Else
            textBox.Text = "0.00"
        End If
    End Sub
End Class