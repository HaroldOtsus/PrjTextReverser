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
End Class
