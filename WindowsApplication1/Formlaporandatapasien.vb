Imports MySql.Data.MySqlClient
Public Class Formlaporandatapasien


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Close()
    End Sub

    Private Sub btntmpil1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmpil1.Click
        AxCrystalReport1.SelectionFormula = "totext({tbpasien.Tanggal_Masuk})='" & dttglmsk.Value & "'"
        AxCrystalReport1.ReportFileName = "laporandatapasienper.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btntmpil2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmpil2.Click
        AxCrystalReport1.SelectionFormula = "totext({tbpasien.Tanggal_Keluar})='" & dttglklr.Value & "'"
        AxCrystalReport1.ReportFileName = "laporandatapasienper.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btntmpil3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmpil3.Click
        If txtnorm.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Nomor Rekam Medisnya Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbpasien where No_RM=@No_RM", cn)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Nomor Rekam Medis Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbpasien.No_RM})='" & txtnorm.Text & "'"
            AxCrystalReport1.ReportFileName = "laporandatapasienper.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub btntmpil5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmpil5.Click
        If txtjekel.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Jenis Kelamin Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbpasien where Jenis_Kelamin=@Jenis_Kelamin", cn)
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", txtjekel.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Jenis Kelamin Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbpasien.Jenis_Kelamin})='" & txtjekel.Text & "'"
            AxCrystalReport1.ReportFileName = "laporandatapasienper.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub btntmpil4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmpil4.Click
        If txtkddokter.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Kode Dokter Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbpasien where Kode_Dokter=@Kode_Dokter", cn)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Kode Dokter Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbpasien.Kode_Dokter})='" & txtkddokter.Text & "'"
            AxCrystalReport1.ReportFileName = "laporandatapasienper.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub btntmpil6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmpil6.Click
        If txtpolik.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Poliklinik Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbpasien where Poliklinik=@Poliklinik", cn)
            cmd.Parameters.AddWithValue("@Poliklinik", txtpolik.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Data Poliklinik Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbpasien.Poliklinik})='" & txtpolik.Text & "'"
            AxCrystalReport1.ReportFileName = "laporandatapasienper.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub
End Class