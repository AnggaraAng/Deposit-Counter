Imports System.Data.OleDb
Public Class Form_user


    Sub Tampil()
        Call Connect()
        da = New OleDbDataAdapter("select * from tabel_login", cn)
        ds = New DataSet
        da.Fill(ds, "Barang")
        Me.DataGridView1.DataSource = ds.Tables("Barang")
        Me.DataGridView1.ReadOnly = True
    End Sub
    Sub Kosongkan()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
    End Sub

    Private Sub Form_penitipan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampil()
        Kosongkan()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox4.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            Dim simpan As String = "insert into tabel_login values('" & Me.TextBox1.Text & _
            "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "')"
            cmd = New OleDbCommand(simpan, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil ditambah", MsgBoxStyle.Exclamation)
        End If
        Call Tampil()
        Call Kosongkan()

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.TextBox1.Text = DataGridView1.SelectedCells(0).Value
        Me.TextBox2.Text = DataGridView1.SelectedCells(1).Value
        Me.TextBox3.Text = DataGridView1.SelectedCells(2).Value
        Me.TextBox4.Text = DataGridView1.SelectedCells(3).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextBox1.Text = "" Then
            MessageBox.Show("Isi Kode Barang yang Mau Dihapus")
            Me.TextBox1.Focus()
            Exit Sub

        Else
            If MessageBox.Show("apakah anda yakin ingin menghapus data ini..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "delete from tabel_login where no_user='" & Me.TextBox1.Text & "'"
                cmd = New OleDbCommand(hapus, cn)
                cmd.ExecuteNonQuery()
                Call Tampil()
                Call Kosongkan()

            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Kosongkan()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()

    End Sub
End Class