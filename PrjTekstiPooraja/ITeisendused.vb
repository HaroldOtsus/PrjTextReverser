Public Interface ITeisendused
    Property intAlgus As Integer    'teksti esimene symbol ASCII koodi jaoks
    Property intLopp As Integer     'teksti viimane symbol ASCII koodi jaoks
    Property strTekst As String     'kasutaja sisestatud teksti jaoks

    Function pooraTekst() As String     'liidese meetodid koodi
    Sub teisendaTekst(ByRef strSisendTekst As String)       'ei oma ii-i-i--i
End Interface
