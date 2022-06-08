<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterData
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.perminresumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.resumerjToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumemedisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratResumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuratPermohonanResumeMedisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratPelepasanInformasiRekamMedisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.SuratResumeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(521, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasienToolStripMenuItem, Me.DokterToolStripMenuItem, Me.perminresumeToolStripMenuItem, Me.resumerjToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.PasienToolStripMenuItem.Text = "Data Pasien"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.DokterToolStripMenuItem.Text = "Data Dokter"
        '
        'perminresumeToolStripMenuItem
        '
        Me.perminresumeToolStripMenuItem.Name = "perminresumeToolStripMenuItem"
        Me.perminresumeToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.perminresumeToolStripMenuItem.Text = "Data Permintaan Resume"
        '
        'resumerjToolStripMenuItem
        '
        Me.resumerjToolStripMenuItem.Name = "resumerjToolStripMenuItem"
        Me.resumerjToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.resumerjToolStripMenuItem.Text = "Data Resume Medis Rawat Jalan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumemedisToolStripMenuItem, Me.LaporanDataPasienToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.TransaksiToolStripMenuItem.Text = "Laporan"
        '
        'ResumemedisToolStripMenuItem
        '
        Me.ResumemedisToolStripMenuItem.Name = "ResumemedisToolStripMenuItem"
        Me.ResumemedisToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ResumemedisToolStripMenuItem.Text = "Laporan Resume Medis"
        '
        'LaporanDataPasienToolStripMenuItem
        '
        Me.LaporanDataPasienToolStripMenuItem.Name = "LaporanDataPasienToolStripMenuItem"
        Me.LaporanDataPasienToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.LaporanDataPasienToolStripMenuItem.Text = "Laporan Data Pasien"
        '
        'SuratResumeToolStripMenuItem
        '
        Me.SuratResumeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuratPermohonanResumeMedisToolStripMenuItem, Me.SuratPelepasanInformasiRekamMedisToolStripMenuItem})
        Me.SuratResumeToolStripMenuItem.Name = "SuratResumeToolStripMenuItem"
        Me.SuratResumeToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.SuratResumeToolStripMenuItem.Text = "Surat Resume"
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.Location = New System.Drawing.Point(217, 208)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(66, 24)
        Me.lbnama.TabIndex = 1
        Me.lbnama.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SISTEM RESUME MEDIS KLINIK UTAMA MEDIKA ANTAPANI"
        '
        'SuratPermohonanResumeMedisToolStripMenuItem
        '
        Me.SuratPermohonanResumeMedisToolStripMenuItem.Name = "SuratPermohonanResumeMedisToolStripMenuItem"
        Me.SuratPermohonanResumeMedisToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.SuratPermohonanResumeMedisToolStripMenuItem.Text = "Surat Permohonan Resume Medis"
        '
        'SuratPelepasanInformasiRekamMedisToolStripMenuItem
        '
        Me.SuratPelepasanInformasiRekamMedisToolStripMenuItem.Name = "SuratPelepasanInformasiRekamMedisToolStripMenuItem"
        Me.SuratPelepasanInformasiRekamMedisToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.SuratPelepasanInformasiRekamMedisToolStripMenuItem.Text = "Surat Pelepasan Informasi Rekam Medis"
        '
        'FormMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 484)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbnama)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormMasterData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DokterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumemedisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents perminresumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents resumerjToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataPasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SuratResumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratPermohonanResumeMedisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratPelepasanInformasiRekamMedisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
