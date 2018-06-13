Public Class Form1
    Dim strUser1 As String = "Admin"
    Dim strPass1 As String = "Admin123"
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtUserID.ResetText()
        txtPassword.ResetText()
    End Sub

    Private Sub btnAuthenticate_Click(sender As Object, e As EventArgs) Handles btnAuthenticate.Click
        If txtUserID.Text.ToString = strUser1 Then
            If txtPassword.Text.ToString = strPass1 Then
                MessageBox.Show("User Authenticated... Welcome")
                txtUserID.ResetText()
                txtPassword.ResetText()
            Else
                MessageBox.Show("Incorrect Password... Please enter the login credentials correctly")
                txtPassword.ResetText()
                txtUserID.ResetText()
            End If
        Else
            MessageBox.Show("Incorrect Credentials... Please enter the login credentials correctly")
            txtPassword.ResetText()
            txtUserID.ResetText()
        End If
    End Sub
End Class
