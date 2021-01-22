
Imports MySql.Data.MySqlClient
Public Module koneksi
    Public conn As MySqlConnection
    Public Sub bukakoneksi()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam koneksi database")
        End Try
    End Sub
End Module
