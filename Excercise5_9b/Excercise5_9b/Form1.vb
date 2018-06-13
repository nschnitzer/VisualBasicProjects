Public Class Form1
    Dim strUser1 As String = "Admin"
    Dim strPass1 As String = "Admin123"
    Dim strUser2 As String = "Default"
    Dim strPass2 As String = "Password"
    Dim strUser3 As String = "Guest"
    Dim strPass3 As String = "None"
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtPass.ResetText()
        txtUser.ResetText()
    End Sub

    Private Sub btnAuthenticate_Click(sender As Object, e As EventArgs) Handles btnAuthenticate.Click
        If txtUser.Text.ToString = strUser1 Then
            If txtPass.Text.ToString = strPass1 Then
                MessageBox.Show("User Authenticated... Welcome")
                txtPass.ResetText()
                txtUser.ResetText()
            Else
                MessageBox.Show("Credentials not recognized... Please try again")
                txtPass.ResetText()
                txtUser.ResetText()
            End If
        ElseIf txtUser.Text.ToString = strUser2 Then
            If txtPass.Text.ToString = strPass2 Then
                MessageBox.Show("User Authenticated... Welcome")
                txtPass.ResetText()
                txtUser.ResetText()
            Else
                MessageBox.Show("Credentials not recognized... Please try again")
                txtPass.ResetText()
                txtUser.ResetText()
            End If
        ElseIf txtUser.Text.ToString = strUser3 Then
            If txtPass.Text.ToString = strPass3 Then
                MessageBox.Show("User Authenticated... Welcome")
                txtPass.ResetText()
                txtUser.ResetText()
            Else
                MessageBox.Show("Credentials not recognized... Please try again")
                txtPass.ResetText()
                txtUser.ResetText()
            End If
        End If
    End Sub
End Class
