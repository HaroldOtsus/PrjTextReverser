Public Class CTekstiPooraja
    Implements ITeisendused

    'Klassi CTekstiPooraja atribuudid (muutujad)
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String

    'Liidese omaduste (atribuutide) seadistamine

    'Atribuut intAlgus seadistamine
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol       'atribuudi k6simisel tagasta intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSymbol = value      'atribuudi v22rtuse seadistamine
        End Set
    End Property

    'Atribuut intLopp seadistamine
    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol        'atribuudi k6simiselt tagasta intLoppSymbol
        End Get
        Set(value As Integer)
            intLoppSymbol = value       'atribuudi v22rtuse seadistamine
        End Set
    End Property

    'Atribuut strTekst seadistamine
    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst     'atribuudi küsimisel tagasta strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value    'atribuudi v22rtuse seadistamine
        End Set
    End Property

    'Meetod(protseduur), mis p66rab tagurpidi sisendparameetrina strSisendTekst
    'antud avaldise ja salvestab v22rtuse atribuuti strPooratavTekst
    Private Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    'Meetod(funktsioon), mis v6tab atribuudist strSisendTekst v22rtuse
    'ja p66rab selle stringi tagurpidi
    Private Function pooraTekst() As String _
        Implements ITeisendused.pooraTekst
        Return StrReverse(strPooratavTekst)
    End Function

    'Meetod, mis loeb mitu t2is22likut on sisestatud s6nas
    Private Function loeT2ish22likud(ByVal strSisendTekst As String) As Integer _
        Implements ITeisendused.loeT2ish22likud
        't2ish22likute massiiv
        Dim strT2ish22likud As String = "AEIOUÕÄÖÜaeiouõäöü"
        'loeb mitu t2ish22likut on s6nas
        Dim loendur As Integer = 0

        'Ts6kkel v6rdleb sisend stringi ette antud t2ish22likute stringiga ja kui leiab vaste
        'siis inkrementeerib loendurit 6he v6rra
        For i As Integer = 0 To Len(strSisendTekst) - 1
            For j As Integer = 0 To 17
                If strSisendTekst(i) = strT2ish22likud(j) Then
                    loendur += 1
                End If
            Next
        Next

        Return loendur
    End Function

End Class
