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
End Class