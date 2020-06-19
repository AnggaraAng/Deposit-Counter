Imports System.Data.OleDb
Public Class Form_login


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Connect()
        cmd = New OleDbCommand("select * from tabel_login where username='" & Me.TextBox1.Text & _
                                    "' and '" & Me.TextBox2.Text & "'", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("login gagal")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        Else
            Me.Visible = False
            Form_menu.Show()
            Form_menu.panel1.Text = rd("akses")
            If Form_menu.panel1.Text = "control1" Then
                Form_menu.TambahUserToolStripMenuItem.Enabled = False
            ElseIf Form_menu.panel1.Text = "personnel head" Then
                Form_menu.UserToolStripMenuItem.Enabled = True
                End If
            End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class