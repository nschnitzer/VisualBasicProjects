Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strChars(txtInput.Text.Length) As Char
        Dim sngLength As Single = txtInput.Text.Length
        strChars = txtInput.Text.ToCharArray()

        Dim sngCounter As Single
        For sngCounter = 0 To sngLength - 1
            Me.lblUnicode.Text = String.Concat(Me.lblUnicode.Text, strChars(sngCounter).ToString, ": ", AscW(strChars(sngCounter)).ToString) & "    "

        Next sngCounter
    End Sub
End Class
