Public Class Form1
    Dim sngTokens As Single
    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click
        sngTokens = sngTokens - 1
        Me.lblTokens.Text = sngTokens
        Dim sngRandom As Single
        Dim sngFirst As Single
        Dim sngSecond As Single
        Dim sngThird As Single
        Randomize()
        Dim sngCounter As Single
        For sngCounter = 0 To 2
            sngRandom = Rnd() * 10

            If sngRandom <= 3.3 Then
                If sngCounter = 0 Then
                    sngFirst = 1
                    Me.lblNum1.Text = 1
                ElseIf sngCounter = 1 Then
                    sngSecond = 1
                    Me.lblNum2.Text = 1
                Else
                    sngThird = 1
                    Me.lblNum3.Text = 1
                End If
            ElseIf sngRandom <= 6.6 Then
                If sngCounter = 0 Then
                    sngFirst = 2
                    Me.lblNum1.Text = 2
                ElseIf sngCounter = 1 Then
                    sngSecond = 2
                    Me.lblNum2.Text = 2
                Else
                    sngThird = 2
                    Me.lblNum3.Text = 2
                End If
            Else
                If sngCounter = 0 Then
                    sngFirst = 3
                    Me.lblNum1.Text = 3
                ElseIf sngCounter = 1 Then
                    sngSecond = 3
                    Me.lblNum2.Text = 3
                Else
                    sngThird = 3
                    Me.lblNum3.Text = 3
                End If
            End If
        Next sngCounter

        If sngFirst = 1 And sngSecond = 1 And sngThird = 1 Then
            sngTokens = sngTokens + 4
            MessageBox.Show("You get 4 tokens")
            Me.lblTokens.Text = sngTokens
        ElseIf sngFirst = 2 And sngSecond = 2 And sngThird = 2 Then
            sngTokens = sngTokens + 8
            MessageBox.Show("You get 8 tokens")
            Me.lblTokens.Text = sngTokens
        ElseIf sngFirst = 3 And sngSecond = 3 And sngThird = 3 Then
            sngTokens = sngTokens + 12
            MessageBox.Show("You get 12 tokens")
            Me.lblTokens.Text = sngTokens
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sngTokens = 100
        Me.lblTokens.Text = 100
    End Sub

    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        sngTokens = 100
        Me.lblTokens.Text = 100
    End Sub
End Class
