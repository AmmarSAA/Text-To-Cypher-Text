Module Module1
    Sub Main()
        Dim Phrase As String = "This Code is written by Syed Ammar Ahmed."
        Dim CypherText As String = ConvertToCypherText(Phrase)

        Console.WriteLine("The phrase is: " & Phrase)
        Console.WriteLine("The cypher text is: " & CypherText)
    End Sub

    Function ConvertToCypherText(phrase As String) As String
        Dim cypherText As String = ""
        Dim PhraseLength As Integer = phrase.Length
        Dim GrabALetter As Char
        Dim CypherLetter As Integer
        For I = 1 To PhraseLength
            GrabALetter = Mid(phrase, I, 1)
            CypherLetter = Asc(GrabALetter) + I * 2 / 5
            GrabALetter = Chr(CypherLetter)
            cypherText = LCase(cypherText & GrabALetter)
        Next
        Return cypherText
    End Function
End Module