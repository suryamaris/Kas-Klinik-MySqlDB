
Imports MySql.Data.MySqlClient

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.Text = ""
        pass.Text = ""
    End Sub

    Private Sub pass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pass.KeyPress

        If (e.KeyChar = Chr(13)) Then

            masuk.PerformClick()

        End If

    End Sub
    Private Sub masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam koneksi database")
        End Try
        Dim myAdapter As New MySqlDataAdapter

        Dim sqlQuery = "SELECT * FROM admin WHERE user='" + user.Text + "' AND pass='" + pass.Text + "'"
        Dim myCommand As New MySqlCommand
        myCommand.Connection = conn
        myCommand.CommandText = sqlQuery

        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()

        If myData.HasRows = 0 Then
            MsgBox("username dan password salah!! ",
                   MsgBoxStyle.Exclamation, "Error Login")
        Else
            user.Text = ""
            pass.Text = ""
            Me.Hide()
            Home.Show()

          
        End If

    End Sub


End Class