Imports MySql.Data.MySqlClient

Public Class Home
    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiText()
        isiText1()
    End Sub
    Dim jumlahMasuk, jumlahKeluar, jumlahSaldo As Int64

    Sub isiText()
        Try
            Dim conn As MySqlConnection
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Ada kesalahan dalam koneksi database")
            End Try
            Dim myAdapter As New MySqlDataAdapter
            Dim sql As String
            
            sql = "SELECT SUM(jumlah) as jumlah FROM kas WHERE jenis ='Kas Masuk'"
            Dim myCommand As New MySqlCommand
            myCommand.Connection = conn
            myCommand.CommandText = sql

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()
            myData.Read()
            If myData.HasRows Then
                masuk.Text = myData.Item("jumlah")
                jumlahMasuk = myData.Item("jumlah")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Sub isiText1()
        Try
            Dim conn As MySqlConnection
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Ada kesalahan dalam koneksi database")
            End Try

            Dim myAdapter As New MySqlDataAdapter
            Dim sql = "SELECT SUM(jumlah) as jumlah FROM kas WHERE jenis ='Kas Keluar'"
            Dim myCommand As New MySqlCommand
            myCommand.Connection = conn
            myCommand.CommandText = sql

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()
            myData.Read()
            If myData.HasRows Then
                keluar.Text = myData.Item("jumlah")
                jumlahKeluar = myData.Item("jumlah")
            End If
            jumlahSaldo = jumlahMasuk - jumlahKeluar
            saldo.Text = jumlahSaldo

        Catch ex As Exception
        End Try
    End Sub

    Private Sub kasKeluar_Click(sender As Object, e As EventArgs) Handles kasKeluar.Click
        Me.Hide()
        kKeluar.Show()
    End Sub

    Private Sub data_Click(sender As Object, e As EventArgs) Handles Data.Click
        isiText()
        isiText1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub rekapitulasi_Click(sender As Object, e As EventArgs) Handles rekapitulasi.Click
        Me.Hide()
        rekap.Show()
    End Sub


    Private Sub kasMasuk_Click(sender As Object, e As EventArgs) Handles kasMasuk.Click
        Me.Hide()
        kMasuk.Show()
    End Sub


    
  
End Class
