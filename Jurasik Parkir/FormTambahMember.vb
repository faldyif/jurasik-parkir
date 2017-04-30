Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient

Public Class FormTambahMember
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

            Query = "INSERT INTO member (nama,plat_no) values ('" & Nm_member.Text & "','" & nopol.Text & "')"
            COMM = New MySqlCommand(Query, koneksi)
            Reader = COMM.ExecuteReader

            MessageBox.Show("Data tersimpan")
            Nm_member.Text = ""
            nopol.Text = ""
            status.Text = ""


            koneksi.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            koneksi.Dispose()
        End Try
    End Sub

    Private Sub FormTambahMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class