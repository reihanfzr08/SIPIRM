Imports MySql.Data.MySqlClient
Public Class FormPermintaanResume
    Sub lihat_permin()
        cmd = New MySqlCommand("select*from tbperminresume", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Private Sub FormPermintaanResume_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lihat_permin()
        dttanggal.Format = DateTimePickerFormat.Custom
        dttanggal.CustomFormat = "yyyy/MM/dd"
        dtbirth.Format = DateTimePickerFormat.Custom
        dtbirth.CustomFormat = "yyyy/MM/dd"
        dttgmsk.Format = DateTimePickerFormat.Custom
        dttgmsk.CustomFormat = "yyyy/MM/dd"
        dttgkl.Format = DateTimePickerFormat.Custom
        dttgkl.CustomFormat = "yyyy/MM/dd"
        'cmd = New MySqlCommand("select No_RM from tbpasien", cn)
        'dr = cmd.ExecuteReader
        'cbnorm.Items.Clear()
        'cbnorm.Text = "--pilih--"
        'While dr.Read
        '    cbnorm.Items.Add(dr.Item(0))
        'End While
        'dr.Close()
    End Sub
    Private Sub txtnotelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtumur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtumur.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtnorm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnorm.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            cmd = New MySqlCommand("select*from tbpasien where No_RM=@No_RM", cn)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txtnampas.Text = dr.Item(2)
                txtalamat.Text = dr.Item("Alamat")
                txtnotelp.Text = dr.Item("No_Telepon")
                txtjekel.Text = dr.Item("Jenis_Kelamin")
                dtbirth.Text = dr.Item("Tanggal_Lahir")
                txtpolik.Text = dr.Item("Poliklinik")
                txtumur.Text = dr.Item("Umur")
                dttgmsk.Text = dr.Item("Tanggal_Masuk")
                dttgkl.Text = dr.Item("Tanggal_Keluar")
                txtkddokter.Text = dr.Item("Kode_Dokter")
                dr.Close()
            Else
                dr.Close()
                MsgBox("data tidak ditemukan!!", vbOKOnly + vbCritical, "eror")
            End If
        End If
    End Sub
    'Private Sub cbnorm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbnorm.SelectedIndexChanged
    '    cmd = New MySqlCommand("select*from tbpasien where No_RM=@No_RM", cn)
    '    cmd.Parameters.AddWithValue("@No_RM", cbnorm.Text)
    '    dr = cmd.ExecuteReader
    '    dr.Read()
    '    If dr.HasRows = True Then
    '        txtnampas.Text = dr.Item("Nama")
    '        txtalamat.Text = dr.Item("Alamat")
    '        txtnotelp.Text = dr.Item("No_Telepon")
    '        txtjekel.Text = dr.Item("Jenis_Kelamin")
    '        dtbirth.Text = dr.Item("Tanggal_Lahir")
    '        txtpolik.Text = dr.Item("Poliklinik")
    '        txtumur.Text = dr.Item("Umur")
    '        dttgmsk.Text = dr.Item("Tanggal_Masuk")
    '        dttgkl.Text = dr.Item("Tanggal_Keluar")
    '        dr.Close()
    '    Else
    '        dr.Close()
    '        MsgBox("data tidak ditemukan!!", vbOKOnly + vbCritical, "eror")
    '    End If
    'End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbperminresume where No_RM=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtnorm.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data permintaan resume ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbperminresume values(@Tanggal,@No_RM,@Nama_Pasien,@Alamat,@Nomor_Telepon,@Nama_Pemohon,@Keperluan,@Jenis_kelamin_Pasien,@Tanggal_Lahir_Pasien,@Poliklinik,@Umur_Pasien,@Tanggal_Masuk_Pasien,@Tanggal_Keluar_Pasien,@Kode_Dokter)", cn)
            cmd.Parameters.AddWithValue("@Tanggal", dttanggal.Text)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            cmd.Parameters.AddWithValue("@Nama_Pasien", txtnampas.Text)
            cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@Nomor_Telepon", txtnotelp.Text)
            cmd.Parameters.AddWithValue("@Nama_Pemohon", txtnampem.Text)
            cmd.Parameters.AddWithValue("@Keperluan", txtkeper.Text)
            cmd.Parameters.AddWithValue("@Jenis_Kelamin_Pasien", txtjekel.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Lahir_Pasien", dtbirth.Text)
            cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
            cmd.Parameters.AddWithValue("@Umur_Pasien", txtumur.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Masuk_Pasien", dttgmsk.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Keluar_Pasien", dttgkl.Text)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)

            cmd.ExecuteNonQuery()
            dttanggal.Text = ""
            'cbnorm.Text = "--Pilih--"
            txtnorm.Clear()
            txtnampas.Clear()
            txtalamat.Clear()
            txtnotelp.Clear()
            txtnampem.Clear()
            txtkeper.Clear()
            txtjekel.Clear()
            dtbirth.Text = ""
            txtpolik.Clear()
            txtumur.Clear()
            dttgkl.Text = ""
            dttgmsk.Text = ""
            txtkddokter.Clear()
            MsgBox("Data Permintaan resume Berhasil Disimpan!", vbOKOnly + vbInformation, "sukses")
        End If
        lihat_permin()
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
        dttanggal.Text = DataGridView1.CurrentRow.Cells(0).Value.date
        txtnorm.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtnampas.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtalamat.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtnotelp.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtnampem.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtkeper.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtjekel.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        dtbirth.Text = DataGridView1.CurrentRow.Cells(8).Value.date
        txtpolik.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txtumur.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        dttgmsk.Text = DataGridView1.CurrentRow.Cells(11).Value.date
        dttgkl.Text = DataGridView1.CurrentRow.Cells(12).Value.date
        txtkddokter.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        btsave.Enabled = False
        txtpolik.Enabled = False
        dttgmsk.Enabled = False
        dttgkl.Enabled = False
        txtnorm.Enabled = False
        txtkddokter.Enabled = False
        txtnorm.Focus()

    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbperminresume set Tanggal=@Tanggal, Nama_Pasien=@Nama_Pasien, Alamat=@Alamat, Nomor_Telepon=@Nomor_Telepon, Nama_Pemohon=@Nama_Pemohon, Keperluan=@Keperluan, Jenis_Kelamin_Pasien=@Jenis_Kelamin_Pasien, Tanggal_Lahir_Pasien=@Tanggal_Lahir_Pasien, Poliklinik=@Poliklinik, Umur_Pasien=@Umur_Pasien, Tanggal_Masuk_Pasien=@Tanggal_Masuk_Pasien, Tanggal_Keluar_Pasien=@Tanggal_Keluar_Pasien, Kode_Dokter=@Kode_Dokter where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        cmd.Parameters.AddWithValue("@Tanggal", dttanggal.Text)
        cmd.Parameters.AddWithValue("@Nama_Pasien", txtnampas.Text)
        cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@Nomor_Telepon", txtnotelp.Text)
        cmd.Parameters.AddWithValue("@Nama_Pemohon", txtnampem.Text)
        cmd.Parameters.AddWithValue("@Keperluan", txtkeper.Text)
        cmd.Parameters.AddWithValue("@Jenis_Kelamin_Pasien", txtjekel.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Lahir_Pasien", dtbirth.Text)
        cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
        cmd.Parameters.AddWithValue("@Umur_Pasien", txtumur.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Masuk_Pasien", dttgmsk.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Keluar_Pasien", dttgkl.Text)
        cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
        cmd.ExecuteNonQuery()
        lihat_permin()
        dttanggal.Text = ""
        'cbnorm.Text = "--Pilih--"
        txtnorm.Clear()
        txtnampas.Clear()
        txtalamat.Clear()
        txtnotelp.Clear()
        txtnampem.Clear()
        txtkeper.Clear()
        txtjekel.Clear()
        dtbirth.Text = ""
        txtpolik.Clear()
        txtumur.Clear()
        dttgkl.Text = ""
        dttgmsk.Text = ""
        txtkddokter.Clear()
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data permintaan resume Berhasil di Update !", vbOKOnly + vbInformation, "sukses")

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbperminresume where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        cmd.ExecuteNonQuery()
        lihat_permin()
        dttanggal.Text = ""
        'cbnorm.Text = "--Pilih--"
        txtnampas.Clear()
        txtalamat.Clear()
        txtnotelp.Clear()
        txtnampem.Clear()
        txtkeper.Clear()
        txtjekel.Clear()
        dtbirth.Text = ""
        txtpolik.Clear()
        txtumur.Clear()
        dttgkl.Text = ""
        dttgmsk.Text = ""
        txtkddokter.Clear()
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data permintaan resume Berhasil Dihapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            lihat_permin()
        Else
            cmd = New MySqlCommand("select*from tbperminresume where Tanggal like @Tanggal or No_RM like @No_RM or Nama_Pasien like @Nama_Pasien or Alamat like @Alamat or Nomor_Telepon like @Nomor_Telepon or Nama_Pemohon like @Nama_Pemohon or Keperluan like @Keperluan or Tanggal_Lahir_Pasien like @Tanggal_Lahir_Pasien or Jenis_Kelamin_Pasien like @Jenis_Kelamin_Pasien or Umur_Pasien like @Umur_Pasien or Poliklinik like @Poliklinik or Tanggal_Masuk_Pasien like @Tanggal_Masuk_Pasien or Tanggal_Keluar_Pasien like @Tanggal_Keluar_Pasien or Kode_Dokter like @Kode_Dokter limit 10", cn)
            cmd.Parameters.AddWithValue("@Tanggal", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@No_RM", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Nama_Pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Alamat", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Nomor_Telepon", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Nama_Pemohon", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Keperluan", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Jenis_Kelamin_Pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Lahir_Pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Umur_Pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Poliklinik", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Masuk_Pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_keluar_Pasien", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtcari.Text & "%")
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(cmd)
            tb = New DataTable
            da.Fill(tb)
            DataGridView1.DataSource = tb
            lbjumlah.Text = DataGridView1.RowCount - 1
        End If
    End Sub

    Private Sub lbjumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbjumlah.Click

    End Sub

End Class
