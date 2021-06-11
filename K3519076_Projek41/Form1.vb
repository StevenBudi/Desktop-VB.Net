Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF Files | *.pdf"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            WebBrowser2.Navigate(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
