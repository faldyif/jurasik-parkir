Public Class FormListPetugas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New FormListPetugas()
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
End Class