<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLAPResumeMedis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLAPResumeMedis))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnorm = New System.Windows.Forms.TextBox()
        Me.txtdpjp = New System.Windows.Forms.TextBox()
        Me.txtdiag = New System.Windows.Forms.TextBox()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.bttampil = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.dtsamtgl = New System.Windows.Forms.DateTimePicker()
        Me.dttglke = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bttampil2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bttampil4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bttampil3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dttgl = New System.Windows.Forms.DateTimePicker()
        Me.bttampiltgl = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.bttampilbln = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbtahun = New System.Windows.Forms.ComboBox()
        Me.cbbulan = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DPJP :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diagnosis :"
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(89, 73)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(140, 20)
        Me.txtnorm.TabIndex = 3
        '
        'txtdpjp
        '
        Me.txtdpjp.Location = New System.Drawing.Point(89, 54)
        Me.txtdpjp.Name = "txtdpjp"
        Me.txtdpjp.Size = New System.Drawing.Size(140, 20)
        Me.txtdpjp.TabIndex = 4
        '
        'txtdiag
        '
        Me.txtdiag.Location = New System.Drawing.Point(111, 54)
        Me.txtdiag.Name = "txtdiag"
        Me.txtdiag.Size = New System.Drawing.Size(140, 20)
        Me.txtdiag.TabIndex = 5
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
        'bttampil
        '
        Me.bttampil.Location = New System.Drawing.Point(111, 169)
        Me.bttampil.Name = "bttampil"
        Me.bttampil.Size = New System.Drawing.Size(75, 23)
        Me.bttampil.TabIndex = 8
        Me.bttampil.Text = "Preview"
        Me.bttampil.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(482, 465)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(109, 42)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AxCrystalReport1)
        Me.GroupBox1.Controls.Add(Me.dtsamtgl)
        Me.GroupBox1.Controls.Add(Me.dttglke)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bttampil)
        Me.GroupBox1.Controls.Add(Me.Tanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 231)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Resume Per Tanggal (Mingguan)"
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
        'bttampil2
        '
        Me.bttampil2.Location = New System.Drawing.Point(117, 122)
        Me.bttampil2.Name = "bttampil2"
        Me.bttampil2.Size = New System.Drawing.Size(75, 23)
        Me.bttampil2.TabIndex = 11
        Me.bttampil2.Text = "Preview"
        Me.bttampil2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnorm)
        Me.GroupBox2.Controls.Add(Me.bttampil2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 185)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Resume Per No.RM"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bttampil4)
        Me.GroupBox4.Controls.Add(Me.txtdpjp)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(399, 283)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 137)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Resume Berdasarkan DPJP"
        '
        'bttampil4
        '
        Me.bttampil4.Location = New System.Drawing.Point(117, 96)
        Me.bttampil4.Name = "bttampil4"
        Me.bttampil4.Size = New System.Drawing.Size(75, 23)
        Me.bttampil4.TabIndex = 12
        Me.bttampil4.Text = "Preview"
        Me.bttampil4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bttampil3)
        Me.GroupBox3.Controls.Add(Me.txtdiag)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 137)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Resume Berdasarkan Diagnosis"
        '
        'bttampil3
        '
        Me.bttampil3.Location = New System.Drawing.Point(117, 96)
        Me.bttampil3.Name = "bttampil3"
        Me.bttampil3.Size = New System.Drawing.Size(75, 23)
        Me.bttampil3.TabIndex = 12
        Me.bttampil3.Text = "Preview"
        Me.bttampil3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(955, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(955, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
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
        'dttgl
        '
        Me.dttgl.Location = New System.Drawing.Point(29, 61)
        Me.dttgl.Name = "dttgl"
        Me.dttgl.Size = New System.Drawing.Size(200, 20)
        Me.dttgl.TabIndex = 17
        Me.dttgl.Value = New Date(2021, 10, 28, 0, 0, 0, 0)
        '
        'bttampiltgl
        '
        Me.bttampiltgl.Location = New System.Drawing.Point(29, 110)
        Me.bttampiltgl.Name = "bttampiltgl"
        Me.bttampiltgl.Size = New System.Drawing.Size(75, 23)
        Me.bttampiltgl.TabIndex = 18
        Me.bttampiltgl.Text = "Preview"
        Me.bttampiltgl.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dttgl)
        Me.GroupBox5.Controls.Add(Me.bttampiltgl)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(741, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(265, 176)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Laporan Resume Per Tanggal (Harian)"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.bttampilbln)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.cbtahun)
        Me.GroupBox6.Controls.Add(Me.cbbulan)
        Me.GroupBox6.Location = New System.Drawing.Point(741, 292)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(253, 149)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Laporan Resume Per-Bulan&Tahun"
        '
        'bttampilbln
        '
        Me.bttampilbln.Location = New System.Drawing.Point(108, 120)
        Me.bttampilbln.Name = "bttampilbln"
        Me.bttampilbln.Size = New System.Drawing.Size(75, 23)
        Me.bttampilbln.TabIndex = 13
        Me.bttampilbln.Text = "Preview"
        Me.bttampilbln.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tahun :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Bulan :"
        '
        'cbtahun
        '
        Me.cbtahun.FormattingEnabled = True
        Me.cbtahun.Location = New System.Drawing.Point(108, 79)
        Me.cbtahun.Name = "cbtahun"
        Me.cbtahun.Size = New System.Drawing.Size(121, 21)
        Me.cbtahun.TabIndex = 1
        '
        'cbbulan
        '
        Me.cbbulan.FormattingEnabled = True
        Me.cbbulan.Location = New System.Drawing.Point(108, 40)
        Me.cbbulan.Name = "cbbulan"
        Me.cbbulan.Size = New System.Drawing.Size(121, 21)
        Me.cbbulan.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(314, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(452, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "LAPORAN RESUME MEDIS KLINIK MEDIKA ANTAPANI"
        '
        'FormLAPResumeMedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 528)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnclose)
        Me.Name = "FormLAPResumeMedis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormResumeMedis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
    Friend WithEvents txtdpjp As System.Windows.Forms.TextBox
    Friend WithEvents txtdiag As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents bttampil As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bttampil2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents bttampil4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bttampil3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtsamtgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttglke As System.Windows.Forms.DateTimePicker
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dttgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttampiltgl As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents bttampilbln As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents cbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
