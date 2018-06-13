Public Class Form1
    Private Sub Replace_Click(sender As Object, e As EventArgs) Handles Replace.Click
        Dim strSentence As String = txtSentence.Text
        Dim strSearch As String = txtSearch.Text
        Dim strReplace As String = txtReplace.Text

        Dim strAltered As String = strSentence.Replace(strSearch, strReplace)
        Me.lblCompleted.Text = strAltered
    End Sub
End Class
