Public Class Form1

    Dim blnMult As Boolean = False
    Dim blnDiv As Boolean = False
    Dim blnAdd As Boolean = False
    Dim blnSub As Boolean = False
    Dim sngAnswer As Single

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.lblNum1.Text = Int(10 * Rnd())
        Randomize()
        Me.lblNum2.Text = Int(10 * Rnd())
        Randomize()
        Dim sngRand As Single = Int(3 * Rnd())
        If sngRand = 0 Then
            Me.lblOp1.Text = "*"
            blnMult = True
        ElseIf sngRand = 1 Then
            Me.lblOp1.Text = "/"
            blnDiv = True
        ElseIf sngRand = 2 Then
            Me.lblOp1.Text = "+"
            blnAdd = True
        Else
            Me.lblOp1.Text = "-"
            blnAdd = True
        End If
    End Sub

    Private Sub btnNewProb_Click(sender As Object, e As EventArgs) Handles btnNewProb.Click
        blnAdd = False
        blnDiv = False
        blnMult = False
        blnSub = False

        Randomize()
        Me.lblNum1.Text = Int(10 * Rnd())
        Randomize()
        Me.lblNum2.Text = Int(10 * Rnd())
        Randomize()
        Dim sngRand As Single = Int(3 * Rnd())
        If sngRand = 0 Then
            Me.lblOp1.Text = "*"
            blnMult = True
        ElseIf sngRand = 1 Then
            Me.lblOp1.Text = "/"
            blnDiv = True
        ElseIf sngRand = 2 Then
            Me.lblOp1.Text = "+"
            blnAdd = True
        Else
            Me.lblOp1.Text = "-"
            blnAdd = True
        End If

        txtInput.ResetText()
    End Sub

    Private Sub btnCheckAnswer_Click(sender As Object, e As EventArgs) Handles btnCheckAnswer.Click
        If blnMult = True Then
            sngAnswer = Val(lblNum1.Text) * Val(lblNum2.Text)
        ElseIf blnDiv = True Then
            sngAnswer = Val(lblNum1.Text) \ Val(lblNum2.Text)
        ElseIf blnAdd = True Then
            sngAnswer = Val(lblNum1.Text) + Val(lblNum2.Text)
        Else
            sngAnswer = Val(lblNum1.Text) - Val(lblNum2.Text)
        End If

        If Val(txtInput.Text) = sngAnswer Then
            lblResponse.Text = "That is the correct answer"
        Else
            lblResponse.Text = "That is an incorrect answer"
        End If
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        If blnMult = True Then
            sngAnswer = Val(lblNum1.Text) * Val(lblNum2.Text)
        ElseIf blnDiv = True Then
            sngAnswer = Val(lblNum1.Text) \ Val(lblNum2.Text)
        ElseIf blnAdd = True Then
            sngAnswer = Val(lblNum1.Text) + Val(lblNum2.Text)
        Else
            sngAnswer = Val(lblNum1.Text) - Val(lblNum2.Text)
        End If
        Me.lblResponse.Text = sngAnswer
    End Sub
End Class
