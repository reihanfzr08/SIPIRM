Imports MySql.Data.MySqlClient
Public Class FormPasien
    Sub lihat_pasien()
        cmd = New MySqlCommand("select*from tbpasien", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Private Sub FormPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lihat_pasien()
        dtbirth.Format = DateTimePickerFormat.Custom
        dtbirth.CustomFormat = "yyyy/MM/dd"
        dttgmsk.Format = DateTimePickerFormat.Custom
        dttgmsk.CustomFormat = "yyyy/MM/dd"
        dttgkl.Format = DateTimePickerFormat.Custom
        dttgkl.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub txtnotelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnoktp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnoktp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtumur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtumur.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnorm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnorm.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtkddokter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkddokter.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New MySqlCommand("select*from tbdokter where Kode_Dokter=@Kode_Dokter", cn)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txtnamdok.Text = dr.Item(1)
                txtspesialis.Text = dr.Item("Spesialis")
                dr.Close()
            Else
                dr.Close()
                MsgBox("data tidak ditemukan!!", vbOKOnly + vbCritical, "eror")
            End If
        End If
    End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbpasien where No_RM=@a and Kode_Dokter=@Kode_Dokter", cn)
        cmd.Parameters.AddWithValue("@a", txtnorm.Text)
        cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data pasien ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbpasien values(@No_RM,@No_KTP,@Nama,@Jenis_Kelamin,@Tanggal_Lahir,@Umur,@Poliklinik,@Alamat,@Pekerjaan,@No_Telepon,@Tanggal_Masuk,@Tanggal_Keluar,@Kode_Dokter,@Nama_Dokter,@Spesialis)", cn)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            cmd.Parameters.AddWithValue("@No_KTP", txtnoktp.Text)
            cmd.Parameters.AddWithValue("@Nama", txtnamalengkap.Text)
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", cbjeniskel.SelectedItem)
            cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtbirth.Text)
            cmd.Parameters.AddWithValue("@Umur", txtumur.Text)
            cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
            cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@Pekerjaan", txtpekerjaan.Text)
            cmd.Parameters.AddWithValue("@No_Telepon", txtnotelp.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Masuk", dttgmsk.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Keluar", dttgkl.Text)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
            cmd.Parameters.AddWithValue("@Nama_Dokter", txtnamdok.Text)
            cmd.Parameters.AddWithValue("@Spesialis", txtspesialis.Text)
            cmd.ExecuteNonQuery()
            txtnorm.Clear()
            txtnoktp.Clear()
            txtnamalengkap.Clear()
            cbjeniskel.SelectedIndex = -1
            dtbirth.Text = ""
            txtumur.Clear()
            txtpolik.Clear()
            txtalamat.Clear()
            txtpekerjaan.Clear()
            txtnotelp.Clear()
            dttgmsk.Text = ""
            dttgkl.Text = ""
            txtkddokter.Clear()
            txtnamdok.Clear()
            txtspesialis.Clear()
            MsgBox("Data Pasien Berhasil Disimpan!", vbOKOnly + vbInformation, "sukses")
        End If
        lihat_pasien()
    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtnorm.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtnoktp.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtnamalengkap.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        cbjeniskel.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        dtbirth.Text = DataGridView1.CurrentRow.Cells(4).Value.date
        txtumur.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtpolik.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtalamat.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtpekerjaan.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        txtnotelp.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        dttgmsk.Text = DataGridView1.CurrentRow.Cells(10).Value.date
        dttgkl.Text = DataGridView1.CurrentRow.Cells(11).Value.date
        txtkddokter.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        txtnamdok.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        txtspesialis.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        btsave.Enabled = False
        txtnorm.Enabled = False
        txtnoktp.Focus()
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbpasien set No_KTP=@No_KTP, Nama=@Nama, Jenis_Kelamin=@Jenis_Kelamin, Tanggal_Lahir=@Tanggal_Lahir, Umur=@Umur, Poliklinik=@Poliklinik, Alamat=@Alamat, Pekerjaan=@Pekerjaan, No_Telepon=@No_Telepon, Tanggal_Masuk=@Tanggal_Masuk, Tanggal_Keluar=@Tanggal_Keluar, Kode_Dokter=@Kode_Dokter, Nama_Dokter=@Nama_Dokter, Spesialis=@Spesialis where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        cmd.Parameters.AddWithValue("@No_KTP", txtnoktp.Text)
        cmd.Parameters.AddWithValue("@Nama", txtnamalengkap.Text)
        cmd.Parameters.AddWithValue("@Jenis_Kelamin", cbjeniskel.SelectedItem)
        cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtbirth.Text)
        cmd.Parameters.AddWithValue("@Umur", txtumur.Text)
        cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
        cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@Pekerjaan", txtpekerjaan.Text)
        cmd.Parameters.AddWithValue("@No_Telepon", txtnotelp.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Masuk", dttgmsk.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Keluar", dttgkl.Text)
        cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
        cmd.Parameters.AddWithValue("@Nama_Dokter", txtnamdok.Text)
        cmd.Parameters.AddWithValue("@Spesialis", txtspesialis.Text)
        cmd.ExecuteNonQuery()
        lihat_pasien()
        txtnorm.Clear()
        txtnoktp.Clear()
        txtnamalengkap.Clear()
        cbjeniskel.SelectedIndex = -1
        dtbirth.Text = ""
        txtumur.Clear()
        txtpolik.Clear()
        txtalamat.Clear()
        txtpekerjaan.Clear()
        txtnotelp.Clear()
        dttgmsk.Text = ""
        dttgkl.Text = ""
        txtkddokter.Clear()
        txtnamdok.Clear()
        txtspesialis.Clear()
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Pasien Berhasil di Update !", vbOKOnly + vbInformation, "sukses")

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbpasien where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        cmd.ExecuteNonQuery()
        lihat_pasien()
        txtnorm.Clear()
        txtnoktp.Clear()
        txtnamalengkap.Clear()
        cbjeniskel.SelectedIndex = -1
        dtbirth.Text = ""
        txtumur.Clear()
        txtpolik.Clear()
        txtalamat.Clear()
        txtpekerjaan.Clear()
        txtnotelp.Clear()
        dttgmsk.Text = ""
        dttgkl.Text = ""
        txtkddokter.Clear()
        txtnamdok.Clear()
        txtspesialis.Clear()
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data pasien Berhasil Dihapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            lihat_pasien()
        Else
            cmd = New MySqlCommand("select*from tbpasien where No_KTP like @No_KTP or Nama like @Nama or Tanggal_Lahir like @Tanggal_Lahir or Jenis_Kelamin like @Jenis_Kelamin or Umur like @Umur or Poliklinik like @Poliklinik or Tanggal_Masuk like @Tanggal_Masuk or Tanggal_Keluar like @Tanggal_Keluar or Kode_Dokter like @Kode_Dokter or Nama_Dokter like @Nama_Dokter or Spesialis like @Spesialis or No_RM like @No_RM limit 10", cn)
            cmd.Parameters.AddWithValue("@No_KTP", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Nama", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Lahir", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Umur", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Poliklinik", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Masuk", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Keluar", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Nama_Dokter", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@No_RM", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Spesialis", txtcari.Text & "%")
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

End Class
