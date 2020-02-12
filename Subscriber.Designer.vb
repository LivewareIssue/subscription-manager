<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscriber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subscriber))
        Me.CustomerLookup_NameColumn = New Sage.ObjectStore.Controls.ListColumn()
        Me.ExpiryDatePicker = New Sage.ObjectStore.Controls.DatePicker()
        Me.BillingFrequencyLookup = New Sage.ObjectStore.Controls.ComboBox()
        Me.CostPerBillingCycleTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.CostPerBillingCycleLabel = New Sage.Common.Controls.Label()
        Me.ExpiryDateLabel = New Sage.Common.Controls.Label()
        Me.BillingFrequencyLabel = New Sage.Common.Controls.Label()
        Me.CustomerLabel = New Sage.Common.Controls.Label()
        Me.CloseButton = New Sage.Common.Controls.Button()
        Me.SaveButton = New Sage.Common.Controls.Button()
        Me.CustomerLookup = New Sage.MMS.Controls.CustomerAccRefLookup()
        Me.CustomerNameTextBox = New Sage.ObjectStore.Controls.MaskedTextBox()
        CType(Me.CustomerLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerLookup_NameColumn
        '
        Me.CustomerLookup_NameColumn.Caption = " "
        Me.CustomerLookup_NameColumn.IgnoreTotalTheming = False
        Me.CustomerLookup_NameColumn.SavedMementoName = " "
        Me.CustomerLookup_NameColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CustomerLookup_NameColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ExpiryDatePicker
        '
        Me.ExpiryDatePicker.BackColor = System.Drawing.SystemColors.Window
        Me.ExpiryDatePicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExpiryDatePicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ExpiryDatePicker.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ExpiryDatePicker.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDatePicker.Location = New System.Drawing.Point(145, 65)
        Me.ExpiryDatePicker.MaxLength = 10
        Me.ExpiryDatePicker.Name = "ExpiryDatePicker"
        Me.ExpiryDatePicker.Size = New System.Drawing.Size(100, 20)
        Me.ExpiryDatePicker.TabIndex = 3
        Me.ExpiryDatePicker.Tooltip = ""
        Me.ExpiryDatePicker.Value = New Date(CType(0, Long))
        '
        'BillingFrequencyLookup
        '
        Me.BillingFrequencyLookup.FormattingEnabled = True
        Me.BillingFrequencyLookup.Location = New System.Drawing.Point(145, 38)
        Me.BillingFrequencyLookup.Name = "BillingFrequencyLookup"
        Me.BillingFrequencyLookup.QuickSearch = True
        Me.BillingFrequencyLookup.Size = New System.Drawing.Size(155, 21)
        Me.BillingFrequencyLookup.TabIndex = 4
        Me.BillingFrequencyLookup.ToolTip = ""
        '
        'CostPerBillingCycleTextBox
        '
        Me.CostPerBillingCycleTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CostPerBillingCycleTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostPerBillingCycleTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CostPerBillingCycleTextBox.Location = New System.Drawing.Point(145, 91)
        Me.CostPerBillingCycleTextBox.Name = "CostPerBillingCycleTextBox"
        Me.CostPerBillingCycleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostPerBillingCycleTextBox.TabIndex = 10
        Me.CostPerBillingCycleTextBox.Text = "0.00"
        '
        'CostPerBillingCycleLabel
        '
        Me.CostPerBillingCycleLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostPerBillingCycleLabel.IgnoreTextFormatting = False
        Me.CostPerBillingCycleLabel.Location = New System.Drawing.Point(12, 98)
        Me.CostPerBillingCycleLabel.Name = "CostPerBillingCycleLabel"
        Me.CostPerBillingCycleLabel.Size = New System.Drawing.Size(110, 13)
        Me.CostPerBillingCycleLabel.TabIndex = 14
        Me.CostPerBillingCycleLabel.Text = "Cost per Billing Cycle:"
        Me.CostPerBillingCycleLabel.ToolTip = ""
        '
        'ExpiryDateLabel
        '
        Me.ExpiryDateLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDateLabel.IgnoreTextFormatting = False
        Me.ExpiryDateLabel.Location = New System.Drawing.Point(12, 72)
        Me.ExpiryDateLabel.Name = "ExpiryDateLabel"
        Me.ExpiryDateLabel.Size = New System.Drawing.Size(67, 13)
        Me.ExpiryDateLabel.TabIndex = 13
        Me.ExpiryDateLabel.Text = "Expiry Date:"
        Me.ExpiryDateLabel.ToolTip = ""
        '
        'BillingFrequencyLabel
        '
        Me.BillingFrequencyLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingFrequencyLabel.IgnoreTextFormatting = False
        Me.BillingFrequencyLabel.Location = New System.Drawing.Point(12, 46)
        Me.BillingFrequencyLabel.Name = "BillingFrequencyLabel"
        Me.BillingFrequencyLabel.Size = New System.Drawing.Size(91, 13)
        Me.BillingFrequencyLabel.TabIndex = 12
        Me.BillingFrequencyLabel.Text = "Billing Frequency:"
        Me.BillingFrequencyLabel.ToolTip = ""
        '
        'CustomerLabel
        '
        Me.CustomerLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLabel.IgnoreTextFormatting = False
        Me.CustomerLabel.Location = New System.Drawing.Point(12, 19)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(57, 13)
        Me.CustomerLabel.TabIndex = 11
        Me.CustomerLabel.Text = "Customer:"
        Me.CustomerLabel.ToolTip = ""
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(357, 144)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 28)
        Me.CloseButton.TabIndex = 21
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(12, 144)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 28)
        Me.SaveButton.TabIndex = 20
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CustomerLookup
        '
        Me.CustomerLookup.AllowSinglePartialMatch = True
        Me.CustomerLookup.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerLookup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CustomerLookup.DisplayHiddenCustomers = False
        Me.CustomerLookup.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLookup.Location = New System.Drawing.Point(145, 12)
        Me.CustomerLookup.MaxLength = 32767
        Me.CustomerLookup.Name = "CustomerLookup"
        Me.CustomerLookup.Size = New System.Drawing.Size(122, 20)
        Me.CustomerLookup.TabIndex = 3
        Me.CustomerLookup.Tooltip = ""
        Me.CustomerLookup.Value = Nothing
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerNameTextBox.Enabled = False
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(274, 12)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.CustomerNameTextBox.TabIndex = 23
        '
        'Subscriber
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(444, 184)
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
        Me.Name = "Subscriber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.CustomerLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExpiryDatePicker As Sage.ObjectStore.Controls.DatePicker
    Friend WithEvents BillingFrequencyLookup As Sage.ObjectStore.Controls.ComboBox
    Friend WithEvents CostPerBillingCycleTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents CostPerBillingCycleLabel As Sage.Common.Controls.Label
    Friend WithEvents ExpiryDateLabel As Sage.Common.Controls.Label
    Friend WithEvents BillingFrequencyLabel As Sage.Common.Controls.Label
    Friend WithEvents CustomerLabel As Sage.Common.Controls.Label
    Friend WithEvents CloseButton As Sage.Common.Controls.Button
    Friend WithEvents SaveButton As Sage.Common.Controls.Button
    Friend WithEvents CustomerLookup_NameColumn As Sage.ObjectStore.Controls.ListColumn
    Friend WithEvents CustomerLookup As Sage.MMS.Controls.CustomerAccRefLookup
    Friend WithEvents CustomerNameTextBox As Sage.ObjectStore.Controls.MaskedTextBox
End Class
