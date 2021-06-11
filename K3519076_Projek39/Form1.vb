Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim command As System.Data.OleDb.OleDbDataAdapter
            Dim path = TextBox1.Text

            myConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            command = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [Sheet1$]", myConnection)

            dataSet = New System.Data.DataSet
            command.Fill(dataSet)

            DataGridView1.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
