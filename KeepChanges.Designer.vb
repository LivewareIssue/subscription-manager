<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeepChanges
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.ChangesTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The following unsaved changes to subscriptions were detected:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Do you wish to keep these changes?"
        '
        'NoButton
        '
        Me.NoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.NoButton.Location = New System.Drawing.Point(396, 173)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 28)
        Me.NoButton.TabIndex = 8
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'YesButton
        '
        Me.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.YesButton.Location = New System.Drawing.Point(12, 173)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 28)
        Me.YesButton.TabIndex = 7
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'ChangesTextBox
        '
        Me.ChangesTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ChangesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangesTextBox.Location = New System.Drawing.Point(12, 38)
        Me.ChangesTextBox.Multiline = True
        Me.ChangesTextBox.Name = "ChangesTextBox"
        Me.ChangesTextBox.ReadOnly = True
        Me.ChangesTextBox.Size = New System.Drawing.Size(459, 96)
        Me.ChangesTextBox.TabIndex = 9
        '
        'KeepChanges
        '
        Me.AcceptButton = Me.YesButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NoButton
        Me.ClientSize = New System.Drawing.Size(486, 213)
        Me.Controls.Add(Me.ChangesTextBox)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KeepChanges"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unsaved Changes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents ChangesTextBox As System.Windows.Forms.TextBox
End Class
