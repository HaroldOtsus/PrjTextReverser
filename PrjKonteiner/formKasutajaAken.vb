Public Class formKasutajaAken
    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        If tekstiPoorajaRadio.Checked = True Then
            pooraja = New PrjTekstiPooraja.CTekstiPooraja
        ElseIf algoPoorajaRadio.Checked = True Then
            pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja
        End If

        'Teostame teksti p66ramise kasutades parametriseerimata funktsiooni pooraTekst
        'ning liidese atribuuti strTekst
        'omistame liidese atribuudile tekstiv2ljal oleva väärtuse
        pooraja.strTekst = txtSisendTekst.Text
        'kasutades komponendis sisalduvat funktsiooni, v22rtustame tekstiv2lja
        'txtValjundTekst1
        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub

    Private Sub btnPoora2_Click(sender As Object, e As EventArgs) Handles btnPoora2.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'Teostame teksti p66ramise kasutades parametriseeritud protseduuri teisendatekst()
        'ning liidese atribuuti strTekst
        'kutsume v2lja komponendis sisalduva protseduuri,
        'anname talle parameetriks tekstiv2lja v22rtuse
        pooraja.teisendaTekst(txtSisendTekst.Text)
        'omistame tekstiv2lja txtValjudTekst1 v22rtuseks liidese atribuudi v22rtuse
        txtValjundTekst2.Text = pooraja.strTekst
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'vajutus nupul btnStart l6litab taimeri timerUuenda sisse
        timerUuenda.Enabled = True
        'vajutus nupul btnStart keelab vajutused nupul btnStart
        btnStart.Enabled = False
    End Sub

    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'Teostame teksti p66ramise kasutades parametriseerimata funktsiooni pooraTekst
        'ning liidese atribuuti strTekst
        'omistame liidese atribuudile tekstiv2ljal oleva väärtuse
        pooraja.strTekst = txtSisendTekst.Text
        'kasutades komponendis sisalduvat funktsiooni, v22rtustame tekstiv2lja
        'txtValjundTekst1
        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        'vajutus nupul btnStopp l6litab taimeri timerUuenda v2lja
        timerUuenda.Enabled = False
        'vajutus nupul btnStopp keelab vajutused nupul btnStopp
        btnStart.Enabled = True
    End Sub

    'Kuvab mitmest t2hest sisestatud s6na koosneb
    'Kuvab mitmest t2ish22likust sisestatud s6na koosneb
    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        'kuvab kogu s6na pikkuse
        tekstiPikkus.Text = Len(txtSisendTekst.Text)

        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'kuvab t2ish22likud
        Dim intT2ish22likud As Integer
        intT2ish22likud = pooraja.loeT2ish22likud(txtSisendTekst.Text)

        t2isH22likud.Text = intT2ish22likud
    End Sub
End Class
