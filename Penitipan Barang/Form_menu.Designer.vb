<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenitipanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambilanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenitipanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambilanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.StatusStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.MasterToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Mirage Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(61, 31)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(187, 32)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenitipanToolStripMenuItem, Me.PengambilanToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Mirage Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(78, 31)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PenitipanToolStripMenuItem
        '
        Me.PenitipanToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PenitipanToolStripMenuItem.Name = "PenitipanToolStripMenuItem"
        Me.PenitipanToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.PenitipanToolStripMenuItem.Text = "Penitipan"
        '
        'PengambilanToolStripMenuItem
        '
        Me.PengambilanToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PengambilanToolStripMenuItem.Name = "PengambilanToolStripMenuItem"
        Me.PengambilanToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.PengambilanToolStripMenuItem.Text = "Pengambilan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenitipanToolStripMenuItem1, Me.PengambilanToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Mirage Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(87, 31)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PenitipanToolStripMenuItem1
        '
        Me.PenitipanToolStripMenuItem1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PenitipanToolStripMenuItem1.Name = "PenitipanToolStripMenuItem1"
        Me.PenitipanToolStripMenuItem1.Size = New System.Drawing.Size(178, 32)
        Me.PenitipanToolStripMenuItem1.Text = "Penitipan"
        '
        'PengambilanToolStripMenuItem1
        '
        Me.PengambilanToolStripMenuItem1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PengambilanToolStripMenuItem1.Name = "PengambilanToolStripMenuItem1"
        Me.PengambilanToolStripMenuItem1.Size = New System.Drawing.Size(178, 32)
        Me.PengambilanToolStripMenuItem1.Text = "Pengambilan"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Mirage Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(75, 31)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1067, 619)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 25)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "PT. Trans Retail Indonesia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(1094, 644)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 24)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "Carrefour Palembang Square"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(1108, 668)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 22)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "JL. Angkatan 45 No.1 Palembang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(802, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(547, 28)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = """Selamat Datang di Program Aplikasi Penitipan Barang"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(1234, 716)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 25)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Anggi Anggara"
        '
        'panel1
        '
        Me.panel1.Location = New System.Drawing.Point(0, 728)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1370, 22)
        Me.panel1.TabIndex = 215
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Penitipan_Barang.My.Resources.Resources.penitipanbarang
        Me.PictureBox1.Location = New System.Drawing.Point(1056, 427)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 209
        Me.PictureBox1.TabStop = False
        '
        'Form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenitipanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengambilanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TambahUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenitipanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengambilanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
