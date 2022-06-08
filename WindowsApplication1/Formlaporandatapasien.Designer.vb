<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlaporandatapasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formlaporandatapasien))
        Me.btntmpil1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dttglklr = New System.Windows.Forms.DateTimePicker()
        Me.btntmpil2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dttglmsk = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btntmpil3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnorm = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btntmpil4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkddokter = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btntmpil5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtjekel = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btntmpil6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpolik = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntmpil1
        '
        Me.btntmpil1.Location = New System.Drawing.Point(118, 102)
        Me.btntmpil1.Name = "btntmpil1"
        Me.btntmpil1.Size = New System.Drawing.Size(75, 23)
        Me.btntmpil1.TabIndex = 0
        Me.btntmpil1.Text = "Preview"
        Me.btntmpil1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dttglklr)
        Me.GroupBox1.Controls.Add(Me.btntmpil2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dttglmsk)
        Me.GroupBox1.Controls.Add(Me.btntmpil1)
        Me.GroupBox1.Location = New System.Drawing.Point(189, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 289)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Data Pasien PerTanggal Masuk dan Keluar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal Keluar :"
        '
        'dttglklr
        '
        Me.dttglklr.Location = New System.Drawing.Point(107, 172)
        Me.dttglklr.Name = "dttglklr"
        Me.dttglklr.Size = New System.Drawing.Size(200, 20)
        Me.dttglklr.TabIndex = 4
        Me.dttglklr.Value = New Date(2021, 10, 28, 0, 0, 0, 0)
        '
        'btntmpil2
        '
        Me.btntmpil2.Location = New System.Drawing.Point(118, 220)
        Me.btntmpil2.Name = "btntmpil2"
        Me.btntmpil2.Size = New System.Drawing.Size(75, 23)
        Me.btntmpil2.TabIndex = 3
        Me.btntmpil2.Text = "Preview"
        Me.btntmpil2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal Masuk :"
        '
        'dttglmsk
        '
        Me.dttglmsk.Location = New System.Drawing.Point(107, 54)
        Me.dttglmsk.Name = "dttglmsk"
        Me.dttglmsk.Size = New System.Drawing.Size(200, 20)
        Me.dttglmsk.TabIndex = 1
        Me.dttglmsk.Value = New Date(2021, 10, 28, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btntmpil3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtnorm)
        Me.GroupBox2.Location = New System.Drawing.Point(568, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 171)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Data Pasien per- No. Rekam Medis"
        '
        'btntmpil3
        '
        Me.btntmpil3.Location = New System.Drawing.Point(108, 120)
        Me.btntmpil3.Name = "btntmpil3"
        Me.btntmpil3.Size = New System.Drawing.Size(75, 23)
        Me.btntmpil3.TabIndex = 6
        Me.btntmpil3.Text = "Preview"
        Me.btntmpil3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. Rekam medis"
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(108, 80)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(100, 20)
        Me.txtnorm.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btntmpil4)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtkddokter)
        Me.GroupBox3.Location = New System.Drawing.Point(202, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 171)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Data Pasien per- Kode Dokter"
        '
        'btntmpil4
        '
        Me.btntmpil4.Location = New System.Drawing.Point(108, 120)
        Me.btntmpil4.Name = "btntmpil4"
        Me.btntmpil4.Size = New System.Drawing.Size(75, 23)
        Me.btntmpil4.TabIndex = 6
        Me.btntmpil4.Text = "Preview"
        Me.btntmpil4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kode Dokter"
        '
        'txtkddokter
        '
        Me.txtkddokter.Location = New System.Drawing.Point(108, 80)
        Me.txtkddokter.Name = "txtkddokter"
        Me.txtkddokter.Size = New System.Drawing.Size(100, 20)
        Me.txtkddokter.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btntmpil5)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtjekel)
        Me.GroupBox4.Location = New System.Drawing.Point(568, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 171)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Data Pasien per- Jenis Kelamin"
        '
        'btntmpil5
        '
        Me.btntmpil5.Location = New System.Drawing.Point(108, 120)
        Me.btntmpil5.Name = "btntmpil5"
        Me.btntmpil5.Size = New System.Drawing.Size(75, 23)
        Me.btntmpil5.TabIndex = 6
        Me.btntmpil5.Text = "Preview"
        Me.btntmpil5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jenis Kelamin"
        '
        'txtjekel
        '
        Me.txtjekel.Location = New System.Drawing.Point(108, 80)
        Me.txtjekel.Name = "txtjekel"
        Me.txtjekel.Size = New System.Drawing.Size(100, 20)
        Me.txtjekel.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btntmpil6)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtpolik)
        Me.GroupBox5.Location = New System.Drawing.Point(568, 464)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(294, 171)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Laporan Data Pasien per- Poliklinik"
        '
        'btntmpil6
        '
        Me.btntmpil6.Location = New System.Drawing.Point(108, 120)
        Me.btntmpil6.Name = "btntmpil6"
        Me.btntmpil6.Size = New System.Drawing.Size(75, 23)
        Me.btntmpil6.TabIndex = 6
        Me.btntmpil6.Text = "Preview"
        Me.btntmpil6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Poliklinik"
        '
        'txtpolik
        '
        Me.txtpolik.Location = New System.Drawing.Point(108, 80)
        Me.txtpolik.Name = "txtpolik"
        Me.txtpolik.Size = New System.Drawing.Size(100, 20)
        Me.txtpolik.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(440, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "LAPORAN DATA PASIEN KLINIK MEDIKA ANTAPANI"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(921, 39)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(104, 50)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Close"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(938, 257)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 11
        '
        'Formlaporandatapasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 659)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Formlaporandatapasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formlaporan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btntmpil1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dttglklr As System.Windows.Forms.DateTimePicker
    Friend WithEvents btntmpil2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dttglmsk As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btntmpil3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btntmpil4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkddokter As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btntmpil5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtjekel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btntmpil6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpolik As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
