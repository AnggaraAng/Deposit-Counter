Imports System.Data.OleDb
Public Class Form_pengambilan

    Sub Tampil()
        Call Connect()
        da = New OleDbDataAdapter("select * from tabel_penitipan", cn)
        ds = New DataSet
        da.Fill(ds, "Barang")
        Me.DataGridView1.DataSource = ds.Tables("Barang")
        Me.DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form_penitipan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        cmd = New OleDbCommand("select * from tabel_penitipan where no_penitip like '%" & Me.TextBox7.Text & "%'", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            da = New OleDbDataAdapter("select * from tabel_penitipan where no_penitip like '%" & Me.TextBox7.Text & "%'", cn)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            Me.DataGridView1.DataSource = ds.Tables("ketemu")
            Me.DataGridView1.ReadOnly = True

        Else
            MsgBox("data Tidak ditemukan")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_penitipan.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()


    End Sub
End Class