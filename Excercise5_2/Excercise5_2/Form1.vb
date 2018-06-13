Public Class Form1
    Const dblRate As Double = 5 / 9
    Dim dblInput As Double
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        dblInput = Me.txtTempF.Text
        dblInput = dblInput - 32
        dblInput = dblInput * dblRate
        Me.lblTempC.Text = dblInput
    End Sub
End Class
