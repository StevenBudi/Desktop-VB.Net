Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Dim num As Regex = New Regex("[\d+]", RegexOptions.IgnoreCase)
    Dim alpha As Regex = New Regex("[\w+]", RegexOptions.IgnoreCase)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If num.IsMatch(TextBox1.Text) And alpha.IsMatch(TextBox1.Text) Then
            Label1.Text = "The input is containing a number"
        ElseIf alpha.IsMatch(TextBox1.Text) Then
            Label1.Text = "The input is String"
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
