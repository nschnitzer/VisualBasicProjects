Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Me.lblGreeting.Visible = True
    End Sub

    Private Sub ShalomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuEveningHebrew.Click
        Me.lblHebrew.Visible = True
        Me.lblEveningEnglish.Visible = False
        Me.lblEveningSpanish.Visible = False
        Me.lblMorningEnglish.Visible = False
        Me.lblMorningSpanish.Visible = False
        Me.lblGreeting.Visible = False


    End Sub

    Private Sub lblGreeting_Click(sender As Object, e As EventArgs) Handles lblGreeting.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMorningSpanish.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblEveningEnglish.Click

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub mnuMorningEnglish_Click(sender As Object, e As EventArgs) Handles mnuMorningEnglish.Click
        Me.lblHebrew.Visible = False
        Me.lblEveningEnglish.Visible = False
        Me.lblEveningSpanish.Visible = False
        Me.lblMorningEnglish.Visible = True
        Me.lblMorningSpanish.Visible = False
        Me.lblGreeting.Visible = False
    End Sub

    Private Sub mnuMorningSpanish_Click(sender As Object, e As EventArgs) Handles mnuMorningSpanish.Click
        Me.lblHebrew.Visible = False
        Me.lblEveningEnglish.Visible = False
        Me.lblEveningSpanish.Visible = False
        Me.lblMorningEnglish.Visible = False
        Me.lblMorningSpanish.Visible = True
        Me.lblGreeting.Visible = False
    End Sub

    Private Sub mnuMorningHebrew_Click(sender As Object, e As EventArgs) Handles mnuMorningHebrew.Click
        Me.lblHebrew.Visible = True
        Me.lblEveningEnglish.Visible = False
        Me.lblEveningSpanish.Visible = False
        Me.lblMorningEnglish.Visible = False
        Me.lblMorningSpanish.Visible = False
        Me.lblGreeting.Visible = False

    End Sub

    Private Sub mnuEveningEnglish_Click(sender As Object, e As EventArgs) Handles mnuEveningEnglish.Click
        Me.lblHebrew.Visible = False
        Me.lblEveningEnglish.Visible = True
        Me.lblEveningSpanish.Visible = False
        Me.lblMorningEnglish.Visible = False
        Me.lblMorningSpanish.Visible = False
        Me.lblGreeting.Visible = False

    End Sub

    Private Sub mnuEveningSpanish_Click(sender As Object, e As EventArgs)
        Me.lblHebrew.Visible = False
        Me.lblEveningEnglish.Visible = False
        Me.lblEveningSpanish.Visible = True
        Me.lblMorningEnglish.Visible = False
        Me.lblMorningSpanish.Visible = False
        Me.lblGreeting.Visible = False

    End Sub

    Private Sub btnGreeting_MouseHover(sender As Object, e As EventArgs) Handles btnGreeting.MouseHover, mnuMorningSpanish.MouseHover, mnuMorningHebrew.MouseHover, mnuMorningEnglish.MouseHover, mnuEveningEnglish.MouseHover, mnuEveningSpanish.MouseHover, mnuEveningHebrew.MouseHover
        Me.lblAlertClick.Visible = True

    End Sub

    Private Sub btnGreeting_MouseLeave(sender As Object, e As EventArgs) Handles btnGreeting.MouseLeave, mnuMorningSpanish.MouseLeave, mnuMorningHebrew.MouseLeave, mnuMorningEnglish.MouseLeave, mnuEveningEnglish.MouseLeave, mnuEveningSpanish.MouseLeave, mnuEveningHebrew.MouseLeave
        Me.lblAlertClick.Visible = False

    End Sub

    Private Sub mnuEveningSpanish_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuExit_MouseHover(sender As Object, e As EventArgs) Handles mnuExit.MouseHover
        Me.lblDontLeave.Visible = True

    End Sub

    Private Sub mnuExit_MouseLeave(sender As Object, e As EventArgs) Handles mnuExit.MouseLeave
        Me.lblDontLeave.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radSunny.CheckedChanged
        If Me.radSunny.Checked = True Then
            Me.lblSunny.Visible = True
        Else
            Me.lblSunny.Visible = False
        End If


    End Sub

    Private Sub radCloudy_CheckedChanged(sender As Object, e As EventArgs) Handles radCloudy.CheckedChanged
        If Me.radCloudy.Checked = True Then
            Me.lblCloudy.Visible = True
        Else
            Me.lblCloudy.Visible = False
        End If
    End Sub

    Private Sub radButtonRaining_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonRaining.CheckedChanged
        If Me.radButtonRaining.Checked = True Then
            Me.lblRaining.Visible = True

        Else
            Me.lblRaining.Visible = True

        End If
    End Sub
End Class
