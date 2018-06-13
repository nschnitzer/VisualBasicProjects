Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim chrVals() As Char = txtInput.Text.ToLower.ToCharArray
        Dim blnPalindrome As Boolean = True
        Dim sngCounter As Single
        For sngCounter = 0 To chrVals.Length \ 2 - 1
            If (chrVals(sngCounter) <> chrVals(chrVals.Length - 1 - sngCounter)) Then
                blnPalindrome = False
                sngCounter = chrVals.Length
            End If
        Next sngCounter

        If blnPalindrome = False Then
            Me.lblResult.Text = txtInput.Text & " " & "is not a palidrome"
        Else
            Me.lblResult.Text = txtInput.Text & " " & "is a palindrome"
        End If
    End Sub
End Class
