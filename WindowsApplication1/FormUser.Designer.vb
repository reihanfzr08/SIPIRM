<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbjumlah = New System.Windows.Forms.Label()
        Me.txtiduser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jabatan :"
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(62, 319)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 31)
        Me.btsave.TabIndex = 5
        Me.btsave.Text = "save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(160, 319)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(95, 31)
        Me.btupdate.TabIndex = 6
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(197, 130)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(194, 29)
        Me.txtusername.TabIndex = 8
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(197, 188)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(194, 29)
        Me.txtpassword.TabIndex = 9
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(197, 247)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(194, 29)
        Me.txtjabatan.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 469)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(521, 125)
        Me.DataGridView1.TabIndex = 12
        '
        'bttutup
        '
        Me.bttutup.Location = New System.Drawing.Point(391, 319)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(95, 31)
        Me.bttutup.TabIndex = 13
        Me.bttutup.Text = "Close"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(273, 319)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(95, 31)
        Me.btdelete.TabIndex = 14
        Me.btdelete.Text = "delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(197, 370)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(194, 29)
        Me.txtcari.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cari :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Jumlah Data :"
        '
        'lbjumlah
        '
        Me.lbjumlah.AutoSize = True
        Me.lbjumlah.Location = New System.Drawing.Point(235, 425)
        Me.lbjumlah.Name = "lbjumlah"
        Me.lbjumlah.Size = New System.Drawing.Size(20, 24)
        Me.lbjumlah.TabIndex = 18
        Me.lbjumlah.Text = "0"
        '
        'txtiduser
        '
        Me.txtiduser.Location = New System.Drawing.Point(197, 82)
        Me.txtiduser.Name = "txtiduser"
        Me.txtiduser.Size = New System.Drawing.Size(194, 29)
        Me.txtiduser.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ID_User"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(521, 594)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtiduser)
        Me.Controls.Add(Me.lbjumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbjumlah As System.Windows.Forms.Label
    Friend WithEvents txtiduser As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
