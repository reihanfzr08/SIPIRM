Public Class FormMasterData
    Sub aktif()
        PasienToolStripMenuItem.Enabled = True
        DokterToolStripMenuItem.Enabled = True
        resumerjToolStripMenuItem.Enabled = True
        perminresumeToolStripMenuItem.Enabled = True
        ResumemedisToolStripMenuItem.Enabled = True
        SuratPermohonanResumeMedisToolStripMenuItem.Enabled = True
        SuratPelepasanInformasiRekamMedisToolStripMenuItem.Enabled = True
        LaporanDataPasienToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = True
    End Sub
    Sub nonaktif()
        lbnama.Text = ""
        PasienToolStripMenuItem.Enabled = False
        DokterToolStripMenuItem.Enabled = False
        ResumemedisToolStripMenuItem.Enabled = False
        perminresumeToolStripMenuItem.Enabled = False
        resumerjToolStripMenuItem.Enabled = False
        SuratPermohonanResumeMedisToolStripMenuItem.Enabled = False
        SuratPelepasanInformasiRekamMedisToolStripMenuItem.Enabled = False
        LaporanDataPasienToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
        'Me.Hide()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        FormPasien.Show()
        'Me.Hide()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokterToolStripMenuItem.Click
        FormDokter.Show()
        'Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        nonaktif()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub PerminresumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perminresumeToolStripMenuItem.Click
        FormPermintaanResume.Show()
        'Me.Hide()
    End Sub
    Private Sub resumerjToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resumerjToolStripMenuItem.Click
        FormResumeMedisRJ.Show()
        'Me.Hide()
    End Sub

    Private Sub ResumemedisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumemedisToolStripMenuItem.Click
        FormLAPResumeMedis.Show()
        'Me.Hide()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        FormUser.Show()
        'Me.Hide()

    End Sub

    Private Sub FormMasterData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nonaktif()

    End Sub


    Private Sub LaporanDataPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataPasienToolStripMenuItem.Click
        Formlaporandatapasien.Show()
        'Me.Hide()
    End Sub

    Private Sub SuratPermohonanResumeMedisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratPermohonanResumeMedisToolStripMenuItem.Click
        FormSuratPerminresume.Show()
        'Me.Hide()
    End Sub

    Private Sub SuratPelepasanInformasiRekamMedisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuratPelepasanInformasiRekamMedisToolStripMenuItem.Click
        FormSuratPelepasanIRM.Show()
        'Me.Hide()
    End Sub
End Class