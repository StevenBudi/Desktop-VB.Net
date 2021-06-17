Imports MySql.Data.MySqlClient
Module Connector
    Public connector As New MySqlConnection
    Public query As String
    Public adapter As MySqlDataAdapter
    Public dataset As DataSet

    Sub openConnection()
        Try
            connector.ConnectionString = "server=localhost; user id=root; password=; database=siswa_vb"
            connector.Open()
            MsgBox("Connection Success")
        Catch ex As Exception
            MsgBox("Connection Failed : " & ex.ToString)
        End Try
    End Sub

    Function getData()
        dataset = New DataSet
        query = "SELECT * FROM data_siswa"
        adapter = New MySqlDataAdapter(query, connector)
        adapter.Fill(dataset)
        Return dataset.Tables(0)
    End Function

    Sub insertData(data1, data2, data3, data4)
        Dim insert = New MySqlCommand
        insert.Connection = connector
        Try
            query = "INSERT INTO data_siswa(nama, nis, kelas, jk) VALUES('" & data1 & "', '" & data2 & "', '" & data3 & "', '" & data4 & "')"
            insert.CommandText = query
            insert.ExecuteNonQuery()
            MsgBox("Insert Success")

        Catch ex As Exception
            MsgBox("Insert Failed : " & ex.ToString)
        End Try
    End Sub


    Sub editData(data1, data2, data3, data4)
        Dim edit = New MySqlCommand
        edit.Connection = connector
        Try
            query = "UPDATE data_siswa SET nama= '" & data1 & "', nis='" & data2 & "', kelas='" & data3 & "', jk ='" & data4 & "' WHERE nama='" & data1 & "'"
            edit.CommandText = query
            edit.ExecuteNonQuery()
            MsgBox("Edit Success")

        Catch ex As Exception
            MsgBox("Edit Failed : " & ex.ToString)
        End Try
    End Sub

    Sub deleteData(data1)
        Dim delete = New MySqlCommand
        delete.Connection = connector
        Try
            query = "DELETE FROM data_siswa WHERE nama = '" & data1 & "'"
            delete.CommandText = query
            delete.ExecuteNonQuery()
            MsgBox("Delete Success")

        Catch ex As Exception
            MsgBox("Delete Failed : " & ex.ToString)
        End Try
    End Sub

End Module
