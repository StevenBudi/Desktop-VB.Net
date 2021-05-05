Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Text File |*.txt|PDF File |*.pdf|All Files |*.*"
        OpenFileDialog1.Multiselect = True
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            For x = 0 To OpenFileDialog1.FileNames.Count - 1
                TextBox1.Text += OpenFileDialog1.FileNames(x)
            Next
        End If
    End Sub
End Class
