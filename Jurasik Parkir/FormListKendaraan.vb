Public Class FormListKendaraan
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
End Class