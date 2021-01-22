Imports MySql.Data.MySqlClient

Public Class rekap

    Dim sql As String
    Dim cmd As MySqlCommand


    Private Sub kasMasuk_Click(sender As Object, e As EventArgs) Handles kasMasuk.Click
        Me.Hide()
        kMasuk.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        kKeluar.Show()
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub cetak_Click(sender As Object, e As EventArgs) Handles cetak.Click

        bukakoneksi()
        sql = "UPDATE tanggal SET awal ='" + awal.Value.ToString("yyyy-MM-dd") + "', akhir ='" + akhir.Value.ToString("yyyy-MM-dd") + "' WHERE no='1'"
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di Cari" + Environment.NewLine + "Mohon Tunggu !", MsgBoxStyle.Information, "Information")
        Dim report As New MyReport
        Me.CrystalReportViewer1.ReportSource = report
        Me.CrystalReportViewer1.Refresh()
        Me.CrystalReportViewer1.RefreshReport()
        Me.Show()


    End Sub

End Class