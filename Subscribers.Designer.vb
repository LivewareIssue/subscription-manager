<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscribers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subscribers))
        Me.SubscribersGrid = New Sage.ObjectStore.Controls.Grid()
        Me.SubscriptionsGrid_CompanyNameColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.SubscriptionsGrid_BillingFrequencyColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.SubscriptionsGrid_ExpiryDateColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.SubscriptionsGrid_CostPerBillingCycleColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.ViewButton = New Sage.Common.Controls.Button()
        Me.CloseButton = New Sage.Common.Controls.Button()
        Me.RemoveButton = New Sage.Common.Controls.Button()
        Me.EditButton = New Sage.Common.Controls.Button()
        Me.AddButton = New Sage.Common.Controls.Button()
        Me.ListColumn1 = New Sage.ObjectStore.Controls.ListColumn()
        CType(Me.SubscribersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubscribersGrid
        '
        Me.SubscribersGrid.AllowMultiSelect = Sage.Common.Controls.MultiSelect.Standard
        Me.SubscribersGrid.AllowSort = True
        Me.SubscribersGrid.AllowTabNavigation = True
        Me.SubscribersGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubscribersGrid.BackColor = System.Drawing.SystemColors.Window
        Me.SubscribersGrid.CardWidth = 760
        Me.SubscribersGrid.CheckedDisplayMember = Nothing
        Me.SubscribersGrid.ChildMember = Nothing
        Me.SubscribersGrid.Columns.AddRange(New Sage.ObjectStore.Controls.GridColumn() {Me.SubscriptionsGrid_CompanyNameColumn, Me.SubscriptionsGrid_BillingFrequencyColumn, Me.SubscriptionsGrid_ExpiryDateColumn, Me.SubscriptionsGrid_CostPerBillingCycleColumn})
        Me.SubscribersGrid.CustomContextMenu = Nothing
        Me.SubscribersGrid.FaintHighlightColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SubscribersGrid.FixedSize = True
        Me.SubscribersGrid.GroupMember = Nothing
        Me.SubscribersGrid.IsEmptyOnAnySubItem = False
        Me.SubscribersGrid.ListPresenter = Nothing
        Me.SubscribersGrid.Location = New System.Drawing.Point(12, 12)
        Me.SubscribersGrid.Name = "SubscribersGrid"
        Me.SubscribersGrid.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SubscribersGrid.SelectedForeColor = System.Drawing.Color.Black
        Me.SubscribersGrid.ShowContextMenuAdvancedOptions = False
        Me.SubscribersGrid.ShowExtendedScrollBar = False
        Me.SubscribersGrid.Size = New System.Drawing.Size(760, 376)
        Me.SubscribersGrid.TabIndex = 1
        Me.SubscribersGrid.TotalText = "Totals"
        '
        'SubscriptionsGrid_CompanyNameColumn
        '
        Me.SubscriptionsGrid_CompanyNameColumn.AutoSize = True
        Me.SubscriptionsGrid_CompanyNameColumn.Caption = "Company Name "
        Me.SubscriptionsGrid_CompanyNameColumn.IgnoreTotalTheming = False
        Me.SubscriptionsGrid_CompanyNameColumn.SavedMementoName = "Company Name "
        Me.SubscriptionsGrid_CompanyNameColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SubscriptionsGrid_CompanyNameColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'SubscriptionsGrid_BillingFrequencyColumn
        '
        Me.SubscriptionsGrid_BillingFrequencyColumn.Caption = "Billing Frequency "
        Me.SubscriptionsGrid_BillingFrequencyColumn.IgnoreTotalTheming = False
        Me.SubscriptionsGrid_BillingFrequencyColumn.SavedMementoName = "Billing Frequency "
        Me.SubscriptionsGrid_BillingFrequencyColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SubscriptionsGrid_BillingFrequencyColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'SubscriptionsGrid_ExpiryDateColumn
        '
        Me.SubscriptionsGrid_ExpiryDateColumn.Caption = "Expiry Date "
        Me.SubscriptionsGrid_ExpiryDateColumn.IgnoreTotalTheming = False
        Me.SubscriptionsGrid_ExpiryDateColumn.SavedMementoName = "Expiry Date "
        Me.SubscriptionsGrid_ExpiryDateColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SubscriptionsGrid_ExpiryDateColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'SubscriptionsGrid_CostPerBillingCycleColumn
        '
        Me.SubscriptionsGrid_CostPerBillingCycleColumn.Caption = "Cost per Billing Cycle "
        Me.SubscriptionsGrid_CostPerBillingCycleColumn.IgnoreTotalTheming = False
        Me.SubscriptionsGrid_CostPerBillingCycleColumn.SavedMementoName = "Cost / Billing Cycle "
        Me.SubscriptionsGrid_CostPerBillingCycleColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SubscriptionsGrid_CostPerBillingCycleColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.CloseButton.Location = New System.Drawing.Point(697, 401)
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
        'ListColumn1
        '
        Me.ListColumn1.Caption = "ListColumn1 "
        Me.ListColumn1.IgnoreTotalTheming = False
        Me.ListColumn1.SavedMementoName = "ListColumn1 "
        Me.ListColumn1.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ListColumn1.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Subscribers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SubscribersGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Subscribers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.SubscribersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubscribersGrid As Sage.ObjectStore.Controls.Grid
    Friend WithEvents ViewButton As Sage.Common.Controls.Button
    Friend WithEvents CloseButton As Sage.Common.Controls.Button
    Friend WithEvents RemoveButton As Sage.Common.Controls.Button
    Friend WithEvents EditButton As Sage.Common.Controls.Button
    Friend WithEvents AddButton As Sage.Common.Controls.Button
    Friend WithEvents SubscriptionsGrid_CompanyNameColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents SubscriptionsGrid_BillingFrequencyColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents SubscriptionsGrid_ExpiryDateColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents SubscriptionsGrid_CostPerBillingCycleColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents ListColumn1 As Sage.ObjectStore.Controls.ListColumn
End Class
