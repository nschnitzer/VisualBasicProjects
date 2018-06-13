Public Class Form1
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        Dim sngInput As Single = Val(txtInput.Text)
        If (Me.radMin2Sec.Checked = True) Then
            Me.lblHourMin.Visible = False
            Me.lblTimeSeconds.Visible = True
            Me.lblResult.Text = sngInput * 60
        Else
            Me.lblHourMin.Visible = True
            Me.lblTimeSeconds.Visible = True
            Dim sngHours As Single = (sngInput \ 60) Mod 24
            Dim sngMins As Single = sngInput Mod 60
            Me.lblResult.Text = sngHours.ToString + ":" + sngMins.ToString
        End If
    End Sub

    Private Sub radMin2Sec_CheckedChanged(sender As Object, e As EventArgs) Handles radMin2Sec.CheckedChanged
        Dim sngInput As Single = Val(txtInput.Text)
        If (Me.radMin2Sec.Checked = True) Then
            Me.lblHourMin.Visible = False
            Me.lblTimeSeconds.Visible = True
            Me.lblResult.Text = sngInput * 60
        Else
            Me.lblHourMin.Visible = True
            Me.lblTimeSeconds.Visible = True
            Dim sngHours As Single = (sngInput \ 60) Mod 24
            Dim sngMins As Single = sngInput Mod 60
            Me.lblResult.Text = sngHours.ToString + ":" + sngMins.ToString
        End If
    End Sub

    Private Sub radHourMin_CheckedChanged(sender As Object, e As EventArgs) Handles radHourMin.CheckedChanged
        Dim sngInput As Single = Val(txtInput.Text)
        If (Me.radMin2Sec.Checked = True) Then
            Me.lblHourMin.Visible = False
            Me.lblTimeSeconds.Visible = True
            Me.lblResult.Text = sngInput * 60
        Else
            Me.lblHourMin.Visible = True
            Me.lblTimeSeconds.Visible = True
            Dim sngHours As Single = (sngInput \ 60) Mod 24
            Dim sngMins As Single = sngInput Mod 60
            Me.lblResult.Text = sngHours.ToString + ":" + sngMins.ToString
        End If
    End Sub
End Class
