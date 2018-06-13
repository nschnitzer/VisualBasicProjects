Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sngTotal As Single = 0
        Dim sngCounter As Single = Val(txtMin.Text)
        For sngCounter = Val(txtMin.Text) To Val(txtMax.Text)
            sngTotal = sngTotal + sngCounter
        Next sngCounter
        LblResult.Text = sngTotal.ToString
    End Sub
End Class
