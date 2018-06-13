Public Class Form2
    Dim sngNum As Single
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        sngNum = Rnd()
        If (sngNum < 0.3) Then
            Me.BackColor = Color.LimeGreen
        ElseIf sngNum < 0.5 Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Cyan
        End If
        Dim frm As Form2
        frm = New Form2
        frm.Timer1.Enabled = True
        frm.Show()
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        Dim frm As Form2
        frm = New Form2
        frm.Show()
        frm.Timer1.Start()
    End Sub
End Class