Imports MySql.Data.MySqlClient
Public Class FormUser
    Sub lihat_auth()
        cmd = New MySqlCommand("select*from tbuser", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub
    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lihat_auth()
    End Sub
    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbuser where Id_User=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtiduser.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data user ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbuser (Id_User,Username,Password,Jabatan)values(@Id_User,@Username,@Password,@Jabatan)", cn)
            cmd.Parameters.AddWithValue("@Id_User", txtiduser.Text)
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@Jabatan", txtjabatan.Text)
            cmd.ExecuteNonQuery()
            txtiduser.Clear()
            txtusername.Clear()
            txtpassword.Clear()
            txtjabatan.Clear()
            MsgBox("Data User Berhasil Disimpan !", vbOKOnly + vbInformation, "sukses")
        End If
        lihat_auth()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtiduser.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtusername.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtpassword.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtjabatan.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        btsave.Enabled = False
        txtiduser.Enabled = False
        txtusername.Focus()

    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbuser set Username=@Username,Password=@Password,Jabatan=@Jabatan where Id_User=@Id_User ", cn)
        cmd.Parameters.AddWithValue("@Id_User", txtiduser.Text)
        cmd.Parameters.AddWithValue("@Username", txtusername.Text)
        cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
        cmd.Parameters.AddWithValue("@Jabatan", txtjabatan.Text)
        cmd.ExecuteNonQuery()
        lihat_auth()
        txtiduser.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtjabatan.Clear()
        txtiduser.Enabled = True
        btsave.Enabled = True
        MsgBox("Data User Berhasil di update !", vbOKOnly + vbInformation, "sukses")

    End Sub
    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbuser where Id_User=@Id_User", cn)
        cmd.Parameters.AddWithValue("@Id_User", txtiduser.Text)
        cmd.ExecuteNonQuery()
        lihat_auth()
        txtiduser.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtjabatan.Clear()
        txtiduser.Enabled = True
        btsave.Enabled = True
        MsgBox("Data User Berhasil Dihapuss !", vbOKOnly + vbInformation, "sukses duniawi entushiast")
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            lihat_auth()
        Else
            cmd = New MySqlCommand("select*from tbuser where Id_User like @Id_User or Username like @Username or Jabatan like @Jabatan limit 10", cn)
            cmd.Parameters.AddWithValue("@Id_User", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Username", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Jabatan", txtcari.Text & "%")
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(cmd)
            tb = New DataTable
            da.Fill(tb)
            DataGridView1.DataSource = tb
            lbjumlah.text = DataGridView1.RowCount - 1
        End If
    End Sub
    Private Sub lbjumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbjumlah.Click

    End Sub


    Private Sub bttutup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttutup.Click
        Close()
    End Sub
End Class