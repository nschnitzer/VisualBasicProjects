Public Class Form1
    Private Sub btnMonogram_Click(sender As Object, e As EventArgs) Handles btnMonogram.Click
        Dim strNames() As String = txtInput.Text.Split(" ")
        lblMonogram.ResetText()
        Dim sngCounter As Single
        For sngCounter = 0 To strNames.Length - 1
            If sngCounter Mod 2 = 0 Then
                strNames(sngCounter).ToLower()
                Me.lblMonogram.Text = Me.lblMonogram.Text + strNames(sngCounter).Chars(0).ToString.ToLower
            Else
                strNames(sngCounter).ToUpper()
                Me.lblMonogram.Text = Me.lblMonogram.Text + strNames(sngCounter).Chars(0).ToString
            End If
        Next sngCounter

    End Sub
End Class
