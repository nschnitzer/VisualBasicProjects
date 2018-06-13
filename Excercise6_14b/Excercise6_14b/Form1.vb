Public Class Form1
    Dim strMessage As String

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        strMessage = InputBox("Enter Message")
        Me.lblResult.ResetText()
        Dim chars() As Char
        chars = strMessage.ToCharArray()
        Dim chrNewValues(chars.Length) As Char
        Dim sngCounter As Single
        If Me.radEncode.Checked = True Then
            For sngCounter = 0 To chars.Length - 1
                Me.lblResult.Text = Me.lblResult.Text & " " & ChrW(Int(AscW(chars(sngCounter)) + 2))
            Next sngCounter
        Else
            For sngCounter = 0 To chars.Length - 1
                If AscW(chars(sngCounter)) > 97 Then
                    Me.lblResult.Text = Me.lblResult.Text & " " & ChrW(97 + (((AscW(chars(sngCounter)) - 2) Mod 97)))
                    System.Diagnostics.Debug.WriteLine(ChrW(97 + (((AscW(chars(sngCounter)) - 2) Mod 97))))
                Else
                    Me.lblResult.Text = Me.lblResult.Text & " " & ChrW(65 + ((AscW(chars(sngCounter)) - 2) Mod 65))
                    System.Diagnostics.Debug.WriteLine(ChrW(65 + (((AscW(chars(sngCounter)) - 2) Mod 65))))
                End If
            Next sngCounter
        End If

    End Sub
End Class
