Public Class Form1
    Private Sub txtChange_TextChanged(sender As Object, e As EventArgs) Handles txtChange.TextChanged
        ' Dim sngChange As Single = Val(txtChange.Text)
        'Dim sngQuarters As Single = sngChange \ 25
        'sngChange = sngChange - (sngQuarters * 25)
        'Dim sngDimes As Single = sngChange \ 10
        'sngChange = sngChange - (sngDimes * 10)
        'Dim sngNickel As Single = sngChange \ 5
        'sngChange = sngChange - (sngNickel * 5)

        '        Me.lblDimeAmount.Text = sngDimes
        '        Me.lblQuarterAmount.Text = sngQuarters
        '       Me.lblNickelAmount.Text = sngNickel
        '        Me.lblPennyAmount.Text = sngChange

    End Sub

    Private Sub btnCoins_Click(sender As Object, e As EventArgs) Handles btnCoins.Click
        Dim sngChange As Single = Val(txtChange.Text)
        Dim sngQuarters As Single = sngChange \ 25
        sngChange = sngChange - (sngQuarters * 25)
        Dim sngDimes As Single = sngChange \ 10
        sngChange = sngChange - (sngDimes * 10)
        Dim sngNickel As Single = sngChange \ 5
        sngChange = sngChange - (sngNickel * 5)

        Me.lblDimeAmount.Text = sngDimes
        Me.lblQuarterAmount.Text = sngQuarters
        Me.lblNickelAmount.Text = sngNickel
        Me.lblPennyAmount.Text = sngChange
    End Sub
End Class
