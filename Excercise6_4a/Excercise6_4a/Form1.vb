Public Class Form1
    Dim sngMaxVal As Single = 0
    Dim sngMinVal As Single = 0
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Me.lblMax.Visible = False
        Me.lblMaxLabel.Visible = False
        Me.lblMinLabel.Visible = False
        Me.lblMin.Visible = False
        If sngMinVal = 0 And Val(txtInput.Text) <> 0 Then
            sngMinVal = Val(txtInput.Text)
        End If

        If Val(txtInput.Text) < sngMinVal Then
            sngMinVal = Val(txtInput.Text)
        ElseIf Val(txtInput.Text) > sngMaxVal Then
            sngMaxVal = Val(txtInput.Text)
        End If
        txtInput.ResetText()
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Me.lblMinLabel.Visible = True
        Me.lblMin.Text = sngMinVal.ToString
        Me.lblMin.Visible = True
        Me.lblMaxLabel.Visible = True
        Me.lblMax.Text = sngMaxVal.ToString
        Me.lblMax.Visible = True
    End Sub
End Class
