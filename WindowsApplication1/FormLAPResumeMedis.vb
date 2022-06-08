Imports MySql.Data.MySqlClient
Public Class FormLAPResumeMedis
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub bttampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil.Click
        AxCrystalReport1.SelectionFormula = "{tbresumemedis.Tanggal} in date (" & Label5.Text & ") to date (" & Label6.Text & ")"
        AxCrystalReport1.ReportFileName = "Laporanresumeperr.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1

    End Sub

    Private Sub FormLAPResumeMedis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbulan.Items.Clear()
        cbbulan.Items.Add("01 - JANUARI")
        cbbulan.Items.Add("02 - FEBRUARI")
        cbbulan.Items.Add("03 - MARET")
        cbbulan.Items.Add("04 - APRIL")
        cbbulan.Items.Add("05 - MEI")
        cbbulan.Items.Add("06 - JUNI")
        cbbulan.Items.Add("07 - JULI")
        cbbulan.Items.Add("08 - AGUSTUS")
        cbbulan.Items.Add("09 - SEPTEMBER")
        cbbulan.Items.Add("10 - OKTOBER")
        cbbulan.Items.Add("11 - NOVEMBER")
        cbbulan.Items.Add("12 - DESEMBER")

        cbtahun.Items.Clear()
        cbtahun.Text = Date.Now.Year
        For i As Integer = 0 To 5
            cbtahun.Items.Add(Date.Now.Year - i)
        Next


        Label5.Text = "2021, 10, 27"
        Label6.Text = "2021, 10, 28"
        Label5.Text = Format(dttglke.Value, "yyyy, MM, dd")
        Label6.Text = Format(dtsamtgl.Value, "yyyy, MM, dd")

    End Sub

    Private Sub dttglke_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttglke.ValueChanged
        Label5.Text = Format(dttglke.Value, "yyyy, MM, dd")
    End Sub

    Private Sub dtsamtgl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsamtgl.ValueChanged
        Label6.Text = Format(dtsamtgl.Value, "yyyy, MM, dd")
    End Sub

    Private Sub bttampiltgl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampiltgl.Click
        AxCrystalReport1.SelectionFormula = "totext({tbresumemedis.Tanggal})='" & dttgl.Value & "'"
        AxCrystalReport1.ReportFileName = "Laporanresumeperr.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub bttampilbln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampilbln.Click
        If cbbulan.Text = "" Or cbtahun.Text = "" Then
            MsgBox("Silahkan Isi Bulan dan Tahunnya Terlebih Dahulu")
        Else
            AxCrystalReport1.SelectionFormula = "Month({tbresumemedis.Tanggal})=" & Val(cbbulan.Text) & " and year({tbresumemedis.Tanggal})=" & Val(cbtahun.Text)
            AxCrystalReport1.ReportFileName = "Laporanresumeperrbulanan.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub bttampil2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil2.Click
        If txtnorm.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Nomor Rekam Medisnya Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbresumemedis where No_RM=@No_RM", cn)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Nomor Rekam Medis Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbresumemedis.No_RM})='" & txtnorm.Text & "'"
            AxCrystalReport1.ReportFileName = "Laporanresumeperr.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub bttampil4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil4.Click
        If txtdpjp.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan DPJP Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbresumemedis where DPJP=@DPJP", cn)
            cmd.Parameters.AddWithValue("@DPJP", txtdpjp.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("DATA DPJP Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbresumemedis.DPJP})='" & txtdpjp.Text & "'"
            AxCrystalReport1.ReportFileName = "Laporanresumeperr.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub bttampil3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil3.Click
        If txtdiag.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Hasil Diagnosa Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbresumemedis where Diagnosa_Utama=@DU", cn)
            cmd.Parameters.AddWithValue("@DU", txtdiag.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("DATA Diagnosa Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbresumemedis.Diagnosa_Utama})='" & txtdiag.Text & "'"
            AxCrystalReport1.ReportFileName = "Laporanresumeperr.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub
End Class