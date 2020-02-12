<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommonAddon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommonAddon))
        Me.NameLabel = New Sage.Common.Controls.Label()
        Me.NameTextBox = New Sage.ObjectStore.Controls.MaskedTextBox()
        Me.DescriptionTextBox = New Sage.ObjectStore.Controls.MaskedTextBox()
        Me.DescriptionLabel = New Sage.Common.Controls.Label()
        Me.OneOffCostLabel = New Sage.Common.Controls.Label()
        Me.OneOffCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.MonthlyCostLabel = New Sage.Common.Controls.Label()
        Me.MonthlyCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.OneOffStandaloneCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.OneOffStandaloneCostLabel = New Sage.Common.Controls.Label()
        Me.MonthlyStandaloneCostTextBox = New Sage.ObjectStore.Controls.NumberTextBox()
        Me.MonthlyStandaloneCostLabel = New Sage.Common.Controls.Label()
        Me.SaveButton = New Sage.Common.Controls.Button()
        Me.CloseButton = New Sage.Common.Controls.Button()
        Me.SubscribersButton = New Sage.Common.Controls.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.IgnoreTextFormatting = False
        Me.NameLabel.Location = New System.Drawing.Point(12, 12)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(72, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Addon Name:"
        Me.NameLabel.ToolTip = ""
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.NameTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NameTextBox.Location = New System.Drawing.Point(169, 12)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DescriptionTextBox.Location = New System.Drawing.Point(169, 38)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(180, 60)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.IgnoreTextFormatting = False
        Me.DescriptionLabel.Location = New System.Drawing.Point(12, 38)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(64, 13)
        Me.DescriptionLabel.TabIndex = 3
        Me.DescriptionLabel.Text = "Description:"
        Me.DescriptionLabel.ToolTip = ""
        '
        'OneOffCostLabel
        '
        Me.OneOffCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffCostLabel.IgnoreTextFormatting = False
        Me.OneOffCostLabel.Location = New System.Drawing.Point(12, 104)
        Me.OneOffCostLabel.Name = "OneOffCostLabel"
        Me.OneOffCostLabel.Size = New System.Drawing.Size(76, 13)
        Me.OneOffCostLabel.TabIndex = 6
        Me.OneOffCostLabel.Text = "One-Off Cost:"
        Me.OneOffCostLabel.ToolTip = ""
        '
        'OneOffCostTextBox
        '
        Me.OneOffCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.OneOffCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OneOffCostTextBox.Location = New System.Drawing.Point(169, 104)
        Me.OneOffCostTextBox.Name = "OneOffCostTextBox"
        Me.OneOffCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OneOffCostTextBox.TabIndex = 9
        Me.OneOffCostTextBox.Text = "0.00"
        '
        'MonthlyCostLabel
        '
        Me.MonthlyCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyCostLabel.IgnoreTextFormatting = False
        Me.MonthlyCostLabel.Location = New System.Drawing.Point(12, 130)
        Me.MonthlyCostLabel.Name = "MonthlyCostLabel"
        Me.MonthlyCostLabel.Size = New System.Drawing.Size(74, 13)
        Me.MonthlyCostLabel.TabIndex = 10
        Me.MonthlyCostLabel.Text = "Monthly Cost:"
        Me.MonthlyCostLabel.ToolTip = ""
        '
        'MonthlyCostTextBox
        '
        Me.MonthlyCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MonthlyCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthlyCostTextBox.Location = New System.Drawing.Point(169, 130)
        Me.MonthlyCostTextBox.Name = "MonthlyCostTextBox"
        Me.MonthlyCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MonthlyCostTextBox.TabIndex = 11
        Me.MonthlyCostTextBox.Text = "0.00"
        '
        'OneOffStandaloneCostTextBox
        '
        Me.OneOffStandaloneCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.OneOffStandaloneCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffStandaloneCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OneOffStandaloneCostTextBox.Location = New System.Drawing.Point(169, 156)
        Me.OneOffStandaloneCostTextBox.Name = "OneOffStandaloneCostTextBox"
        Me.OneOffStandaloneCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OneOffStandaloneCostTextBox.TabIndex = 14
        Me.OneOffStandaloneCostTextBox.Text = "0.00"
        '
        'OneOffStandaloneCostLabel
        '
        Me.OneOffStandaloneCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneOffStandaloneCostLabel.IgnoreTextFormatting = False
        Me.OneOffStandaloneCostLabel.Location = New System.Drawing.Point(12, 156)
        Me.OneOffStandaloneCostLabel.Name = "OneOffStandaloneCostLabel"
        Me.OneOffStandaloneCostLabel.Size = New System.Drawing.Size(141, 13)
        Me.OneOffStandaloneCostLabel.TabIndex = 13
        Me.OneOffStandaloneCostLabel.Text = "One-Off Cost (Standalone):"
        Me.OneOffStandaloneCostLabel.ToolTip = ""
        '
        'MonthlyStandaloneCostTextBox
        '
        Me.MonthlyStandaloneCostTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MonthlyStandaloneCostTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyStandaloneCostTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthlyStandaloneCostTextBox.Location = New System.Drawing.Point(169, 182)
        Me.MonthlyStandaloneCostTextBox.Name = "MonthlyStandaloneCostTextBox"
        Me.MonthlyStandaloneCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MonthlyStandaloneCostTextBox.TabIndex = 17
        Me.MonthlyStandaloneCostTextBox.Text = "0.00"
        '
        'MonthlyStandaloneCostLabel
        '
        Me.MonthlyStandaloneCostLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyStandaloneCostLabel.IgnoreTextFormatting = False
        Me.MonthlyStandaloneCostLabel.Location = New System.Drawing.Point(12, 182)
        Me.MonthlyStandaloneCostLabel.Name = "MonthlyStandaloneCostLabel"
        Me.MonthlyStandaloneCostLabel.Size = New System.Drawing.Size(139, 13)
        Me.MonthlyStandaloneCostLabel.TabIndex = 16
        Me.MonthlyStandaloneCostLabel.Text = "Monthly Cost (Standalone):"
        Me.MonthlyStandaloneCostLabel.ToolTip = ""
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(15, 231)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 28)
        Me.SaveButton.TabIndex = 18
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(274, 231)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 28)
        Me.CloseButton.TabIndex = 19
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SubscribersButton
        '
        Me.SubscribersButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubscribersButton.Location = New System.Drawing.Point(96, 231)
        Me.SubscribersButton.Name = "SubscribersButton"
        Me.SubscribersButton.Size = New System.Drawing.Size(124, 28)
        Me.SubscribersButton.TabIndex = 20
        Me.SubscribersButton.TabStop = False
        Me.SubscribersButton.Text = "Subscribers"
        Me.SubscribersButton.UseVisualStyleBackColor = True
        '
        'CommonAddon
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(361, 271)
        Me.Controls.Add(Me.SubscribersButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveButton)
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
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CommonAddon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Sage.Common.Controls.Label
    Friend WithEvents NameTextBox As Sage.ObjectStore.Controls.MaskedTextBox
    Friend WithEvents DescriptionTextBox As Sage.ObjectStore.Controls.MaskedTextBox
    Friend WithEvents DescriptionLabel As Sage.Common.Controls.Label
    Friend WithEvents OneOffCostLabel As Sage.Common.Controls.Label
    Friend WithEvents OneOffCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents MonthlyCostLabel As Sage.Common.Controls.Label
    Friend WithEvents MonthlyCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents OneOffStandaloneCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents OneOffStandaloneCostLabel As Sage.Common.Controls.Label
    Friend WithEvents MonthlyStandaloneCostTextBox As Sage.ObjectStore.Controls.NumberTextBox
    Friend WithEvents MonthlyStandaloneCostLabel As Sage.Common.Controls.Label
    Friend WithEvents SaveButton As Sage.Common.Controls.Button
    Friend Shadows WithEvents CloseButton As Sage.Common.Controls.Button
    Friend WithEvents SubscribersButton As Sage.Common.Controls.Button
End Class
