Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox1.Text)
        MessageBox.Show("Item succesfully added")
        ComboBox1.Text = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MessageBox.Show(ComboBox1.Text)
    End Sub
End Class
