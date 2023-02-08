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
End Class
