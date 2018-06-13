Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpBands.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radBand2.CheckedChanged
        If (Me.radBand2.Checked = True) Then
            Me.lblBand2.Visible = True
        Else
            Me.lblBand2.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radBand4.CheckedChanged
        If (Me.radBand4.Checked = True) Then
            Me.lblBand4.Visible = True
        Else
            Me.lblBand4.Visible = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblBand1.Click

    End Sub

    Private Sub radBand1_EnabledChanged(sender As Object, e As EventArgs) Handles radBand1.EnabledChanged, radBand1.CheckedChanged
        If (radBand1.Checked = True) Then
            Me.lblBand1.Visible = True
        Else
            Me.lblBand1.Visible = False

        End If
    End Sub

    Private Sub radBand3_CheckedChanged(sender As Object, e As EventArgs) Handles radBand3.CheckedChanged
        If (Me.radBand3.Checked = True) Then
            Me.lblBand3.Visible = True
        Else
            Me.lblBand3.Visible = False
        End If
    End Sub

    Private Sub lblBand2_Click(sender As Object, e As EventArgs) Handles lblBand2.Click

    End Sub
End Class
