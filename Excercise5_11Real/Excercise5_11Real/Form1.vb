Public Class Form1
    Dim sngPrice As Single = 0
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If radSmall.Checked = True Then
            sngPrice = 2.5
        Else
            sngPrice = 4.0
        End If

        If chkLettuce.Checked = True Then
            sngPrice = sngPrice + 0.1
        End If

        If chkOnion.Checked = True Then
            sngPrice = sngPrice + 0.1
        End If

        If chkTomato.Checked = True Then
            sngPrice = sngPrice + 0.25
        End If

        If chkCheese.Checked = True Then
            sngPrice = sngPrice + 0.5
        End If

        lblPrice.Text = FormatCurrency(sngPrice)

    End Sub
End Class
