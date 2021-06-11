Public Class Form1
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Dim f2 As New Form2
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Dim f3 As New Form3
        f3.MdiParent = Me
        f3.Show()
    End Sub
End Class
