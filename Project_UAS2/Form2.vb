Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim dialogres As DialogResult = MessageBox.Show("Keluar Aplikasi ?", "Info", MessageBoxButtons.YesNo)
        If dialogres = DialogResult.Yes Then
            Form1.TextBox1.Text = Nothing
            Form1.TextBox2.Text = Nothing
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class