Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient

Public Class FormTambahPetugas
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

            Query = "INSERT INTO petugas_parkir (nama,username,password,role) values ('" & Nm_petugas.Text & "','" & username.Text & "','" & password.Text & "','" & role.Text & "')"
            COMM = New MySqlCommand(Query, koneksi)
            Reader = COMM.ExecuteReader

            MessageBox.Show("Data tersimpan")
            Nm_petugas.Text = ""
            username.Text = ""
            password.Text = ""
            role.Text = ""

            koneksi.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            koneksi.Dispose()
        End Try

        Dim form = New FormListPetugas()
        form.Show()
        Me.Visible = False
    End Sub

    'Private Sub autogenerate()
    '    koneksi = New MySqlConnection
    '    koneksi.ConnectionString =
    '    "server=localhost;user=root;password=;database=jurasik"
    '    Dim Reader As MySqlDataReader

    '    Try
    '        koneksi.Open()
    '        Dim Query As String
    '        Dim number As Integer

    '        Query = "SELECT Max(id_petugas) FROM petugas_parkir"
    '        COMM = New MySqlCommand(Query, koneksi)
    '        Reader = COMM.ExecuteReader

    '        If IsDBNull(COMM.ExecuteScalar) Then
    '            number = 101
    '            Nm_petugas.Text = number
    '        Else
    '            number = COMM.ExecuteScalar + 1
    '            Nm_petugas.Text = number
    '        End If

    '        Nm_petugas.Text = ""
    '        username.Text = ""
    '        password.Text = ""
    '        role.Text = ""

    '        koneksi.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        koneksi.Dispose()
    '    End Try
    'End Sub

    Private Sub FormTambahPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class