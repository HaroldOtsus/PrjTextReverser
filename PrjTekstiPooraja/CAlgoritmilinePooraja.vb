Public Class CAlgoritmilinePooraja
    Implements ITeisendused

    'Klassi CAlgoritmilinePooraja atribuudid (muutujad)
    Private strPooratavTekst As String

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst     'atribuudi küsimisel tagasta strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value    'atribuudi v22rtuse seadistamine
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst

    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        'Karakterite massiiv sisend teksti pikkusega
        Dim arrPooratud(Len(strPooratavTekst) - 1) As Char
        Dim j As Integer = 0

        'tsükkel, mis paigutab sisendi viimase t2he karakterite massiivi algusesse jne
        For i As Integer = Len(strPooratavTekst) - 1 To 0 Step -1
            arrPooratud(j) = strPooratavTekst(i)
            j += 1
        Next

        'muudame karakterite massiivi stringiks
        Dim strPooratud As String = CStr(arrPooratud)
        Return strPooratud
    End Function

    Private Function loeT2ish22likud(strSisendTekst As String) As Integer Implements ITeisendused.loeT2ish22likud

    End Function
End Class
