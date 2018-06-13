Public Class Form1
    Const basePrice As Single = 25
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim sngTotal As Single = basePrice
        If chkForward.Checked = True Then
            sngTotal = sngTotal + 3.5
        End If
        If chkID.Checked = True Then
            sngTotal = sngTotal + 3.5
        End If
        If chkWaiting.Checked = True Then
            sngTotal = sngTotal + 3.5
        End If

        lblPrice.Text = Format(sngTotal, "Currency")
    End Sub
End Class
