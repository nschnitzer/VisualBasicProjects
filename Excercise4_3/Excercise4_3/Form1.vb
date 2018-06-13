Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub blnCalc_Click(sender As Object, e As EventArgs) Handles blnCalc.Click
        Dim sngLength As Single = Val(txtLength.Text)
        Dim sngWidth As Single = Val(txtWidth.Text)

        Dim sngPerimeter As Single = (2 * sngLength) + (2 * sngWidth)
        Dim sngArea As Single = (sngLength * sngWidth)
        Me.lblArea.Text = sngArea
        Me.lblPerimeter.Text = sngPerimeter
    End Sub
End Class
