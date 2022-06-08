Imports MySql.Data.MySqlClient
Public Class FormDokter
    Sub lihat_dokter()
        cmd = New MySqlCommand("select*from tbdokter", cn)
        cmd.ExecuteNonQuery()
        da = New MySqlDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub
    Private Sub FormDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lihat_dokter()
        dtbirth.Format = DateTimePickerFormat.Custom
        dtbirth.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub txtnotelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        cmd = New MySqlCommand("select * from tbdokter where Kode_Dokter=@a", cn)
        cmd.Parameters.AddWithValue("@a", txtkddokter.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("data dokter ada !!", vbOKOnly + vbCritical, "Hang")
            dr.Close()
        Else
            dr.Close()

            cmd = New MySqlCommand("insert into tbdokter values(@Kode_Dokter,@Nama_Dokter,@Tanggal_Lahir,@Spesialis,@Nomor_Telepon,@Alamat)", cn)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
            cmd.Parameters.AddWithValue("@Nama_Dokter", txtnamadokter.Text)
            cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtbirth.Text)
            cmd.Parameters.AddWithValue("@Spesialis", cbspesialis.Text)
            cmd.Parameters.AddWithValue("@Nomor_Telepon", txtnotelp.Text)
            cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
            cmd.ExecuteNonQuery()
            txtkddokter.Clear()
            txtnamadokter.Clear()
            dtbirth.Text = ""
            cbspesialis.SelectedIndex = -1
            txtnotelp.Clear()
            txtalamat.Clear()


            MsgBox("Data Dokter Berhasil Disimpan !", vbOKOnly + vbInformation, "sukses")
        End If
        lihat_dokter()
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        cmd = New MySqlCommand("update tbdokter set Nama_Dokter=@Nama_Dokter,Tanggal_Lahir=@Tanggal_Lahir, Spesialis=@Spesialis, Nomor_Telepon=@Nomor_Telepon, Alamat=@Alamat where Kode_Dokter=@Kode_Dokter", cn)
        cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
        cmd.Parameters.AddWithValue("@Nama_Dokter", txtnamadokter.Text)
        cmd.Parameters.AddWithValue("@Tanggal_Lahir", dtbirth.Text)
        cmd.Parameters.AddWithValue("@Spesialis", cbspesialis.Text)
        cmd.Parameters.AddWithValue("@Nomor_Telepon", txtnotelp.Text)
        cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
        cmd.ExecuteNonQuery()
        lihat_dokter()
        txtkddokter.Clear()
        txtnamadokter.Clear()
        dtbirth.Text = ""
        cbspesialis.SelectedIndex = -1
        txtnotelp.Clear()
        txtalamat.Clear()
        txtkddokter.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Dokter Berhasil Update !", vbOKOnly + vbInformation, "sukses")
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtkddokter.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtnamadokter.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        dtbirth.Text = DataGridView1.CurrentRow.Cells(2).Value.date
        cbspesialis.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtnotelp.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtalamat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        btsave.Enabled = False
        txtkddokter.Enabled = False
        txtnamadokter.Focus()

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        cmd = New MySqlCommand("delete from tbdokter where Kode_Dokter=@Kode_Dokter", cn)
        cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
        cmd.ExecuteNonQuery()
        lihat_dokter()
        txtkddokter.Clear()
        txtnamadokter.Clear()
        dtbirth.Text = ""
        cbspesialis.SelectedIndex = -1
        txtnotelp.Clear()
        txtalamat.Clear()
        txtkddokter.Enabled = True
        btsave.Enabled = True
        MsgBox("Data Dokter Berhasil Di Hapus!", vbOKOnly + vbInformation, "sukses")
    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Close()
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            lihat_dokter()
        Else
            cmd = New MySqlCommand("select*from tbdokter where Nama_Dokter like @Nama_Dokter or Spesialis like @Spesialis or Kode_Dokter like @Kode_Dokter limit 10", cn)
            cmd.Parameters.AddWithValue("@Nama_Dokter", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtcari.Text & "%")
            cmd.Parameters.AddWithValue("@Spesialis", txtcari.Text & "%")
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