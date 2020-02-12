<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscription
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subscription))
        Me.CustomerNameTextBox = New Sage.ObjectStore.Controls.MaskedTextBox()
        Me.CustomerLookup = New Sage.MMS.Controls.CustomerAccRefLookup()
        Me.CloseButton = New Sage.Common.Controls.Button()
        Me.SaveButton = New Sage.Common.Controls.Button()
        Me.CostPerBillingCycleLabel = New Sage.Common.Controls.Label()
        Me.ExpiryDateLabel = New Sage.Common.Controls.Label()
        Me.BillingFrequencyLabel = New Sage.Common.Controls.Label()
        Me.CustomerLabel = New Sage.Common.Controls.Label()
        Me.CostPerBillingCycleTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.BillingFrequencyLookup = New Sage.ObjectStore.Controls.ComboBox()
        Me.ExpiryDatePicker = New Sage.ObjectStore.Controls.DatePicker()
        Me.MonthlyStandaloneCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.MonthlyStandaloneCostLabel = New Sage.Common.Controls.Label()
        Me.OneOffStandaloneCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.OneOffStandaloneCostLabel = New Sage.Common.Controls.Label()
        Me.MonthlyCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.MonthlyCostLabel = New Sage.Common.Controls.Label()
        Me.OneOffCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.OneOffCostLabel = New Sage.Common.Controls.Label()
        Me.DescriptionLabel = New Sage.Common.Controls.Label()
        Me.DescriptionTextBox = New Sage.ObjectStore.Controls.MaskedTextBox()
        Me.NameLabel = New Sage.Common.Controls.Label()
        Me.CommonAddonLookup = New Sage.ObjectStore.Controls.ComboBox()
        CType(Me.CustomerLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerNameTextBox.Enabled = False
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(298, 13)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.CustomerNameTextBox.TabIndex = 34
        '
        'CustomerLookup
        '
        Me.CustomerLookup.AllowSinglePartialMatch = True
        Me.CustomerLookup.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerLookup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CustomerLookup.DisplayHiddenCustomers = False
        Me.CustomerLookup.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLookup.Location = New System.Drawing.Point(169, 13)
        Me.CustomerLookup.MaxLength = 32767
        Me.CustomerLookup.Name = "CustomerLookup"
        Me.CustomerLookup.Size = New System.Drawing.Size(122, 20)
        Me.CustomerLookup.TabIndex = 24
        Me.CustomerLookup.Tooltip = ""
        Me.CustomerLookup.Value = Nothing
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(381, 331)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 28)
        Me.CloseButton.TabIndex = 33
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(12, 331)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 28)
        Me.SaveButton.TabIndex = 32
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CostPerBillingCycleLabel
        '
        Me.CostPerBillingCycleLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostPerBillingCycleLabel.IgnoreTextFormatting = False
        Me.CostPerBillingCycleLabel.Location = New System.Drawing.Point(9, 289)
        Me.CostPerBillingCycleLabel.Name = "CostPerBillingCycleLabel"
        Me.CostPerBillingCycleLabel.Size = New System.Drawing.Size(110, 13)
        Me.CostPerBillingCycleLabel.TabIndex = 31
        Me.CostPerBillingCycleLabel.Text = "Cost per Billing Cycle:"
        Me.CostPerBillingCycleLabel.ToolTip = ""
        '
        'ExpiryDateLabel
        '
        Me.ExpiryDateLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDateLabel.IgnoreTextFormatting = False
        Me.ExpiryDateLabel.Location = New System.Drawing.Point(9, 263)
        Me.ExpiryDateLabel.Name = "ExpiryDateLabel"
        Me.ExpiryDateLabel.Size = New System.Drawing.Size(67, 13)
        Me.ExpiryDateLabel.TabIndex = 30
        Me.ExpiryDateLabel.Text = "Expiry Date:"
        Me.ExpiryDateLabel.ToolTip = ""
        '
        'BillingFrequencyLabel
        '
        Me.BillingFrequencyLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingFrequencyLabel.IgnoreTextFormatting = False
        Me.BillingFrequencyLabel.Location = New System.Drawing.Point(9, 236)
        Me.BillingFrequencyLabel.Name = "BillingFrequencyLabel"
        Me.BillingFrequencyLabel.Size = New System.Drawing.Size(91, 13)
        Me.BillingFrequencyLabel.TabIndex = 29
        Me.BillingFrequencyLabel.Text = "Billing Frequency:"
        Me.BillingFrequencyLabel.ToolTip = ""
        '
        'CustomerLabel
        '
        Me.CustomerLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLabel.IgnoreTextFormatting = False
        Me.CustomerLabel.Location = New System.Drawing.Point(9, 13)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(57, 13)
        Me.CustomerLabel.TabIndex = 28
        Me.CustomerLabel.Text = "Customer:"
        Me.CustomerLabel.ToolTip = ""
        '
        'CostPerBillingCycleTextBox
        '
        Me.CostPerBillingCycleTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CostPerBillingCycleTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostPerBillingCycleTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CostPerBillingCycleTextBox.Location = New System.Drawing.Point(169, 289)
        Me.CostPerBillingCycleTextBox.Name = "CostPerBillingCycleTextBox"
        Me.CostPerBillingCycleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostPerBillingCycleTextBox.TabIndex = 27
        Me.CostPerBillingCycleTextBox.Text = "0.00"
        '
        'BillingFrequencyLookup
        '
        Me.BillingFrequencyLookup.FormattingEnabled = True
        Me.BillingFrequencyLookup.Location = New System.Drawing.Point(169, 236)
        Me.BillingFrequencyLookup.Name = "BillingFrequencyLookup"
        Me.BillingFrequencyLookup.QuickSearch = True
        Me.BillingFrequencyLookup.Size = New System.Drawing.Size(155, 21)
        Me.BillingFrequencyLookup.TabIndex = 26
        Me.BillingFrequencyLookup.ToolTip = ""
        '
        'ExpiryDatePicker
        '
        Me.ExpiryDatePicker.BackColor = System.Drawing.SystemColors.Window
        Me.ExpiryDatePicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExpiryDatePicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ExpiryDatePicker.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ExpiryDatePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDatePicker.Location = New System.Drawing.Point(169, 263)
        Me.ExpiryDatePicker.MaxLength = 10
        Me.ExpiryDatePicker.Name = "ExpiryDatePicker"
        Me.ExpiryDatePicker.Size = New System.Drawing.Size(100, 20)
        Me.ExpiryDatePicker.TabIndex = 25
        Me.ExpiryDatePicker.Tooltip = ""
        Me.ExpiryDatePicker.Value = New Date(CType(0, Long))
        '
        'MonthlyStandaloneCostTextBox
        '
        Me.MonthlyStandaloneCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MonthlyStandaloneCostTextBox.Enabled = False
        Me.MonthlyStandaloneCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyStandaloneCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthlyStandaloneCostTextBox.Location = New System.Drawing.Point(169, 210)
        Me.MonthlyStandaloneCostTextBox.Name = "MonthlyStandaloneCostTextBox"
        Me.MonthlyStandaloneCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MonthlyStandaloneCostTextBox.TabIndex = 46
        Me.MonthlyStandaloneCostTextBox.Text = "0.00"
        '
        'MonthlyStandaloneCostLabel
        '
        Me.MonthlyStandaloneCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyStandaloneCostLabel.IgnoreTextFormatting = False
        Me.MonthlyStandaloneCostLabel.Location = New System.Drawing.Point(9, 210)
        Me.MonthlyStandaloneCostLabel.Name = "MonthlyStandaloneCostLabel"
        Me.MonthlyStandaloneCostLabel.Size = New System.Drawing.Size(139, 13)
        Me.MonthlyStandaloneCostLabel.TabIndex = 45
        Me.MonthlyStandaloneCostLabel.Text = "Monthly Cost (Standalone):"
        Me.MonthlyStandaloneCostLabel.ToolTip = ""
        '
        'OneOffStandaloneCostTextBox
        '
        Me.OneOffStandaloneCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.OneOffStandaloneCostTextBox.Enabled = False
        Me.OneOffStandaloneCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffStandaloneCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OneOffStandaloneCostTextBox.Location = New System.Drawing.Point(169, 184)
        Me.OneOffStandaloneCostTextBox.Name = "OneOffStandaloneCostTextBox"
        Me.OneOffStandaloneCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OneOffStandaloneCostTextBox.TabIndex = 44
        Me.OneOffStandaloneCostTextBox.Text = "0.00"
        '
        'OneOffStandaloneCostLabel
        '
        Me.OneOffStandaloneCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffStandaloneCostLabel.IgnoreTextFormatting = False
        Me.OneOffStandaloneCostLabel.Location = New System.Drawing.Point(9, 184)
        Me.OneOffStandaloneCostLabel.Name = "OneOffStandaloneCostLabel"
        Me.OneOffStandaloneCostLabel.Size = New System.Drawing.Size(141, 13)
        Me.OneOffStandaloneCostLabel.TabIndex = 43
        Me.OneOffStandaloneCostLabel.Text = "One-Off Cost (Standalone):"
        Me.OneOffStandaloneCostLabel.ToolTip = ""
        '
        'MonthlyCostTextBox
        '
        Me.MonthlyCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MonthlyCostTextBox.Enabled = False
        Me.MonthlyCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthlyCostTextBox.Location = New System.Drawing.Point(169, 158)
        Me.MonthlyCostTextBox.Name = "MonthlyCostTextBox"
        Me.MonthlyCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MonthlyCostTextBox.TabIndex = 42
        Me.MonthlyCostTextBox.Text = "0.00"
        '
        'MonthlyCostLabel
        '
        Me.MonthlyCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyCostLabel.IgnoreTextFormatting = False
        Me.MonthlyCostLabel.Location = New System.Drawing.Point(9, 158)
        Me.MonthlyCostLabel.Name = "MonthlyCostLabel"
        Me.MonthlyCostLabel.Size = New System.Drawing.Size(74, 13)
        Me.MonthlyCostLabel.TabIndex = 41
        Me.MonthlyCostLabel.Text = "Monthly Cost:"
        Me.MonthlyCostLabel.ToolTip = ""
        '
        'OneOffCostTextBox
        '
        Me.OneOffCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.OneOffCostTextBox.Enabled = False
        Me.OneOffCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OneOffCostTextBox.Location = New System.Drawing.Point(169, 132)
        Me.OneOffCostTextBox.Name = "OneOffCostTextBox"
        Me.OneOffCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OneOffCostTextBox.TabIndex = 40
        Me.OneOffCostTextBox.Text = "0.00"
        '
        'OneOffCostLabel
        '
        Me.OneOffCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffCostLabel.IgnoreTextFormatting = False
        Me.OneOffCostLabel.Location = New System.Drawing.Point(9, 132)
        Me.OneOffCostLabel.Name = "OneOffCostLabel"
        Me.OneOffCostLabel.Size = New System.Drawing.Size(76, 13)
        Me.OneOffCostLabel.TabIndex = 39
        Me.OneOffCostLabel.Text = "One-Off Cost:"
        Me.OneOffCostLabel.ToolTip = ""
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.IgnoreTextFormatting = False
        Me.DescriptionLabel.Location = New System.Drawing.Point(9, 66)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(64, 13)
        Me.DescriptionLabel.TabIndex = 38
        Me.DescriptionLabel.Text = "Description:"
        Me.DescriptionLabel.ToolTip = ""
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DescriptionTextBox.Enabled = False
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DescriptionTextBox.Location = New System.Drawing.Point(169, 66)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(287, 60)
        Me.DescriptionTextBox.TabIndex = 37
        '
        'NameLabel
        '
        Me.NameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.IgnoreTextFormatting = False
        Me.NameLabel.Location = New System.Drawing.Point(9, 39)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(42, 13)
        Me.NameLabel.TabIndex = 35
        Me.NameLabel.Text = "Addon:"
        Me.NameLabel.ToolTip = ""
        '
        'CommonAddonLookup
        '
        Me.CommonAddonLookup.FormattingEnabled = True
        Me.CommonAddonLookup.Location = New System.Drawing.Point(169, 39)
        Me.CommonAddonLookup.Name = "CommonAddonLookup"
        Me.CommonAddonLookup.QuickSearch = True
        Me.CommonAddonLookup.Size = New System.Drawing.Size(155, 21)
        Me.CommonAddonLookup.TabIndex = 47
        Me.CommonAddonLookup.ToolTip = ""
        '
        'Subscription
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(469, 371)
        Me.Controls.Add(Me.CommonAddonLookup)
        Me.Controls.Add(Me.MonthlyStandaloneCostTextBox)
        Me.Controls.Add(Me.MonthlyStandaloneCostLabel)
        Me.Controls.Add(Me.OneOffStandaloneCostTextBox)
        Me.Controls.Add(Me.OneOffStandaloneCostLabel)
        Me.Controls.Add(Me.MonthlyCostTextBox)
        Me.Controls.Add(Me.MonthlyCostLabel)
        Me.Controls.Add(Me.OneOffCostTextBox)
        Me.Controls.Add(Me.OneOffCostLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.CustomerLookup)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CostPerBillingCycleLabel)
        Me.Controls.Add(Me.ExpiryDateLabel)
        Me.Controls.Add(Me.BillingFrequencyLabel)
        Me.Controls.Add(Me.CustomerLabel)
        Me.Controls.Add(Me.CostPerBillingCycleTextBox)
        Me.Controls.Add(Me.BillingFrequencyLookup)
        Me.Controls.Add(Me.ExpiryDatePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Subscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.CustomerLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameTextBox As Sage.ObjectStore.Controls.MaskedTextBox
    Friend WithEvents CustomerLookup As Sage.MMS.Controls.CustomerAccRefLookup
    Friend WithEvents CloseButton As Sage.Common.Controls.Button
    Friend WithEvents SaveButton As Sage.Common.Controls.Button
    Friend WithEvents CostPerBillingCycleLabel As Sage.Common.Controls.Label
    Friend WithEvents ExpiryDateLabel As Sage.Common.Controls.Label
    Friend WithEvents BillingFrequencyLabel As Sage.Common.Controls.Label
    Friend WithEvents CustomerLabel As Sage.Common.Controls.Label
    Friend WithEvents CostPerBillingCycleTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents BillingFrequencyLookup As Sage.ObjectStore.Controls.ComboBox
    Friend WithEvents ExpiryDatePicker As Sage.ObjectStore.Controls.DatePicker
    Friend WithEvents MonthlyStandaloneCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents MonthlyStandaloneCostLabel As Sage.Common.Controls.Label
    Friend WithEvents OneOffStandaloneCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents OneOffStandaloneCostLabel As Sage.Common.Controls.Label
    Friend WithEvents MonthlyCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents MonthlyCostLabel As Sage.Common.Controls.Label
    Friend WithEvents OneOffCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents OneOffCostLabel As Sage.Common.Controls.Label
    Friend WithEvents DescriptionLabel As Sage.Common.Controls.Label
    Friend WithEvents DescriptionTextBox As Sage.ObjectStore.Controls.MaskedTextBox
    Friend WithEvents NameLabel As Sage.Common.Controls.Label
    Friend WithEvents CommonAddonLookup As Sage.ObjectStore.Controls.ComboBox
End Class
