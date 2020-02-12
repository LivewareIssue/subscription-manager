Imports System.Collections.Generic
Imports System.Linq
Imports Eureka.Common.Addons.Eureka.Common.Addons
Imports Sage.Accounting
Imports Sage.ObjectStore.Controls

Public Class Subscriber

    Private mode As OpenMode
    Private selectedAddon As EurekaCommonAddon
    Private selectedSubscription As EurekaSubscription
    Private parentWindow As CommonAddon

    Public Sub New(parentWindow As CommonAddon, selectedAddon As EurekaCommonAddon)
        InitializeComponent()
        Me.parentWindow = parentWindow
        Me.selectedAddon = selectedAddon
        selectedSubscription = New EurekaSubscription
        mode = OpenMode.Add
    End Sub

    Public Sub New(parentWindow As CommonAddon, selectedAddon As EurekaCommonAddon, selectedSubscription As EurekaSubscription, mode As OpenMode)
        InitializeComponent()
        Me.parentWindow = parentWindow
        Me.selectedAddon = selectedAddon
        Me.selectedSubscription = selectedSubscription
        Me.mode = mode
    End Sub

    Private Sub Populate(selectedSubscription As EurekaSubscription)
        CustomerLookup.Customer = selectedSubscription.Customer
        BillingFrequencyLookup.SelectedValue = selectedSubscription.EurekaBillingFrequencyDbKey
        ExpiryDatePicker.Value = selectedSubscription.ExpiryDate
        CostPerBillingCycleTextBox.Text = selectedSubscription.CostPerBillingCycle
    End Sub

    Private Function IsValid() As Boolean
        Dim constraints As Integer() = New Integer(5) {
            CustomerLookup.Customer.SLCustomerAccount <> 0,
            Not IsNothing(BillingFrequencyLookup.SelectedItem),
            Not ExpiryDatePicker.IsEmpty,
            Not ExpiryDatePicker.IsBlankDate,
            ExpiryDatePicker.IsValidDate,
            IsNumeric(CostPerBillingCycleTextBox.Text)
        }

        Return constraints.Aggregate(Function(valid, constraint) valid And constraint)
    End Function

    Private Sub Subscriber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the billing-frequency combo-box
        BillingFrequencyLookup.DataSource = New EurekaBillingFrequencies()
        BillingFrequencyLookup.DisplayMember = "Name"
        BillingFrequencyLookup.ValueMember = "EurekaBillingFrequency"

        'If no addon is selected, display its name as 'New Addon'
        Dim addonDisplayName As String
        If selectedAddon.Name = "" Then
            addonDisplayName = "New Addon"
        Else
            addonDisplayName = $"""{selectedAddon.Name}"""
        End If

        Select Case mode
            Case OpenMode.Add
                Text = $"Add Subscriber to {addonDisplayName}"
                BillingFrequencyLookup.SelectedValue = 2
            Case OpenMode.Edit
                Text = $"Editing Subscription of ""{selectedSubscription.Customer.Name}"" to ""{addonDisplayName}"""
                Populate(selectedSubscription)
                CustomerLookup.Enabled = False
            Case OpenMode.View
                Text = $"Viewing Subscription of ""{selectedSubscription.Customer.Name}"" to ""{addonDisplayName}"""
                Populate(selectedSubscription)
                AcceptButton = CancelButton
                CustomerLookup.Enabled = False
                BillingFrequencyLookup.Enabled = False
                ExpiryDatePicker.Enabled = False
                CostPerBillingCycleTextBox.Enabled = False
        End Select
    End Sub

    Private Sub ValidateFormData(sender As Object, e As EventArgs) Handles BillingFrequencyLookup.ValueMemberChanged, ExpiryDatePicker.ValueChanged, CostPerBillingCycleTextBox.TextChanged
        'Enable saving only when the form data constitutes a valid subscriber
        SaveButton.Enabled = (mode <> OpenMode.View) And IsValid()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Select Case mode
            Case OpenMode.Add
                parentWindow.changes.Add($"Subscribed ""{CustomerLookup.Customer.Name}""")
                parentWindow.subscriptionsModified = True

            Case OpenMode.Edit
                Dim deltas As New Dictionary(Of Object, Object) From {
                    {selectedSubscription.EurekaCommonAddonDbKey, selectedAddon.EurekaCommonAddon},
                    {selectedSubscription.CustomerDbKey, CustomerLookup.Customer.SLCustomerAccount},
                    {selectedSubscription.EurekaBillingFrequencyDbKey, BillingFrequencyLookup.SelectedValue},
                    {selectedSubscription.ExpiryDate, ExpiryDatePicker.Value},
                    {selectedSubscription.CostPerBillingCycle, Decimal.Parse(CostPerBillingCycleTextBox.Text)}
                }

                Dim saveRequired As Boolean = deltas.Aggregate(False, Function(dirty, delta) dirty Or (Not delta.Key.Equals(delta.Value)))

                If saveRequired Then
                    parentWindow.changes.Add($"Modified ""{selectedSubscription.Customer.Name}""'s subscription")
                    parentWindow.subscriptionsModified = True
                End If
        End Select

        selectedSubscription.EurekaCommonAddon = selectedAddon
        selectedSubscription.Customer = CustomerLookup.Customer
        selectedSubscription.EurekaBillingFrequency = BillingFrequencyLookup.SelectedItem
        selectedSubscription.ExpiryDate = ExpiryDatePicker.Value
        selectedSubscription.CostPerBillingCycle = CostPerBillingCycleTextBox.Text
        selectedSubscription.SignAndUpdate

        Close()
    End Sub

    Private Sub CustomerLookup_CustomerAccRefSelected(sender As Object, args As Sage.MMS.Controls.CustomerAccRefLookupItemSelectedEventArgs) Handles CustomerLookup.CustomerAccRefSelected
        Select Case CustomerLookup.Customer.SLCustomerAccount
            Case 0
                CustomerNameTextBox.Text = ""
            Case Else
                CustomerNameTextBox.Text = CustomerLookup.Customer.Name
        End Select

        ValidateFormData(sender, args)
    End Sub

    Private Sub FormatNumberTextBox(sender As Object, e As EventArgs) Handles CostPerBillingCycleTextBox.Validated
        Dim textBox As NumberTextBox = CType(sender, NumberTextBox)

        If (IsNumeric(textBox.Text)) Then
            textBox.Text = String.Format("{0:F2}", Double.Parse(textBox.Text))
        Else
            textBox.Text = "0.00"
        End If
    End Sub
End Class