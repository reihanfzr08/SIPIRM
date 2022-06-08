<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSuratPerminresume
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSuratPerminresume))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dttgl = New System.Windows.Forms.DateTimePicker()
        Me.bttampil1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.dtsamtgl = New System.Windows.Forms.DateTimePicker()
        Me.dttglke = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bttampil3 = New System.Windows.Forms.Button()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnorm = New System.Windows.Forms.TextBox()
        Me.bttampil2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtkeper = New System.Windows.Forms.TextBox()
        Me.bttampil5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtkddokter = New System.Windows.Forms.TextBox()
        Me.bttampil6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dttgl)
        Me.GroupBox5.Controls.Add(Me.bttampil1)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(174, 100)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(323, 227)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Surat Permohonan Resume Medis  Per Tanggal (Harian)"
        '
        'dttgl
        '
        Me.dttgl.Location = New System.Drawing.Point(29, 61)
        Me.dttgl.Name = "dttgl"
        Me.dttgl.Size = New System.Drawing.Size(200, 20)
        Me.dttgl.TabIndex = 17
        Me.dttgl.Value = New Date(2021, 10, 28, 0, 0, 0, 0)
        '
        'bttampil1
        '
        Me.bttampil1.Location = New System.Drawing.Point(90, 111)
        Me.bttampil1.Name = "bttampil1"
        Me.bttampil1.Size = New System.Drawing.Size(75, 23)
        Me.bttampil1.TabIndex = 18
        Me.bttampil1.Text = "Preview"
        Me.bttampil1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tanggal :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AxCrystalReport1)
        Me.GroupBox1.Controls.Add(Me.dtsamtgl)
        Me.GroupBox1.Controls.Add(Me.dttglke)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bttampil3)
        Me.GroupBox1.Controls.Add(Me.Tanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(529, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 231)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Surat Permohonan Resume Medis  Per Tanggal (Mingguan)"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(238, 154)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 17
        '
        'dtsamtgl
        '
        Me.dtsamtgl.Location = New System.Drawing.Point(111, 111)
        Me.dtsamtgl.Name = "dtsamtgl"
        Me.dtsamtgl.Size = New System.Drawing.Size(200, 20)
        Me.dtsamtgl.TabIndex = 16
        '
        'dttglke
        '
        Me.dttglke.Location = New System.Drawing.Point(111, 51)
        Me.dttglke.Name = "dttglke"
        Me.dttglke.Size = New System.Drawing.Size(200, 20)
        Me.dttglke.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sampai Tanggal :"
        '
        'bttampil3
        '
        Me.bttampil3.Location = New System.Drawing.Point(111, 169)
        Me.bttampil3.Name = "bttampil3"
        Me.bttampil3.Size = New System.Drawing.Size(75, 23)
        Me.bttampil3.TabIndex = 8
        Me.bttampil3.Text = "Preview"
        Me.bttampil3.UseVisualStyleBackColor = True
        '
        'Tanggal
        '
        Me.Tanggal.AutoSize = True
        Me.Tanggal.Location = New System.Drawing.Point(12, 57)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(90, 13)
        Me.Tanggal.TabIndex = 7
        Me.Tanggal.Text = "Dari Tanggal Ke :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnorm)
        Me.GroupBox2.Controls.Add(Me.bttampil2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 185)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Surat Permohonan Resume Medis  Per No.RM"
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(89, 73)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(140, 20)
        Me.txtnorm.TabIndex = 3
        '
        'bttampil2
        '
        Me.bttampil2.Location = New System.Drawing.Point(117, 122)
        Me.bttampil2.Name = "bttampil2"
        Me.bttampil2.Size = New System.Drawing.Size(75, 23)
        Me.bttampil2.TabIndex = 11
        Me.bttampil2.Text = "Preview"
        Me.bttampil2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Rekam Medis :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 567)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 567)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 567)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtkeper)
        Me.GroupBox3.Controls.Add(Me.bttampil5)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(365, 351)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 185)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " "
        '
        'txtkeper
        '
        Me.txtkeper.Location = New System.Drawing.Point(89, 73)
        Me.txtkeper.Name = "txtkeper"
        Me.txtkeper.Size = New System.Drawing.Size(140, 20)
        Me.txtkeper.TabIndex = 3
        '
        'bttampil5
        '
        Me.bttampil5.Location = New System.Drawing.Point(117, 122)
        Me.bttampil5.Name = "bttampil5"
        Me.bttampil5.Size = New System.Drawing.Size(75, 23)
        Me.bttampil5.TabIndex = 11
        Me.bttampil5.Text = "Preview"
        Me.bttampil5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Keperluan Pemohon :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtkddokter)
        Me.GroupBox4.Controls.Add(Me.bttampil6)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(703, 347)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 185)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Surat Permohonan Resume Medis  Per- Kode Dokter"
        '
        'txtkddokter
        '
        Me.txtkddokter.Location = New System.Drawing.Point(89, 73)
        Me.txtkddokter.Name = "txtkddokter"
        Me.txtkddokter.Size = New System.Drawing.Size(140, 20)
        Me.txtkddokter.TabIndex = 3
        '
        'bttampil6
        '
        Me.bttampil6.Location = New System.Drawing.Point(117, 122)
        Me.bttampil6.Name = "bttampil6"
        Me.bttampil6.Size = New System.Drawing.Size(75, 23)
        Me.bttampil6.TabIndex = 11
        Me.bttampil6.Text = "Preview"
        Me.bttampil6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kode Dokter :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(272, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(568, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "SURAT PERMOHONAN RESUME MEDIS KLINIK MEDIKA ANTAPANI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(362, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(373, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "*Cetak dan Lihat Surat yang telah dibuat berdasarkan Parameter"
        '
        'FormSuratPerminresume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 640)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "FormSuratPerminresume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLAPPerminresume"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dttgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttampil1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents dtsamtgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttglke As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bttampil3 As System.Windows.Forms.Button
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
    Friend WithEvents bttampil2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtkeper As System.Windows.Forms.TextBox
    Friend WithEvents bttampil5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtkddokter As System.Windows.Forms.TextBox
    Friend WithEvents bttampil6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
