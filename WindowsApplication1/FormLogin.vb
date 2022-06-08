Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub lihat_auth()
        cmd = New MySqlCommand("select*from tbuser", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
    End Sub
    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        cmd = New MySqlCommand("select*from tbuser where Username=@Username and Password=@Password", cn)
        cmd.Parameters.AddWithValue("@Username", txtusername.Text)
        cmd.Parameters.AddWithValue("@Password", txtpassword.Text)

        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Login Berhasil !")
            Close()
            FormMasterData.aktif()
            FormMasterData.lbnama.Text = "Selamat Datang_" & dr.Item(1)
            dr.Close()
        Else
            MsgBox("Login Gagal !")
            dr.Close()
        End If
        lihat_auth()

    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Close()

    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lihat_auth()
    End Sub
End Class