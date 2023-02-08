Public Class formKasutajaAken
    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click
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
End Class
