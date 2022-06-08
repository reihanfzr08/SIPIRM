Imports MySql.Data.MySqlClient
Public Class FormResumeMedisRJ
    Sub lihat_resRJ()
        cmd = New MySqlCommand("select*from tbresumemedis", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Private Sub FormResumeMedisRJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lihat_resRJ()
        dttgl.Format = DateTimePickerFormat.Custom
        dttgl.CustomFormat = "yyyy/MM/dd"
        dtbirth.Format = DateTimePickerFormat.Custom
        dtbirth.CustomFormat = "yyyy/MM/dd"
        dttglmsk.Format = DateTimePickerFormat.Custom
        dttglmsk.CustomFormat = "yyyy/MM/dd"
        dttglkel.Format = DateTimePickerFormat.Custom
        dttglkel.CustomFormat = "yyyy/MM/dd"
        'cmd = New MySqlCommand("select No_RM from tbpasien", cn)
        'dr = cmd.ExecuteReader
        'cbnorm.Items.Clear()
        'cbnorm.Text = "--pilih--"
        'While dr.Read
        '    cbnorm.Items.Add(dr.Item(0))
        'End While
        'dr.Close()
    End Sub
    Private Sub txtnopes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnopes.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtumur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtumur.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtt.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtd.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp.KeyPress
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
                txtjekel.Text = dr.Item("Jenis_Kelamin")
                dtbirth.Text = dr.Item("Tanggal_Lahir")
                txtalamat.Text = dr.Item("Alamat")
                txtumur.Text = dr.Item("Umur")
                txtkddokter.Text = dr.Item("Kode_Dokter")
                txtdpjp.Text = dr.Item("Nama_Dokter")
                txtspesialis.Text = dr.Item("Spesialis")
                txtpolik.Text = dr.Item("Poliklinik")
                dttglmsk.Text = dr.Item("Tanggal_Masuk")
                dttglkel.Text = dr.Item("Tanggal_Keluar")
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
    '        txtjekel.Text = dr.Item("Jenis_Kelamin")
    '        dtbirth.Text = dr.Item("Tanggal_Lahir")
    '        txtumur.Text = dr.Item("Umur")
    '        dr.Close()
    '    Else
    '        dr.Close()
    '        MsgBox("data tidak ditemukan!!", vbOKOnly + vbCritical, "eror")
    '    End If
    'End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbresumemedis where No_RM=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtnorm.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data pasien ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbresumemedis values(@No_RM,@Nama,@Umur,@Tanggal_Lahir,@Alamat,@No_Peserta,@Jenis_Kelamin,@Anamnesis,@T,@N,@D,@P,@Kelainan_yang_ditemukan,@Diagnosa_Utama,@Diagnosa_tambahan,@Terapi,@Tindakan,@Catatan,@Kode_Dokter,@DPJP,@Spesialis,@Poliklinik,@Tanggal,@Tanggal_Masuk,@Tanggal_Keluar)", cn)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            cmd.Parameters.AddWithValue("@Nama", txtnampas.Text)
            cmd.Parameters.AddWithValue("@Umur", txtumur.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtbirth.Text)
            cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@No_Peserta", txtnopes.Text)
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", txtjekel.Text)
            cmd.Parameters.AddWithValue("@Anamnesis", txtanam.Text)
            cmd.Parameters.AddWithValue("@T", txtt.Text)
            cmd.Parameters.AddWithValue("@N", txtn.Text)
            cmd.Parameters.AddWithValue("@D", txtd.Text)
            cmd.Parameters.AddWithValue("@P", txtp.Text)
            cmd.Parameters.AddWithValue("@Kelainan_yang_ditemukan", txtkelainan.Text)
            cmd.Parameters.AddWithValue("@Diagnosa_Utama", txtdiagut.Text)
            cmd.Parameters.AddWithValue("@Diagnosa_tambahan", txtdiagtam.Text)
            cmd.Parameters.AddWithValue("@Terapi", txtterapi.Text)
            cmd.Parameters.AddWithValue("@Tindakan", txttindakan.Text)
            cmd.Parameters.AddWithValue("@Catatan", cbcatatan.Text)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
            cmd.Parameters.AddWithValue("@DPJP", txtdpjp.Text)
            cmd.Parameters.AddWithValue("@Spesialis", txtspesialis.Text)
            cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
            cmd.Parameters.AddWithValue("@Tanggal", dttgl.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Masuk", dttglmsk.Text)
            cmd.Parameters.AddWithValue("@Tanggal_keluar", dttglkel.Text)
            cmd.ExecuteNonQuery()
            dttgl.Text = ""
            'cbnorm.Text = "--Pilih--"
            txtnorm.Clear()
            txtnampas.Clear()
            txtjekel.Clear()
            txtanam.Clear()
            txtt.Clear()
            txtn.Clear()
            txtd.Clear()
            txtp.Clear()
            txtkelainan.Clear()
            txtdiagut.Clear()
            txtdiagtam.Clear()
            dtbirth.Text = ""
            txtalamat.clear()
            txtumur.Clear()
            txtnopes.Clear()
            txtterapi.Clear()
            txttindakan.Clear()
            cbcatatan.SelectedIndex = -1
            txtkddokter.Clear()
            txtdpjp.Clear()
            txtspesialis.clear()
            txtpolik.Clear()
            dttglmsk.Text = ""
            dttglkel.Text = ""
            MsgBox("Data Resume Medis RJ Berhasil Disimpan!", vbOKOnly + vbInformation, "sukses")
        End If
        lihat_resRJ()
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
        txtnampas.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtumur.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        dtbirth.Text = DataGridView1.CurrentRow.Cells(3).Value.date
        txtalamat.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtnopes.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtjekel.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtanam.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtt.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        txtn.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txtd.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        txtp.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        txtkelainan.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        txtdiagut.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        txtdiagtam.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        txtterapi.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
        txttindakan.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString
        cbcatatan.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString
        txtkddokter.Text = DataGridView1.CurrentRow.Cells(18).Value.ToString
        txtdpjp.Text = DataGridView1.CurrentRow.Cells(19).Value.ToString
        txtspesialis.Text = DataGridView1.CurrentRow.Cells(20).Value.ToString
        txtpolik.Text = DataGridView1.CurrentRow.Cells(21).Value.ToString
        dttgl.Text = DataGridView1.CurrentRow.Cells(22).Value.date
        dttglmsk.Text = DataGridView1.CurrentRow.Cells(23).Value.date
        dttglkel.Text = DataGridView1.CurrentRow.Cells(24).Value.date
        dttgl.Enabled = False
        txtpolik.Enabled = False
        txtspesialis.Enabled = False
        btsave.Enabled = False
        txtkddokter.Enabled = False
        txtdpjp.Enabled = False
        txtnorm.Enabled = False
        txtnorm.Focus()

    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbresumemedis set Nama=@Nama, Umur=@Umur, Tanggal_Lahir=@Tanggal_Lahir, Alamat=@Alamat, No_Peserta=@No_Peserta, Jenis_Kelamin=@Jenis_Kelamin, Anamnesis=@Anamnesis, T=@T, N=@N, D=@D, P=@P, Kelainan_yang_ditemukan=@Kelainan_yang_ditemukan, Diagnosa_Utama=@Diagnosa_Utama, Diagnosa_tambahan=@Diagnosa_tambahan, Terapi=@Terapi, Tindakan=@Tindakan, Catatan=@Catatan, Kode_Dokter=@Kode_Dokter, DPJP=@DPJP, Spesialis=@Spesialis, Poliklinik=@Poliklinik, Tanggal=@Tanggal, Tanggal_Masuk=@Tanggal_Masuk, Tanggal_Keluar=@Tanggal_Keluar where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        cmd.Parameters.AddWithValue("@Nama", txtnampas.Text)
        cmd.Parameters.AddWithValue("@Umur", txtumur.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtbirth.Text)
        cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@No_Peserta", txtnopes.Text)
        cmd.Parameters.AddWithValue("@Jenis_Kelamin", txtjekel.Text)
        cmd.Parameters.AddWithValue("@Anamnesis", txtanam.Text)
        cmd.Parameters.AddWithValue("@T", txtt.Text)
        cmd.Parameters.AddWithValue("@N", txtn.Text)
        cmd.Parameters.AddWithValue("@D", txtd.Text)
        cmd.Parameters.AddWithValue("@P", txtp.Text)
        cmd.Parameters.AddWithValue("@Kelainan_yang_ditemukan", txtkelainan.Text)
        cmd.Parameters.AddWithValue("@Diagnosa_Utama", txtdiagut.Text)
        cmd.Parameters.AddWithValue("@Diagnosa_tambahan", txtdiagtam.Text)
        cmd.Parameters.AddWithValue("@Terapi", txtterapi.Text)
        cmd.Parameters.AddWithValue("@Tindakan", txttindakan.Text)
        cmd.Parameters.AddWithValue("@Catatan", cbcatatan.Text)
        cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
        cmd.Parameters.AddWithValue("@DPJP", txtdpjp.Text)
        cmd.Parameters.AddWithValue("@Spesialis", txtspesialis.Text)
        cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
        cmd.Parameters.AddWithValue("@Tanggal", dttgl.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Masuk", dttglmsk.Text)
        cmd.Parameters.AddWithValue("@Tanggal_keluar", dttglkel.Text)
        cmd.ExecuteNonQuery()
        lihat_resRJ()
        dttgl.Text = ""
        'cbnorm.Text = "--Pilih--"
        txtnorm.Clear()
        txtnampas.Clear()
        txtjekel.Clear()
        txtanam.Clear()
        txtt.Clear()
        txtn.Clear()
        txtd.Clear()
        txtp.Clear()
        txtkelainan.Clear()
        txtdiagut.Clear()
        txtdiagtam.Clear()
        dtbirth.Text = ""
        txtalamat.clear()
        txtumur.Clear()
        txtnopes.Clear()
        txtterapi.Clear()
        txttindakan.Clear()
        cbcatatan.SelectedIndex = -1
        txtkddokter.Clear()
        txtdpjp.Clear()
        txtspesialis.clear()
        txtpolik.Clear()
        dttglmsk.Text = ""
        dttglkel.Text = ""
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Resume Medis RJ Berhasil di Update !", vbOKOnly + vbInformation, "sukses")

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbresumemedis where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        cmd.ExecuteNonQuery()
        lihat_resRJ()
        dttgl.Text = ""
        'cbnorm.Text = "--Pilih--"
        txtnorm.Clear()
        txtnampas.Clear()
        txtjekel.Clear()
        txtanam.Clear()
        txtt.Clear()
        txtn.Clear()
        txtd.Clear()
        txtp.Clear()
        txtkelainan.Clear()
        txtdiagut.Clear()
        txtdiagtam.Clear()
        dtbirth.Text = ""
        txtalamat.clear()
        txtumur.Clear()
        txtnopes.Clear()
        txtterapi.Clear()
        txttindakan.Clear()
        cbcatatan.SelectedIndex = -1
        txtkddokter.Clear()
        txtdpjp.Clear()
        txtspesialis.clear()
        txtpolik.Clear()
        dttglmsk.Text = ""
        dttglkel.Text = ""
        txtnorm.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Resume Medis RJ Berhasil Dihapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            lihat_resRJ()
        Else
            cmd = New MySqlCommand("select*from tbresumemedis where Tanggal like @Tanggal or Nama like @Nama or Jenis_Kelamin like @Jenis_Kelamin or Anamnesis like @Anamnesis or T like @T or N like @N or D like @D OR P like @P or Kelainan_yang_ditemukan like @Kelainan_yang_ditemukan or Diagnosa_Utama like @Diagnosa_Utama or Diagnosa_tambahan like @Diagnosa_tambahan or Tanggal_Lahir like @Tanggal_Lahir or Umur like @Umur or No_Peserta like @No_Peserta or Terapi like @Terapi or Tindakan like @Tindakan or Catatan like @Catatan or Kode_Dokter like @Kode_Dokter or DPJP like @DPJP or Spesialis like @Spesialis or Poliklinik like @Poliklinik or Alamat like @Alamat or Tanggal_Masuk like @Tanggal_Masuk or Tanggal_Keluar like @Tanggal_Keluar or No_RM like @No_RM limit 10", cn)
            cmd.Parameters.AddWithValue("@Tanggal", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@No_RM", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Nama", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Anamnesis", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Kelainan_yang_ditemukan", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Diagnosa_Utama", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Diagnosa_tambahan", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Lahir", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Umur", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@No_Peserta", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Alamat", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Spesialis", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Poliklinik", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Terapi", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tindakan", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Catatan", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@DPJP", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_Masuk", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Tanggal_keluar", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@T", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@N", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@D", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@P", txtcari.Text & "%")
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