Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient

Public Class FormListKendaraan
    Dim koneksi As New MySqlConnection

    Private Sub openKoneksi()
        koneksi.ConnectionString =
        "server=localhost;user=root;password=;database=jurasik"
        koneksi.Open()
    End Sub

    Private Sub closeKoneksi()
        koneksi.Close()
    End Sub

    Private Sub ListKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListKendaraanToolStripMenuItem.Click
        Dim form = New FormListPetugas()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub ListMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListMemberToolStripMenuItem.Click
        Dim form = New FormListMember()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub FormListKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openKoneksi()

        Dim data As New MySqlDataAdapter("SELECT * FROM kendaraan", koneksi)
        Dim table As New DataTable
        data.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.Columns(0).HeaderText = "NoPol"
        DataGridView1.Columns(1).HeaderText = "Jenis"

        closeKoneksi()
    End Sub

    Private Sub TambahPetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahPetugasToolStripMenuItem.Click
        Dim form = New FormTambahPetugas()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub TambahMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahMemberToolStripMenuItem.Click
        Dim form = New FormTambahMember()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form = New FormLogin()
        form.Show()
        Me.Hide()
    End Sub
End Class