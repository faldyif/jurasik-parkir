Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient


Public Class FormLogin
    Dim koneksi As New MySqlConnection

    Private Sub openKoneksi()
        koneksi.ConnectionString =
        "server=localhost;user=root;password=;database=jurasik"
        koneksi.Open()
    End Sub

    Private Sub closeKoneksi()
        koneksi.Close()
    End Sub

    Private Sub eksekusiLogin(ByVal username As String, ByVal password As String)
        openKoneksi()

        Dim adapter As New MySqlDataAdapter("SELECT * FROM petugas_parkir WHERE username = '" & username & "' AND password = '" & password & "'", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        If (table.Rows.Count.Equals(1)) Then
            If (table.Rows(0)(3).Equals(1)) Then
                Dim form = New FormKendaraanMasuk()
                form.Show()
                Me.Visible = False
            ElseIf (table.Rows(0)(3).Equals(2)) Then
                Dim form = New FormKendaraanKeluar()
                form.Show()
                Me.Visible = False
            ElseIf (table.Rows(0)(3).Equals(3)) Then
                Dim form = New FormListKendaraan()
                form.Show()
                Me.Visible = False
            End If
        Else
            MessageBox.Show("Username atau password anda salah!")
        End If

        koneksi.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text

        eksekusiLogin(username, password)
    End Sub
End Class
