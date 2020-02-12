Imports System.Linq
Imports Eureka.Common.Addons.Eureka.Common.Addons
Imports Sage.Accounting.SalesLedger
Imports Sage.Common.Data
Imports Sage.ObjectStore.Controls

Public Class Subscription
    Private selectedCustomer As Customer
    Private selectedSubscription As EurekaSubscription
    Private mode As OpenMode

    Public Sub New()
        InitializeComponent()
        mode = OpenMode.Add
    End Sub

    Public Sub New(selectedCustomer As Customer, mode As OpenMode)
        InitializeComponent()
        Me.selectedCustomer = selectedCustomer
        Me.mode = mode
    End Sub

    Public Sub New(selectedSubscription As EurekaSubscription, mode As OpenMode)
        InitializeComponent()
        selectedCustomer = selectedSubscription.Customer
        Me.selectedSubscription = selectedSubscription
        Me.mode = mode
    End Sub

    Private Sub Populate(selectedSubscription As EurekaSubscription)
        CustomerLookup.Customer = selectedSubscription.Customer
        CommonAddonLookup.SelectedItem = selectedSubscription.EurekaCommonAddon
        DescriptionTextBox.Text = selectedSubscription.EurekaCommonAddon.Description
        OneOffCostTextBox.Text = selectedSubscription.EurekaCommonAddon.OneOffCost
        MonthlyCostTextBox.Text = selectedSubscription.EurekaCommonAddon.MonthlyCost
        OneOffStandaloneCostTextBox.Text = selectedSubscription.EurekaCommonAddon.OneOffStandaloneCost
        MonthlyStandaloneCostTextBox.Text = selectedSubscription.EurekaCommonAddon.MonthlyStandaloneCost
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

    Private Sub Subscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the billing-frequency combo-box
        BillingFrequencyLookup.DataSource = New EurekaBillingFrequencies()
        BillingFrequencyLookup.DisplayMember = "Name"
        BillingFrequencyLookup.ValueMember = "EurekaBillingFrequency"

        'Populate the common-addon combo-box
        CommonAddonLookup.DataSource = New EurekaCommonAddons()
        CommonAddonLookup.DisplayMember = "Name"
        CommonAddonLookup.ValueMember = "EurekaCommonAddon"

        Select Case mode
            Case OpenMode.Add
                BillingFrequencyLookup.SelectedValue = 2
                If Not IsNothing(selectedCustomer) Then
                    Text = $"Add Subscription to {selectedCustomer.Name}"
                    CustomerLookup.Enabled = False
                    CustomerLookup.Customer = selectedCustomer
                    CustomerNameTextBox.Text = selectedCustomer.Name
                Else
                    Text = "Add New Subscription"
                End If
            Case OpenMode.Edit
                Text = $"Editing Subscription of ""{selectedSubscription.Customer.Name}"" to ""{selectedSubscription.EurekaCommonAddon.Name}"""
                CustomerLookup.Enabled = False
                CommonAddonLookup.Enabled = False
                Populate(selectedSubscription)
            Case OpenMode.View
                Text = $"Viewing Subscription of ""{selectedSubscription.Customer.Name}"" to ""{selectedSubscription.EurekaCommonAddon.Name}"""
                CustomerLookup.Enabled = False
                CommonAddonLookup.Enabled = False
                BillingFrequencyLookup.Enabled = False
                ExpiryDatePicker.Enabled = False
                CostPerBillingCycleTextBox.Enabled = False
                Populate(selectedSubscription)
        End Select
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

    Private Sub CommonAddonLookup_ValueMemberChanged(sender As Object, e As EventArgs) Handles CommonAddonLookup.TextChanged
        Dim selectedAddon As EurekaCommonAddon = CType(CommonAddonLookup.SelectedItem, EurekaCommonAddon)

        DescriptionTextBox.Text = selectedAddon.Description
        OneOffCostTextBox.Text = selectedAddon.OneOffCost
        MonthlyCostTextBox.Text = selectedAddon.MonthlyCost
        OneOffStandaloneCostTextBox.Text = selectedAddon.OneOffStandaloneCost
        MonthlyStandaloneCostTextBox.Text = selectedAddon.MonthlyStandaloneCost

        ValidateFormData(sender, e)
    End Sub

    Private Sub ValidateFormData(sender As Object, e As EventArgs) Handles BillingFrequencyLookup.TextChanged, ExpiryDatePicker.TextChanged, CostPerBillingCycleTextBox.TextChanged
        SaveButton.Enabled = (mode <> OpenMode.View) And IsValid()
    End Sub

    Private Sub FormatNumberTextBox(sender As Object, e As EventArgs) Handles CostPerBillingCycleTextBox.Validated
        Dim textBox As NumberTextBox = CType(sender, NumberTextBox)

        If (IsNumeric(textBox.Text)) Then
            textBox.Text = String.Format("{0:F2}", Double.Parse(textBox.Text))
        Else
            textBox.Text = "0.00"
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If mode = OpenMode.Add Then
            selectedSubscription = New EurekaSubscription
        End If

        selectedSubscription.Customer = CustomerLookup.Customer
        selectedSubscription.EurekaCommonAddon = CommonAddonLookup.SelectedItem
        selectedSubscription.EurekaBillingFrequency = BillingFrequencyLookup.SelectedItem
        selectedSubscription.ExpiryDate = ExpiryDatePicker.Value
        selectedSubscription.CostPerBillingCycle = CostPerBillingCycleTextBox.Text
        selectedSubscription.SignAndUpdate()

        Close()
    End Sub
End Class