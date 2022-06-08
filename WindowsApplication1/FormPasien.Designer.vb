<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPasien
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
        Me.btsave = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.txtnorm = New System.Windows.Forms.TextBox()
        Me.txtnoktp = New System.Windows.Forms.TextBox()
        Me.cbjeniskel = New System.Windows.Forms.ComboBox()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbjumlah = New System.Windows.Forms.Label()
        Me.txtnamalengkap = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.txtpekerjaan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtpolik = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dttgmsk = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dttgkl = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtkddokter = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtnamdok = New System.Windows.Forms.TextBox()
        Me.Labeldok = New System.Windows.Forms.Label()
        Me.txtspesialis = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PASIEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO RM   :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NO KTP  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir :"
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(28, 289)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(93, 42)
        Me.btsave.TabIndex = 4
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(395, 289)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(102, 42)
        Me.btclose.TabIndex = 5
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(200, 73)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(181, 29)
        Me.txtnorm.TabIndex = 6
        '
        'txtnoktp
        '
        Me.txtnoktp.Location = New System.Drawing.Point(200, 108)
        Me.txtnoktp.Name = "txtnoktp"
        Me.txtnoktp.Size = New System.Drawing.Size(181, 29)
        Me.txtnoktp.TabIndex = 7
        '
        'cbjeniskel
        '
        Me.cbjeniskel.FormattingEnabled = True
        Me.cbjeniskel.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        Me.cbjeniskel.Location = New System.Drawing.Point(200, 178)
        Me.cbjeniskel.Name = "cbjeniskel"
        Me.cbjeniskel.Size = New System.Drawing.Size(200, 32)
        Me.cbjeniskel.TabIndex = 8
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(146, 289)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(93, 42)
        Me.btupdate.TabIndex = 9
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(269, 289)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(93, 42)
        Me.btdelete.TabIndex = 10
        Me.btdelete.Text = "Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 463)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1159, 248)
        Me.DataGridView1.TabIndex = 11
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(219, 375)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(181, 29)
        Me.txtcari.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jumlah Data :"
        '
        'lbjumlah
        '
        Me.lbjumlah.AutoSize = True
        Me.lbjumlah.Location = New System.Drawing.Point(380, 422)
        Me.lbjumlah.Name = "lbjumlah"
        Me.lbjumlah.Size = New System.Drawing.Size(20, 24)
        Me.lbjumlah.TabIndex = 15
        Me.lbjumlah.Text = "0"
        '
        'txtnamalengkap
        '
        Me.txtnamalengkap.Location = New System.Drawing.Point(200, 143)
        Me.txtnamalengkap.Name = "txtnamalengkap"
        Me.txtnamalengkap.Size = New System.Drawing.Size(181, 29)
        Me.txtnamalengkap.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Jenis Kelamin  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nama Lengkap :"
        '
        'dtbirth
        '
        Me.dtbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbirth.Location = New System.Drawing.Point(200, 216)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(200, 29)
        Me.dtbirth.TabIndex = 20
        '
        'txtpekerjaan
        '
        Me.txtpekerjaan.Location = New System.Drawing.Point(598, 178)
        Me.txtpekerjaan.Name = "txtpekerjaan"
        Me.txtpekerjaan.Size = New System.Drawing.Size(181, 29)
        Me.txtpekerjaan.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(436, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Pekerjaan :"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(598, 143)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(181, 29)
        Me.txtalamat.TabIndex = 24
        '
        'txtpolik
        '
        Me.txtpolik.Location = New System.Drawing.Point(598, 108)
        Me.txtpolik.Name = "txtpolik"
        Me.txtpolik.Size = New System.Drawing.Size(181, 29)
        Me.txtpolik.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(436, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 24)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Alamat :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 24)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Poliklinik :"
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(598, 216)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(181, 29)
        Me.txtnotelp.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 24)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "No Telepon :"
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(598, 68)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(181, 29)
        Me.txtumur.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 24)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Umur"
        '
        'dttgmsk
        '
        Me.dttgmsk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttgmsk.Location = New System.Drawing.Point(695, 375)
        Me.dttgmsk.Name = "dttgmsk"
        Me.dttgmsk.Size = New System.Drawing.Size(200, 29)
        Me.dttgmsk.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(533, 375)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 24)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Tanggal Masuk :"
        '
        'dttgkl
        '
        Me.dttgkl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttgkl.Location = New System.Drawing.Point(695, 410)
        Me.dttgkl.Name = "dttgkl"
        Me.dttgkl.Size = New System.Drawing.Size(200, 29)
        Me.dttgkl.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(533, 410)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 24)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Tanggal Keluar :"
        '
        'txtkddokter
        '
        Me.txtkddokter.Location = New System.Drawing.Point(695, 265)
        Me.txtkddokter.Name = "txtkddokter"
        Me.txtkddokter.Size = New System.Drawing.Size(181, 29)
        Me.txtkddokter.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(533, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 24)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Kode Dokter :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(533, 305)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 24)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Nama Dokter :"
        '
        'txtnamdok
        '
        Me.txtnamdok.Location = New System.Drawing.Point(695, 302)
        Me.txtnamdok.Name = "txtnamdok"
        Me.txtnamdok.Size = New System.Drawing.Size(181, 29)
        Me.txtnamdok.TabIndex = 37
        '
        'Labeldok
        '
        Me.Labeldok.AutoSize = True
        Me.Labeldok.Location = New System.Drawing.Point(533, 340)
        Me.Labeldok.Name = "Labeldok"
        Me.Labeldok.Size = New System.Drawing.Size(94, 24)
        Me.Labeldok.TabIndex = 40
        Me.Labeldok.Text = "Spesialis :"
        '
        'txtspesialis
        '
        Me.txtspesialis.Location = New System.Drawing.Point(695, 337)
        Me.txtspesialis.Name = "txtspesialis"
        Me.txtspesialis.Size = New System.Drawing.Size(181, 29)
        Me.txtspesialis.TabIndex = 39
        '
        'FormPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1159, 711)
        Me.Controls.Add(Me.Labeldok)
        Me.Controls.Add(Me.txtspesialis)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtnamdok)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtkddokter)
        Me.Controls.Add(Me.dttgkl)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dttgmsk)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtumur)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpekerjaan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtpolik)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtbirth)
        Me.Controls.Add(Me.txtnamalengkap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbjumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.cbjeniskel)
        Me.Controls.Add(Me.txtnoktp)
        Me.Controls.Add(Me.txtnorm)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
    Friend WithEvents txtnoktp As System.Windows.Forms.TextBox
    Friend WithEvents cbjeniskel As System.Windows.Forms.ComboBox
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbjumlah As System.Windows.Forms.Label
    Friend WithEvents txtnamalengkap As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtpolik As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dttgmsk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dttgkl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtkddokter As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtnamdok As System.Windows.Forms.TextBox
    Friend WithEvents Labeldok As System.Windows.Forms.Label
    Friend WithEvents txtspesialis As System.Windows.Forms.TextBox

End Class
