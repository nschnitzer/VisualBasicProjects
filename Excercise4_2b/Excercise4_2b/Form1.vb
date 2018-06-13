Public Class Form1
    Dim blnFahrenheit As Boolean = True
    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub mnuCelsius_Click(sender As Object, e As EventArgs) Handles mnuCelsius.Click
        Me.blnFahrenheit = False
        Me.lblTempType.Text = "Fahrenheit:"
        Me.lblInputF.Visible = False
        Me.lblCelsius.Visible = True

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        If Me.blnFahrenheit.Equals(True) Then
            Dim sngInput As Single = Val(txtInput.Text)
            sngInput = (sngInput * (9 / 5)) + 32
            lblAnswer.Text = sngInput
        Else
            Dim sngInput As Single = Val(txtInput.Text)
            sngInput = (5 / 9) * (sngInput - 32)
            lblAnswer.Text = sngInput
        End If
    End Sub

    Private Sub mnuFahrenheit_Click(sender As Object, e As EventArgs) Handles mnuFahrenheit.Click
        Me.blnFahrenheit = False
        lblTempType.Text = "Celsius:"
        lblInputF.Visible = True
        lblCelsius.Visible = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub
End Class
