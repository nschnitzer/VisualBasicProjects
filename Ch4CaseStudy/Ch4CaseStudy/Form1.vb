Public Class Form1
    Dim sngOp1, sngOp2, sngAnswer As Single

    Private Sub txtOp1_TextChanged(sender As Object, e As EventArgs) Handles txtOp1.TextChanged
        sngOp1 = Me.txtOp1.Text
    End Sub

    Private Sub txtOp2_TextChanged(sender As Object, e As EventArgs) Handles txtOp2.TextChanged
        sngOp2 = Me.txtOp2.Text

    End Sub

    Private Sub radDiv_CheckedChanged(sender As Object, e As EventArgs) Handles radDiv.CheckedChanged
        If Me.radDiv.Checked = True Then
            sngAnswer = sngOp1 / sngOp2
            Me.lblAnswer.Text = sngAnswer
        End If
    End Sub

    Private Sub radintDiv_CheckedChanged(sender As Object, e As EventArgs) Handles radIntDiv.CheckedChanged
        If Me.radIntDiv.Checked = True Then
            sngAnswer = sngOp1 \ sngOp2
            Me.lblAnswer.Text = sngAnswer
        End If
    End Sub

    Private Sub radMod_CheckedChanged(sender As Object, e As EventArgs) Handles radMod.CheckedChanged
        If Me.radMod.Checked = True Then
            sngAnswer = sngOp1 Mod sngOp2
            Me.lblAnswer.Text = sngAnswer
        End If
    End Sub

    Private Sub radAdd_CheckedChanged(sender As Object, e As EventArgs) Handles radAdd.CheckedChanged
        If Me.radAdd.Checked = True Then
            sngAnswer = sngOp1 + sngOp2
            Me.lblAnswer.Text = sngAnswer
        End If
    End Sub

    Private Sub radSub_CheckedChanged(sender As Object, e As EventArgs) Handles radSub.CheckedChanged
        If Me.radSub.Checked = True Then
            sngAnswer = sngOp1 - sngOp2
            Me.lblAnswer.Text = sngAnswer
        End If
    End Sub

    Private Sub radMult_CheckedChanged(sender As Object, e As EventArgs) Handles radMult.CheckedChanged
        If Me.radMult.Checked = True Then
            sngAnswer = sngOp1 * sngOp2
            Me.lblAnswer.Text = sngAnswer
        End If

    End Sub

    Private Sub radExponent_CheckedChanged(sender As Object, e As EventArgs) Handles radExponent.CheckedChanged
        If Me.radExponent.Checked = True Then
            sngAnswer = sngOp1 ^ sngOp2
            Me.lblAnswer.Text = sngAnswer

        End If
    End Sub
End Class
