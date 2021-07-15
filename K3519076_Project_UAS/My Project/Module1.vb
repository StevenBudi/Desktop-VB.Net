Imports MySql.Data.MySqlClient
Module Connector
    Public connector As New MySqlConnection
    Public query As String
    Public adapter As MySqlDataAdapter
    Public dataset As DataSet

    Sub openConnection()
        Try
            connector.ConnectionString = "server=localhost; user id=root; password=; database=calculator"
            connector.Open()
            MsgBox("Connection Success")
        Catch ex As Exception
            MsgBox("Connection Failed : " & ex.ToString)
        End Try
    End Sub

    Function getData()
        dataset = New DataSet
        query = "SELECT * FROM history"
        adapter = New MySqlDataAdapter(query, connector)
        adapter.Fill(dataset)
        Return dataset.Tables(0)
    End Function

    Sub insertData(data1, data2)
        Dim insert = New MySqlCommand
        insert.Connection = connector
        Try
            query = "INSERT INTO history(Transaction, Result) VALUES('" & data1 & "', '" & data2 & "')"
            insert.CommandText = query
            insert.ExecuteNonQuery()
            MsgBox("Insert Success")

        Catch ex As Exception
            MsgBox("Insert Failed : " & ex.ToString)
        End Try
    End Sub
End Module
