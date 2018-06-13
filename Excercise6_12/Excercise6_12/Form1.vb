Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim sngVowelCounter As Single = 0
        Dim strInput As String = txtInput.Text
        strInput.ToLower()
        Dim chrA As Char = "a"
        Dim chrE As Char = "e"
        Dim chrI As Char = "i"
        Dim chrO As Char = "o"
        Dim chrU As Char = "u"

        Dim sngCounter As Single
        For sngCounter = 0 To strInput.Length - 1
            If strInput.Chars(sngCounter).CompareTo(chrA) = 0 Then
                sngVowelCounter = sngVowelCounter + 1
            ElseIf strInput.Chars(sngCounter).CompareTo(chrE) = 0 Then
                sngVowelCounter = sngVowelCounter + 1
            ElseIf strInput.Chars(sngCounter).CompareTo(chrI) = 0 Then
                sngVowelCounter = sngVowelCounter + 1
            ElseIf strInput.Chars(sngCounter).CompareTo(chrO) = 0 Then
                sngVowelCounter = sngVowelCounter + 1
            ElseIf strInput.Chars(sngCounter).CompareTo(chrU) = 0 Then
                sngVowelCounter = sngVowelCounter + 1
            End If
        Next sngCounter

        Me.lblVowels.Text = sngVowelCounter.ToString
    End Sub
End Class
