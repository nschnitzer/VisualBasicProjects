Public Class Form1
    Private Sub MiddleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuTCenter.Click
        Me.lblText.Location = New Point(100, 25)

    End Sub

    Private Sub TopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuMLeft.Click
        Me.lblText.Location = New Point(8, 115)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuTLeft_Click(sender As Object, e As EventArgs) Handles mnuTLeft.Click
        Me.lblText.Location = New Point(8, 25)

    End Sub

    Private Sub mnuTRight_Click(sender As Object, e As EventArgs) Handles mnuTRight.Click
        Me.lblText.Location = New Point(200, 25)

    End Sub

    Private Sub mnuMCenter_Click(sender As Object, e As EventArgs) Handles mnuMCenter.Click
        Me.lblText.Location = New Point(100, 115)

    End Sub

    Private Sub mnnuMRight_Click(sender As Object, e As EventArgs) Handles mnnuMRight.Click
        Me.lblText.Location = New Point(200, 115)
    End Sub

    Private Sub mnuBLeft_Click(sender As Object, e As EventArgs) Handles mnuBLeft.Click
        Me.lblText.Location = New Point(8, 215)
    End Sub

    Private Sub mnuBCenter_Click(sender As Object, e As EventArgs) Handles mnuBCenter.Click
        Me.lblText.Location = New Point(100, 215)
    End Sub

    Private Sub mnuBRight_Click(sender As Object, e As EventArgs) Handles mnuBRight.Click
        Me.lblText.Location = New Point(200, 215)
    End Sub
End Class
