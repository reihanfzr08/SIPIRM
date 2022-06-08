<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDokter
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
        Me.txtkddokter = New System.Windows.Forms.TextBox()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.lbjumlah = New System.Windows.Forms.Label()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbspesialis = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Dokter :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Dokter :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nomor Telepon :"
        '
        'txtkddokter
        '
        Me.txtkddokter.Location = New System.Drawing.Point(187, 65)
        Me.txtkddokter.Name = "txtkddokter"
        Me.txtkddokter.Size = New System.Drawing.Size(195, 29)
        Me.txtkddokter.TabIndex = 4
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Location = New System.Drawing.Point(187, 115)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(195, 29)
        Me.txtnamadokter.TabIndex = 5
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(187, 259)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(195, 29)
        Me.txtnotelp.TabIndex = 6
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(57, 385)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(83, 32)
        Me.btsave.TabIndex = 7
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(165, 385)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(83, 32)
        Me.btupdate.TabIndex = 8
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(274, 385)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(83, 32)
        Me.btdelete.TabIndex = 9
        Me.btdelete.Text = "Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(381, 385)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(83, 32)
        Me.btclose.TabIndex = 10
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 550)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(622, 199)
        Me.DataGridView1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "cari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jumlah Data :"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(125, 445)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(195, 29)
        Me.txtcari.TabIndex = 14
        '
        'lbjumlah
        '
        Me.lbjumlah.AutoSize = True
        Me.lbjumlah.Location = New System.Drawing.Point(525, 450)
        Me.lbjumlah.Name = "lbjumlah"
        Me.lbjumlah.Size = New System.Drawing.Size(20, 24)
        Me.lbjumlah.TabIndex = 15
        Me.lbjumlah.Text = "0"
        '
        'dtbirth
        '
        Me.dtbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbirth.Location = New System.Drawing.Point(187, 160)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(200, 29)
        Me.dtbirth.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tanggal Lahir :"
        '
        'cbspesialis
        '
        Me.cbspesialis.FormattingEnabled = True
        Me.cbspesialis.Items.AddRange(New Object() {"Spesialis Umum", "Spesialis Anak", "Spesialis Kandungan", "Spesialis Bedah", "Spesialis THT", "Spesialis Organ Dalam"})
        Me.cbspesialis.Location = New System.Drawing.Point(187, 204)
        Me.cbspesialis.Name = "cbspesialis"
        Me.cbspesialis.Size = New System.Drawing.Size(200, 32)
        Me.cbspesialis.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Spesialis :"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(187, 304)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(254, 63)
        Me.txtalamat.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Alamat :"
        '
        'FormDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 749)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbspesialis)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtbirth)
        Me.Controls.Add(Me.lbjumlah)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.txtnamadokter)
        Me.Controls.Add(Me.txtkddokter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormDokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkddokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnamadokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents lbjumlah As System.Windows.Forms.Label
    Friend WithEvents dtbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbspesialis As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
