Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        lblOneDigit.Visible = False
        lblTwoDigit.Visible = False
        Dim sngNum As Single = Val(txtInput.Text)
        If sngNum / 10 < 1 Then
            lblOneDigit.Visible = True
        Else
            lblTwoDigit.Visible = True
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
End Class
