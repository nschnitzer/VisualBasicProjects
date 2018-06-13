Public Class Form1
    Private Sub btnAssoc_Click(sender As Object, e As EventArgs) Handles btnAssoc.Click
        Me.lblAssoc.Visible = True
        Me.lblComm.Visible = False

    End Sub

    Private Sub btnComm_Click(sender As Object, e As EventArgs) Handles btnComm.Click
        Me.lblComm.Visible = True
        Me.lblAssoc.Visible = False
    End Sub
End Class
