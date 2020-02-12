<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscriptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subscriptions))
        Me.SubscriptionsGrid = New Sage.ObjectStore.Controls.Grid()
        Me.CompanyNameColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.AddonNameColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.DescriptionColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.OneOffCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.MonthlyCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.OneOffStandaloneCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.MonthlyStandaloneCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.BillingFrequencyColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.ExpiryDateColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.CostPerBillingCycleColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.ViewButton = New Sage.Common.Controls.Button()
        Me.CloseButton = New Sage.Common.Controls.Button()
        Me.RemoveButton = New Sage.Common.Controls.Button()
        Me.EditButton = New Sage.Common.Controls.Button()
        Me.AddButton = New Sage.Common.Controls.Button()
        CType(Me.SubscriptionsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubscriptionsGrid
        '
        Me.SubscriptionsGrid.AllowMultiSelect = Sage.Common.Controls.MultiSelect.Standard
        Me.SubscriptionsGrid.AllowSort = True
        Me.SubscriptionsGrid.AllowTabNavigation = True
        Me.SubscriptionsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubscriptionsGrid.BackColor = System.Drawing.SystemColors.Window
        Me.SubscriptionsGrid.CardWidth = 1240
        Me.SubscriptionsGrid.CheckedDisplayMember = Nothing
        Me.SubscriptionsGrid.ChildMember = Nothing
        Me.SubscriptionsGrid.Columns.AddRange(New Sage.ObjectStore.Controls.GridColumn() {Me.CompanyNameColumn, Me.AddonNameColumn, Me.DescriptionColumn, Me.OneOffCostColumn, Me.MonthlyCostColumn, Me.OneOffStandaloneCostColumn, Me.MonthlyStandaloneCostColumn, Me.BillingFrequencyColumn, Me.ExpiryDateColumn, Me.CostPerBillingCycleColumn})
        Me.SubscriptionsGrid.CustomContextMenu = Nothing
        Me.SubscriptionsGrid.FaintHighlightColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SubscriptionsGrid.FixedSize = True
        Me.SubscriptionsGrid.GroupMember = Nothing
        Me.SubscriptionsGrid.IsEmptyOnAnySubItem = False
        Me.SubscriptionsGrid.ListPresenter = Nothing
        Me.SubscriptionsGrid.Location = New System.Drawing.Point(12, 12)
        Me.SubscriptionsGrid.Name = "SubscriptionsGrid"
        Me.SubscriptionsGrid.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SubscriptionsGrid.SelectedForeColor = System.Drawing.Color.Black
        Me.SubscriptionsGrid.ShowContextMenuAdvancedOptions = False
        Me.SubscriptionsGrid.ShowExtendedScrollBar = False
        Me.SubscriptionsGrid.Size = New System.Drawing.Size(1240, 376)
        Me.SubscriptionsGrid.TabIndex = 0
        Me.SubscriptionsGrid.TotalText = "Totals"
        '
        'CompanyNameColumn
        '
        Me.CompanyNameColumn.AutoSize = True
        Me.CompanyNameColumn.Caption = "Company Name "
        Me.CompanyNameColumn.IgnoreTotalTheming = False
        Me.CompanyNameColumn.SavedMementoName = "Company Name "
        Me.CompanyNameColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CompanyNameColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'AddonNameColumn
        '
        Me.AddonNameColumn.AutoSize = True
        Me.AddonNameColumn.Caption = "Addon Name "
        Me.AddonNameColumn.IgnoreTotalTheming = False
        Me.AddonNameColumn.SavedMementoName = "Addon Name "
        Me.AddonNameColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.AddonNameColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.AutoSize = True
        Me.DescriptionColumn.Caption = "Description "
        Me.DescriptionColumn.IgnoreTotalTheming = False
        Me.DescriptionColumn.SavedMementoName = "Description "
        Me.DescriptionColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DescriptionColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'OneOffCostColumn
        '
        Me.OneOffCostColumn.Caption = "One-Off Cost "
        Me.OneOffCostColumn.IgnoreTotalTheming = False
        Me.OneOffCostColumn.SavedMementoName = "One-Off Cost "
        Me.OneOffCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.OneOffCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'MonthlyCostColumn
        '
        Me.MonthlyCostColumn.Caption = "Monthly Cost "
        Me.MonthlyCostColumn.IgnoreTotalTheming = False
        Me.MonthlyCostColumn.SavedMementoName = "Monthly Cost "
        Me.MonthlyCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.MonthlyCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'OneOffStandaloneCostColumn
        '
        Me.OneOffStandaloneCostColumn.Caption = "One-Off Cost (Standalone) "
        Me.OneOffStandaloneCostColumn.IgnoreTotalTheming = False
        Me.OneOffStandaloneCostColumn.SavedMementoName = "One-Off Cost (Standalone) "
        Me.OneOffStandaloneCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.OneOffStandaloneCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'MonthlyStandaloneCostColumn
        '
        Me.MonthlyStandaloneCostColumn.Caption = "Monthly Cost (Standalone) "
        Me.MonthlyStandaloneCostColumn.IgnoreTotalTheming = False
        Me.MonthlyStandaloneCostColumn.SavedMementoName = "Monthly Cost (Standalone) "
        Me.MonthlyStandaloneCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.MonthlyStandaloneCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'BillingFrequencyColumn
        '
        Me.BillingFrequencyColumn.Caption = "Billing Frequency "
        Me.BillingFrequencyColumn.IgnoreTotalTheming = False
        Me.BillingFrequencyColumn.SavedMementoName = "Billing Frequency "
        Me.BillingFrequencyColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BillingFrequencyColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ExpiryDateColumn
        '
        Me.ExpiryDateColumn.Caption = "Expiry Date "
        Me.ExpiryDateColumn.IgnoreTotalTheming = False
        Me.ExpiryDateColumn.SavedMementoName = "Expiry Date "
        Me.ExpiryDateColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpiryDateColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'CostPerBillingCycleColumn
        '
        Me.CostPerBillingCycleColumn.Caption = "Cost per Billing Cycle "
        Me.CostPerBillingCycleColumn.IgnoreTotalTheming = False
        Me.CostPerBillingCycleColumn.SavedMementoName = "Cost per Billing Cycle "
        Me.CostPerBillingCycleColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CostPerBillingCycleColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ViewButton
        '
        Me.ViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ViewButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Location = New System.Drawing.Point(93, 401)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(75, 28)
        Me.ViewButton.TabIndex = 10
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(1177, 401)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 28)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemoveButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(255, 401)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 28)
        Me.RemoveButton.TabIndex = 8
        Me.RemoveButton.Text = "Delete"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(174, 401)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 28)
        Me.EditButton.TabIndex = 7
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(12, 401)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 28)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Subscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 441)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SubscriptionsGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Subscriptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.SubscriptionsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubscriptionsGrid As Sage.ObjectStore.Controls.Grid
    Friend WithEvents ViewButton As Sage.Common.Controls.Button
    Friend WithEvents CloseButton As Sage.Common.Controls.Button
    Friend WithEvents RemoveButton As Sage.Common.Controls.Button
    Friend WithEvents EditButton As Sage.Common.Controls.Button
    Friend WithEvents AddButton As Sage.Common.Controls.Button
    Friend WithEvents AddonNameColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents DescriptionColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents MonthlyCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents OneOffCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents OneOffStandaloneCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents MonthlyStandaloneCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CompanyNameColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents BillingFrequencyColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents ExpiryDateColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CostPerBillingCycleColumn As Sage.ObjectStore.Controls.GridColumn
End Class
