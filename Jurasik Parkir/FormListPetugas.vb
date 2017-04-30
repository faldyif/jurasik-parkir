Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient

Public Class FormListPetugas
    Dim koneksi As New MySqlConnection

    Private Sub openKoneksi()
        koneksi.ConnectionString =
        "server=localhost;user=root;password=;database=jurasik"
        koneksi.Open()
    End Sub

    Private Sub closeKoneksi()
        koneksi.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New FormTambahPetugas()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub ListMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListMemberToolStripMenuItem.Click
        Dim form = New FormListMember()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub ListKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListKendaraanToolStripMenuItem.Click
        Dim form = New FormListKendaraan()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub FormListPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openKoneksi()

        Dim data As New MySqlDataAdapter("SELECT * FROM petugas_parkir", koneksi)
        Dim table As New DataTable
        data.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.Columns(0).HeaderText = "Username"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Password"

        closeKoneksi()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form = New FormLogin()
        form.Show()
        Me.Hide()
    End Sub
End Class