Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient

Public Class FormKendaraanMasuk
    Dim koneksi As New MySqlConnection
    Dim COMM As New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi = New MySqlConnection
        koneksi.ConnectionString =
        "server=localhost;user=root;password=;database=jurasik"
        Dim Reader As MySqlDataReader

        Try
            koneksi.Open()
            Dim Query As String

            Query = "INSERT INTO kendaraan (plat_no,tipe_kendaraan) values ('" & nopol.Text & "','" & tipekendaraan.Text & "')"
            COMM = New MySqlCommand(Query, koneksi)
            Reader = COMM.ExecuteReader

            MessageBox.Show("Data tersimpan")
            nopol.Text = ""
            tipekendaraan.Text = ""

            koneksi.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            koneksi.Dispose()
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        FormLogin.Show()
    End Sub
End Class