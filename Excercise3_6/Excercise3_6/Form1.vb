Public Class Form1
    Private Sub lblHello_Click(sender As Object, e As EventArgs) Handles lblHello.Click

    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        Me.lblHello.Visible = True
        Me.lblBye.Visible = False
    End Sub

    Private Sub btnBye_Click(sender As Object, e As EventArgs) Handles btnBye.Click
        Me.lblBye.Visible = True
        Me.lblHello.Visible = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub mnuGoodbye_Click(sender As Object, e As EventArgs) Handles mnuGoodbye.Click
        Me.lblBye.Visible = True
        Me.lblHello.Visible = False
    End Sub

    Private Sub mnuHello_Click(sender As Object, e As EventArgs) Handles mnuHello.Click
        Me.lblHello.Visible = True
        Me.lblBye.Visible = False
    End Sub
End Class
