<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPermintaanResume
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtnampem = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtnampas = New System.Windows.Forms.TextBox()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtkeper = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbjumlah = New System.Windows.Forms.Label()
        Me.txtpasien = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtjekel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpolik = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dttgmsk = New System.Windows.Forms.DateTimePicker()
        Me.dttgkl = New System.Windows.Forms.DateTimePicker()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.txtnorm = New System.Windows.Forms.TextBox()
        Me.txtkddokter = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No RM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pemohon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat Pasien"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor Telepon Pasien"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Pasien"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Keperluan"
        '
        'dttanggal
        '
        Me.dttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttanggal.Location = New System.Drawing.Point(121, 51)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(200, 20)
        Me.dttanggal.TabIndex = 8
        '
        'txtnampem
        '
        Me.txtnampem.Location = New System.Drawing.Point(121, 238)
        Me.txtnampem.Name = "txtnampem"
        Me.txtnampem.Size = New System.Drawing.Size(200, 20)
        Me.txtnampem.TabIndex = 9
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(121, 146)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(200, 54)
        Me.txtalamat.TabIndex = 10
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(148, 212)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(173, 20)
        Me.txtnotelp.TabIndex = 11
        '
        'txtnampas
        '
        Me.txtnampas.Location = New System.Drawing.Point(121, 108)
        Me.txtnampas.Name = "txtnampas"
        Me.txtnampas.Size = New System.Drawing.Size(200, 20)
        Me.txtnampas.TabIndex = 12
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(286, 319)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 23)
        Me.btclose.TabIndex = 32
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(204, 319)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 23)
        Me.btdelete.TabIndex = 31
        Me.btdelete.Text = "Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(125, 319)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(75, 23)
        Me.btupdate.TabIndex = 29
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(47, 319)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 23)
        Me.btsave.TabIndex = 28
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(258, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "SURAT PERMOHONAN PERMINTAAN RESUME MEDIS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 371)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(894, 150)
        Me.DataGridView1.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Cari :"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(497, 322)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(190, 20)
        Me.txtcari.TabIndex = 36
        '
        'txtkeper
        '
        Me.txtkeper.Location = New System.Drawing.Point(121, 275)
        Me.txtkeper.Name = "txtkeper"
        Me.txtkeper.Size = New System.Drawing.Size(200, 20)
        Me.txtkeper.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(725, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Jumlah Data :"
        '
        'lbjumlah
        '
        Me.lbjumlah.AutoSize = True
        Me.lbjumlah.Location = New System.Drawing.Point(829, 329)
        Me.lbjumlah.Name = "lbjumlah"
        Me.lbjumlah.Size = New System.Drawing.Size(13, 13)
        Me.lbjumlah.TabIndex = 39
        Me.lbjumlah.Text = "0"
        '
        'txtpasien
        '
        Me.txtpasien.Location = New System.Drawing.Point(121, 244)
        Me.txtpasien.Name = "txtpasien"
        Me.txtpasien.Size = New System.Drawing.Size(200, 20)
        Me.txtpasien.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(373, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Jenis Kelamin Pasien"
        '
        'txtjekel
        '
        Me.txtjekel.Location = New System.Drawing.Point(497, 53)
        Me.txtjekel.Name = "txtjekel"
        Me.txtjekel.Size = New System.Drawing.Size(211, 20)
        Me.txtjekel.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(373, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Tanggal Lahir Pasien"
        '
        'txtpolik
        '
        Me.txtpolik.Location = New System.Drawing.Point(497, 132)
        Me.txtpolik.Name = "txtpolik"
        Me.txtpolik.Size = New System.Drawing.Size(211, 20)
        Me.txtpolik.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(373, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Poliklinik"
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(497, 164)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(211, 20)
        Me.txtumur.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(373, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Umur"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(373, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Tanggal Masuk Pasien"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(373, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Tanggal Keluar Pasien"
        '
        'dttgmsk
        '
        Me.dttgmsk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttgmsk.Location = New System.Drawing.Point(497, 193)
        Me.dttgmsk.Name = "dttgmsk"
        Me.dttgmsk.Size = New System.Drawing.Size(200, 20)
        Me.dttgmsk.TabIndex = 54
        '
        'dttgkl
        '
        Me.dttgkl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttgkl.Location = New System.Drawing.Point(495, 224)
        Me.dttgkl.Name = "dttgkl"
        Me.dttgkl.Size = New System.Drawing.Size(200, 20)
        Me.dttgkl.TabIndex = 55
        '
        'dtbirth
        '
        Me.dtbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbirth.Location = New System.Drawing.Point(497, 94)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(200, 20)
        Me.dtbirth.TabIndex = 56
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(121, 82)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(200, 20)
        Me.txtnorm.TabIndex = 57
        '
        'txtkddokter
        '
        Me.txtkddokter.Location = New System.Drawing.Point(497, 264)
        Me.txtkddokter.Name = "txtkddokter"
        Me.txtkddokter.Size = New System.Drawing.Size(162, 20)
        Me.txtkddokter.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(373, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Kode Dokter"
        '
        'FormPermintaanResume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 521)
        Me.Controls.Add(Me.txtkddokter)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtnorm)
        Me.Controls.Add(Me.dtbirth)
        Me.Controls.Add(Me.dttgkl)
        Me.Controls.Add(Me.dttgmsk)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtumur)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtpolik)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtjekel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbjumlah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtkeper)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.txtnampas)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnampem)
        Me.Controls.Add(Me.dttanggal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPermintaanResume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPermintaanResume"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnampem As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents txtnampas As System.Windows.Forms.TextBox
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtkeper As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbjumlah As System.Windows.Forms.Label
    Friend WithEvents cbnorm As System.Windows.Forms.ComboBox
    Friend WithEvents txtpasien As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtjekel As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpolik As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dttgmsk As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttgkl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
    Friend WithEvents txtkddokter As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
