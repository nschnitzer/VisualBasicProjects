Public Class Form1
    Private Sub AssociativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssociativeToolStripMenuItem.Click
        Me.lblAssoc.Visible = True
        Me.lblComm.Visible = False
    End Sub

    Private Sub CommutitveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommutitveToolStripMenuItem.Click
        Me.lblComm.Visible = True
        Me.lblAssoc.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnComm_Click(sender As Object, e As EventArgs) Handles btnComm.Click
        Me.lblAssoc.Visible = False
        Me.lblComm.Visible = True
    End Sub

    Private Sub btnAssoc_Click(sender As Object, e As EventArgs) Handles btnAssoc.Click
        Me.lblAssoc.Visible = True
        Me.lblComm.Visible = False
    End Sub
End Class
