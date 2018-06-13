Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.lviewPeople.Columns.Add("People", 365, HorizontalAlignment.Left)
        Dim sngControl As Single
        Dim item As New ListViewItem("People", 1)
        Dim item2 As New ListViewItem("Odds", 2)
        lviewPeople.Items.AddRange(New ListViewItem() {item, item2})
        For sngControl = 0 To 365
            lviewPeople.Items.
        Next
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
End Class
