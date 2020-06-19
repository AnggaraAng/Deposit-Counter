Imports System.Data.OleDb
Public Class Form_penitipan

    Sub Tampil()
        Call Connect()
        da = New OleDbDataAdapter("select * from tabel_penitipan", cn)
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
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox5.Text = TimeOfDay
    End Sub

    Private Sub Form_penitipan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampil()
        Kosongkan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox3.Text = "" Or Me.TextBox4.Text = " " Or Me.TextBox5.Text = " " Or Me.TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            Dim simpan As String = "insert into tabel_penitipan values('" & Me.TextBox1.Text & _
            "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & _
            "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "')"
            cmd = New OleDbCommand(simpan, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan", MsgBoxStyle.Exclamation)
        End If
        Call Tampil()
        Call Kosongkan()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim edit As String = "update tabel_penitipan set nama_penitip ='" & Me.TextBox2.Text & "',departement='" & Me.TextBox3.Text & "',nama_barang='" & Me.TextBox4.Text & "',jam_masuk='" & Me.TextBox5.Text & "',jam_keluar='" & Me.TextBox6.Text & "' where no_penitip='" & Me.TextBox1.Text & "'"
        cmd = New OleDbCommand(edit, cn)
        cmd.ExecuteNonQuery()
        MsgBox("data Berhasil di Perbaiki", MsgBoxStyle.Information)
        Tampil()
        Kosongkan()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.TextBox1.Text = DataGridView1.SelectedCells(0).Value
        Me.TextBox2.Text = DataGridView1.SelectedCells(1).Value
        Me.TextBox3.Text = DataGridView1.SelectedCells(2).Value
        Me.TextBox4.Text = DataGridView1.SelectedCells(3).Value
        Me.TextBox5.Text = DataGridView1.SelectedCells(4).Value
        Me.TextBox5.Text = DataGridView1.SelectedCells(5).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextBox1.Text = "" Then
            MessageBox.Show("Isi Kode Barang yang Mau Dihapus")
            Me.TextBox1.Focus()
            Exit Sub

        Else
            If MessageBox.Show("apakah anda yakin ingin menghapus data ini..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "delete from tabel_penitipan where no_penitip='" & Me.TextBox1.Text & "'"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class