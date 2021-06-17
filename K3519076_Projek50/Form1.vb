Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        DataGridView1.DataSource = getData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertData(TextBox1.Text, TextBox2.Text, ComboBox1.Text, ComboBox2.Text)
        clearData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.DataSource = getData()
        clearData()
    End Sub

    Sub clearData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        ComboBox1.Text = DataGridView1.Item(2, i).Value
        ComboBox2.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editData(TextBox1.Text, TextBox2.Text, ComboBox1.Text, ComboBox2.Text)
        clearData()
        DataGridView1.DataSource = getData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deleteData(TextBox1.Text)
        clearData()
        DataGridView1.DataSource = getData()
    End Sub
End Class
