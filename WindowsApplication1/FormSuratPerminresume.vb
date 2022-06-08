Imports MySql.Data.MySqlClient
Public Class FormSuratPerminresume
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub bttampil1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil1.Click
        AxCrystalReport1.SelectionFormula = "totext({tbperminresume.Tanggal})='" & dttgl.Value & "'"
        AxCrystalReport1.ReportFileName = "suratpermohonanresume.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub bttampil3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil3.Click
        AxCrystalReport1.SelectionFormula = "{tbperminresume.Tanggal} in date (" & Label2.Text & ") to date (" & Label3.Text & ")"
        AxCrystalReport1.ReportFileName = "suratpermohonanresume.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub FormLAPPerminresume_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "2021, 10, 27"
        Label3.Text = "2021, 10, 28"
        Label2.Text = Format(dttglke.Value, "yyyy, MM, dd")
        Label3.Text = Format(dtsamtgl.Value, "yyyy, MM, dd")
    End Sub

    Private Sub dttglke_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttglke.ValueChanged
        Label2.Text = Format(dttglke.Value, "yyyy, MM, dd")
    End Sub

    Private Sub dtsamtgl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsamtgl.ValueChanged
        Label3.Text = Format(dtsamtgl.Value, "yyyy, MM, dd")
    End Sub
    Private Sub bttampil2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil2.Click
        If txtnorm.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Nomor Rekam Medisnya Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbperminresume where No_RM=@No_RM", cn)
            cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Nomor Rekam Medis Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbperminresume.No_RM})='" & txtnorm.Text & "'"
            AxCrystalReport1.ReportFileName = "suratpermohonanresume.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub bttampil5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil5.Click
        If txtkeper.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Keperluan Pemohon Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbperminresume where Keperluan=@Keperluan", cn)
            cmd.Parameters.AddWithValue("@Keperluan", txtkeper.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("data Keperluan Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbperminresume.Keperluan})='" & txtkeper.Text & "'"
            AxCrystalReport1.ReportFileName = "suratpermohonanresume.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub bttampil6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampil6.Click
        If txtkddokter.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Kode Dokter Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbperminresume where Kode_Dokter=@Kode_Dokter", cn)
            cmd.Parameters.AddWithValue("@Kode_Dokter", txtkddokter.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("Kode Dokter Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbperminresume.Kode_Dokter})='" & txtkddokter.Text & "'"
            AxCrystalReport1.ReportFileName = "suratpermohonanresume.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

End Class