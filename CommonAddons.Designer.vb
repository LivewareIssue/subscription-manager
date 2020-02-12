<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommonAddons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommonAddons))
        Me.CommonAddonsGrid = New Sage.ObjectStore.Controls.Grid()
        Me.CommonAddonsGrid_NameColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.CommonAddonsGrid_DescriptionColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.CommonAddonsGrid_OneOffCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.CommonAddonsGrid_MonthlyCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.CommonAddonsGrid_OneOffStandaloneColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.CommonAddonsGrid_MonthlyStandaloneCostColumn = New Sage.ObjectStore.Controls.GridColumn()
        Me.AddButton = New Sage.Common.Controls.Button()
        Me.EditButton = New Sage.Common.Controls.Button()
        Me.RemoveButton = New Sage.Common.Controls.Button()
        Me.CloseButton = New Sage.Common.Controls.Button()
        Me.ViewButton = New Sage.Common.Controls.Button()
        CType(Me.CommonAddonsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommonAddonsGrid
        '
        Me.CommonAddonsGrid.AllowMultiSelect = Sage.Common.Controls.MultiSelect.Standard
        Me.CommonAddonsGrid.AllowSort = True
        Me.CommonAddonsGrid.AllowTabNavigation = True
        Me.CommonAddonsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommonAddonsGrid.BackColor = System.Drawing.SystemColors.Window
        Me.CommonAddonsGrid.CardWidth = 760
        Me.CommonAddonsGrid.CheckedDisplayMember = Nothing
        Me.CommonAddonsGrid.ChildMember = Nothing
        Me.CommonAddonsGrid.Columns.AddRange(New Sage.ObjectStore.Controls.GridColumn() {Me.CommonAddonsGrid_NameColumn, Me.CommonAddonsGrid_DescriptionColumn, Me.CommonAddonsGrid_OneOffCostColumn, Me.CommonAddonsGrid_MonthlyCostColumn, Me.CommonAddonsGrid_OneOffStandaloneColumn, Me.CommonAddonsGrid_MonthlyStandaloneCostColumn})
        Me.CommonAddonsGrid.CustomContextMenu = Nothing
        Me.CommonAddonsGrid.FaintHighlightColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid.FixedSize = True
        Me.CommonAddonsGrid.GroupMember = Nothing
        Me.CommonAddonsGrid.IsEmptyOnAnySubItem = False
        Me.CommonAddonsGrid.ListPresenter = Nothing
        Me.CommonAddonsGrid.Location = New System.Drawing.Point(12, 12)
        Me.CommonAddonsGrid.Name = "CommonAddonsGrid"
        Me.CommonAddonsGrid.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CommonAddonsGrid.SelectedForeColor = System.Drawing.Color.Black
        Me.CommonAddonsGrid.ShowContextMenuAdvancedOptions = False
        Me.CommonAddonsGrid.ShowExtendedScrollBar = False
        Me.CommonAddonsGrid.Size = New System.Drawing.Size(760, 376)
        Me.CommonAddonsGrid.TabIndex = 0
        Me.CommonAddonsGrid.TotalText = "Totals"
        '
        'CommonAddonsGrid_NameColumn
        '
        Me.CommonAddonsGrid_NameColumn.AutoSize = True
        Me.CommonAddonsGrid_NameColumn.Caption = "Addon Name "
        Me.CommonAddonsGrid_NameColumn.IgnoreTotalTheming = False
        Me.CommonAddonsGrid_NameColumn.SavedMementoName = "Addon Name "
        Me.CommonAddonsGrid_NameColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid_NameColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'CommonAddonsGrid_DescriptionColumn
        '
        Me.CommonAddonsGrid_DescriptionColumn.AutoSize = True
        Me.CommonAddonsGrid_DescriptionColumn.Caption = "Description "
        Me.CommonAddonsGrid_DescriptionColumn.IgnoreTotalTheming = False
        Me.CommonAddonsGrid_DescriptionColumn.SavedMementoName = "Description "
        Me.CommonAddonsGrid_DescriptionColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid_DescriptionColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'CommonAddonsGrid_OneOffCostColumn
        '
        Me.CommonAddonsGrid_OneOffCostColumn.Caption = "One-Off Cost "
        Me.CommonAddonsGrid_OneOffCostColumn.IgnoreTotalTheming = False
        Me.CommonAddonsGrid_OneOffCostColumn.SavedMementoName = "One-Off Cost "
        Me.CommonAddonsGrid_OneOffCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid_OneOffCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'CommonAddonsGrid_MonthlyCostColumn
        '
        Me.CommonAddonsGrid_MonthlyCostColumn.Caption = "Monthly Cost "
        Me.CommonAddonsGrid_MonthlyCostColumn.IgnoreTotalTheming = False
        Me.CommonAddonsGrid_MonthlyCostColumn.SavedMementoName = "Monthly Cost "
        Me.CommonAddonsGrid_MonthlyCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid_MonthlyCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'CommonAddonsGrid_OneOffStandaloneColumn
        '
        Me.CommonAddonsGrid_OneOffStandaloneColumn.Caption = "One-Off Cost (Standalone) "
        Me.CommonAddonsGrid_OneOffStandaloneColumn.IgnoreTotalTheming = False
        Me.CommonAddonsGrid_OneOffStandaloneColumn.SavedMementoName = "One-Off Cost (Standalone) "
        Me.CommonAddonsGrid_OneOffStandaloneColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid_OneOffStandaloneColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'CommonAddonsGrid_MonthlyStandaloneCostColumn
        '
        Me.CommonAddonsGrid_MonthlyStandaloneCostColumn.Caption = "Monthly Cost (Standalone) "
        Me.CommonAddonsGrid_MonthlyStandaloneCostColumn.IgnoreTotalTheming = False
        Me.CommonAddonsGrid_MonthlyStandaloneCostColumn.SavedMementoName = "Monthly Cost (Standalone) "
        Me.CommonAddonsGrid_MonthlyStandaloneCostColumn.TotalBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CommonAddonsGrid_MonthlyStandaloneCostColumn.TotalForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(12, 401)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 28)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(174, 401)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 28)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemoveButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(255, 401)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 28)
        Me.RemoveButton.TabIndex = 3
        Me.RemoveButton.Text = "Delete"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(697, 401)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 28)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ViewButton
        '
        Me.ViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ViewButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Location = New System.Drawing.Point(93, 401)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(75, 28)
        Me.ViewButton.TabIndex = 5
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'CommonAddons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CommonAddonsGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CommonAddons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Common Addons"
        CType(Me.CommonAddonsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CommonAddonsGrid As Sage.ObjectStore.Controls.Grid
    Friend WithEvents CommonAddonsGrid_NameColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CommonAddonsGrid_DescriptionColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CommonAddonsGrid_OneOffCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CommonAddonsGrid_MonthlyCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CommonAddonsGrid_OneOffStandaloneColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents CommonAddonsGrid_MonthlyStandaloneCostColumn As Sage.ObjectStore.Controls.GridColumn
    Friend WithEvents AddButton As Sage.Common.Controls.Button
    Friend WithEvents EditButton As Sage.Common.Controls.Button
    Friend WithEvents RemoveButton As Sage.Common.Controls.Button
    Friend WithEvents CloseButton As Sage.Common.Controls.Button
    Friend WithEvents ViewButton As Sage.Common.Controls.Button
End Class
