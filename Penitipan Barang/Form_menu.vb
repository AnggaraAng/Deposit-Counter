Public Class Form_menu

    Private Sub PenitipanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenitipanToolStripMenuItem.Click
        Form_penitipan.Show()

    End Sub

    Private Sub PengambilanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengambilanToolStripMenuItem.Click
        Form_pengambilan.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("apakah anda yakin Akan Logout Dari Program?", vbYesNo) = vbYes Then
            End

        End If

    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahUserToolStripMenuItem.Click
        Form_user.Show()

    End Sub

    Private Sub PenitipanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenitipanToolStripMenuItem1.Click
        Form_laporan.Show()
    End Sub

    Private Sub PengambilanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengambilanToolStripMenuItem1.Click
        Form_laporan_pengambilan.Show()

    End Sub
End Class