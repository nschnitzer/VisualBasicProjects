Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        Dim sngInput1 As Single = Val(txtJump1.Text)
        Dim sngInput2 As Single = Val(txtJump2.Text)
        Dim sngInput3 As Single = Val(txtJump3.Text)
        Dim sngInput4 As Single = Val(txtJump4.Text)

        Dim sngTotal As Single = (sngInput1 + sngInput2 + sngInput3 + sngInput4)
        sngTotal = sngTotal / 4
        Me.lblAverage.Text = sngTotal
    End Sub
End Class
