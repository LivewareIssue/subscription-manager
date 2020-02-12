Imports System.Collections.Generic

Public Class KeepChanges
    Public Sub New(changes As List(Of String))
        InitializeComponent()
        For Each change As String In changes
            ChangesTextBox.Text += $"• {change}" + Environment.NewLine
        Next
    End Sub
End Class