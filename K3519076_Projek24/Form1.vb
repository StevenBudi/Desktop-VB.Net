Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            'I As Integer = Me.DataGridView1.SelectedRows.Count - 1 Begin
            'To 0 End
            'Step -1
            For I As Integer = Me.DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                Me.DataGridView1.Rows.RemoveAt(Me.DataGridView1.SelectedRows(I).Index)
            Next
        Else
            MessageBox.Show("Nothing to delete")
        End If
    End Sub
End Class
