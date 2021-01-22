Imports MySql.Data.MySqlClient
Public Class kKeluar
    Dim sql As String
    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.kas' table. You can move, or remove it, as needed.

        tampil()
    End Sub

    Sub tampil()
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam koneksi database")
        End Try
        Dim myAdapter As New MySqlDataAdapter

        Dim da As New MySqlDataAdapter("SELECT * FROM kas WHERE jenis ='Kas Keluar'", conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable

        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next

    End Sub



    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam koneksi database")
        End Try
        If id.Text = "" Then
            Dim myAdapter As New MySqlDataAdapter
            Dim sqlQuery = "INSERT INTO kas(tanggal,jenis,keterangan,jumlah) VALUES('" + tanggal.Value.ToString("yyyy-MM-dd") + "','Kas Keluar','" + keterangan.Text + "','" + jumlah.Text + "') "
            Dim myCommand As New MySqlCommand
            myCommand.Connection = conn
            myCommand.CommandText = sqlQuery

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()

            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            keterangan.Text = ""
            jumlah.Text = ""
            id.Text = ""
            tampil()
        End If
    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim i As Integer
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user id=root; password= ; database=kas"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Ada kesalahan dalam koneksi database")
        End Try
        Dim myAdapter As New MySqlDataAdapter
        i = DataGridView1.CurrentRow.Index
        Dim cmd As New MySqlCommand
        cmd = New MySqlCommand("Select * from kas where id='" & DataGridView1.Item(0, i).Value & "'", conn)
        myAdapter.SelectCommand = cmd
        Dim myData As MySqlDataReader
        myData = cmd.ExecuteReader()
        myData.Read()
        If Not myData.HasRows Then
            keterangan.Focus()
        Else
            id.Text = myData.Item("Id")
            tanggal.Text = myData.Item("tanggal")
            jumlah.Text = myData.Item("jumlah")
            keterangan.Text = myData.Item("keterangan")
            id.Focus()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        bukakoneksi()
        tanggal.Value.ToString("yyyy-MM-dd")
        sql = "Update kas set tanggal= '" & tanggal.Value.ToString("yyyy-MM-dd") & "', jumlah = '" & jumlah.Text & "', keterangan='" & keterangan.Text & "' where Id= '" & id.Text & "'"
        Dim cmd As New MySqlCommand
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di Ubah", MsgBoxStyle.Information, "Information")
        keterangan.Text = ""
        jumlah.Text = ""
        id.Text = ""
        tampil()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Dim pesanuser As String
        pesanuser = MsgBox("Yakin Hapus Data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Programer Junior")
        If pesanuser = vbYes Then
            bukakoneksi()
            Dim cmd As New MySqlCommand
            sql = "delete from kas where Id='" & id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "Information")
            keterangan.Text = ""
            jumlah.Text = ""
            id.Text = ""
            tampil()
        End If
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class