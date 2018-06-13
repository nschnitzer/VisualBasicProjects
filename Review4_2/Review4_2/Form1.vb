Public Class Form1
    Dim sngRadius As Single
    Dim sngArea As Single
    Const sngPI As Single = 3.14
    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        sngRadius = Val(Me.txtRadius.Text)
        sngArea = sngPI * (sngRadius ^ 2)
        lblResult.Text = sngArea

    End Sub
End Class
