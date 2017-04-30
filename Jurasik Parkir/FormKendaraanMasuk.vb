Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient

Public Class FormKendaraanMasuk
    Dim koneksi As New MySqlConnection
    Dim COMM As New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim plat_no As String
        plat_no = nopol.Text

        koneksi = New MySqlConnection
        koneksi.ConnectionString =
        "server=localhost;user=root;password=;database=jurasik"
        Dim Reader As MySqlDataReader

        Try
            koneksi.Open()

            Dim Query As String

            Dim adapter As New MySqlDataAdapter("SELECT * FROM kendaraan WHERE plat_no = '" & plat_no & "'", koneksi)
            koneksi.Close()

            Dim table As New DataTable
            adapter.Fill(table)
            If (table.Rows.Count.Equals(0)) Then
                koneksi.Open()
                Query = "INSERT INTO kendaraan (plat_no,tipe_kendaraan) values ('" & nopol.Text & "','" & tipekendaraan.Text & "')"
                COMM = New MySqlCommand(Query, koneksi)
                Reader = COMM.ExecuteReader
                koneksi.Close()
            End If

            Dim baris As Integer
            Dim kolom As Integer
            Dim tingkat As Integer

            baris = 1
            kolom = 1
            tingkat = 1

            While True
                koneksi.Open()
                Dim stringQuery As New String("SELECT * FROM isi_parkiran WHERE baris = '" & baris & "' AND kolom = '" & kolom & "' AND tingkat = '" & tingkat & "'")
                Dim adapter2 As New MySqlDataAdapter(stringQuery, koneksi)
                koneksi.Close()
                Dim table2 As New DataTable
                adapter2.Fill(table2)
                If (table2.Rows.Count.Equals(0)) Then
                    koneksi.Open()
                    Query = "INSERT INTO isi_parkiran (baris,kolom,tingkat,plat_no,jam_masuk) values ('" & baris & "','" & kolom & "','" & tingkat & "','" & nopol.Text & "',NOW())"
                    COMM = New MySqlCommand(Query, koneksi)
                    Reader = COMM.ExecuteReader
                    koneksi.Close()

                    MessageBox.Show("Data tersimpan" & Environment.NewLine & "Tempat Parkir: " & Chr(baris + 64) & kolom & " Lantai " & tingkat & Environment.NewLine)
                    nopol.Text = ""
                    tipekendaraan.Text = ""

                    Exit While
                End If

                If (baris < 10) Then
                    baris = baris + 1
                Else
                    baris = 1
                    kolom = kolom + 1
                End If

                If (kolom < 10) Then
                Else
                    kolom = 1
                    tingkat = tingkat + 1
                End If

                If (tingkat < 10) Then
                Else
                    tingkat = 1
                End If
            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            koneksi.Dispose()
        End Try
    End Sub

    Private Sub TambahKendaraan()
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