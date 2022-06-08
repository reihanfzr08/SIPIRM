Imports MySql.Data.MySqlClient
Public Class FormSuratPelepasanIRM
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If txtnama.Text = "" Then
            MsgBox("Silahkan Isi data Berdasarkan Nama Pemohon Terlebih Dahulu")
        Else
            koneksi()
            cmd = New MySqlCommand("select*from tbperminresume where Nama_Pemohon=@Nama_Pemohon", cn)
            cmd.Parameters.AddWithValue("@Nama_Pemohon", txtnama.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows = True Then
                MsgBox("data Keperluan Tidak Ada !!", vbOKOnly + vbCritical, "Hang")
                dr.Close()
            Else
            End If
            AxCrystalReport1.SelectionFormula = "totext({tbperminresume.Nama_Pemohon})='" & txtnama.Text & "'"
            AxCrystalReport1.ReportFileName = "suratpelepasanirm.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        AxCrystalReport1.SelectionFormula = "totext({tbperminresume.Tanggal})='" & dttgl.Value & "'"
        AxCrystalReport1.ReportFileName = "suratpelepasanirm.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        AxCrystalReport1.SelectionFormula = "{tbperminresume.Tanggal} in date (" & Label3.Text & ") to date (" & Label5.Text & ")"
        AxCrystalReport1.ReportFileName = "suratpelepasanirm.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub FormSuratPelepasanIRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "2021, 10, 27"
        Label5.Text = "2021, 10, 28"
        Label3.Text = Format(dttglke.Value, "yyyy, MM, dd")
        Label5.Text = Format(dtsamtgl.Value, "yyyy, MM, dd")
    End Sub

    Private Sub dttglke_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttglke.ValueChanged
        Label3.Text = Format(dttglke.Value, "yyyy, MM, dd")
    End Sub

    Private Sub dtsamtgl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsamtgl.ValueChanged
        Label5.Text = Format(dtsamtgl.Value, "yyyy, MM, dd")
    End Sub

End Class