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
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()
            Me.Close()
        End If
    End Sub

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub DataInvestasiPendidikanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataInvestasiPendidikanToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub LaporanMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanMahasiswaToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub LaporanPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembayaranToolStripMenuItem.Click
        Form7.Show()
    End Sub
End Class