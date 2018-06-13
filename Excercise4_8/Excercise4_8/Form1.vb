Public Class Form1
    'Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
    'Dim sngInput As Single = Val(txtInput.Text)
    'Dim sngTens As Single = sngInput \ 10
    'Dim sngOnes As Single = sngInput - (sngTens * 10)
    'If sngTens = 0 Then
    'Me.lblDigit1.Text = sngOnes
    'Me.lblDigit2.Text = ""
    'Else
    'Me.lblDigit1.Text = sngTens
    'Me.lblDigit2.Text = sngOnes
    'End If
    'End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim sngInput As Single = Val(txtInput.Text)
        Dim sngTens As Single = sngInput \ 10
        Dim sngOnes As Single = sngInput - (sngTens * 10)
        If sngTens = 0 Then
            Me.lblDigit1.Text = sngOnes
            Me.lblDigit2.Text = ""
        Else
            Me.lblDigit1.Text = sngTens
            Me.lblDigit2.Text = sngOnes
        End If
    End Sub
End Class
