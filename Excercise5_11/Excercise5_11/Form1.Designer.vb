<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.num1 = New System.Windows.Forms.Label()
        Me.op1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblOp1 = New System.Windows.Forms.Label()
        Me.lbNum2 = New System.Windows.Forms.Label()
        Me.lblEqualSign = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnNewProb = New System.Windows.Forms.Button()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(460, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "Exit"
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Location = New System.Drawing.Point(63, 58)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(0, 13)
        Me.num1.TabIndex = 1
        '
        'op1
        '
        Me.op1.AutoSize = True
        Me.op1.Location = New System.Drawing.Point(97, 58)
        Me.op1.Name = "op1"
        Me.op1.Size = New System.Drawing.Size(0, 13)
        Me.op1.TabIndex = 2
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(119, 58)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(0, 13)
        Me.lblNum2.TabIndex = 6
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(63, 58)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(0, 13)
        Me.lblNum1.TabIndex = 4
        '
        'lblOp1
        '
        Me.lblOp1.AutoSize = True
        Me.lblOp1.Location = New System.Drawing.Point(97, 58)
        Me.lblOp1.Name = "lblOp1"
        Me.lblOp1.Size = New System.Drawing.Size(0, 13)
        Me.lblOp1.TabIndex = 5
        '
        'lbNum2
        '
        Me.lbNum2.AutoSize = True
        Me.lbNum2.Location = New System.Drawing.Point(162, 58)
        Me.lbNum2.Name = "lbNum2"
        Me.lbNum2.Size = New System.Drawing.Size(0, 13)
        Me.lbNum2.TabIndex = 3
        '
        'lblEqualSign
        '
        Me.lblEqualSign.AutoSize = True
        Me.lblEqualSign.Location = New System.Drawing.Point(140, 58)
        Me.lblEqualSign.Name = "lblEqualSign"
        Me.lblEqualSign.Size = New System.Drawing.Size(13, 13)
        Me.lblEqualSign.TabIndex = 7
        Me.lblEqualSign.Text = "="
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(165, 55)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(36, 20)
        Me.txtInput.TabIndex = 8
        '
        'btnNewProb
        '
        Me.btnNewProb.Location = New System.Drawing.Point(302, 27)
        Me.btnNewProb.Name = "btnNewProb"
        Me.btnNewProb.Size = New System.Drawing.Size(107, 23)
        Me.btnNewProb.TabIndex = 9
        Me.btnNewProb.Text = "New Problem"
        Me.btnNewProb.UseVisualStyleBackColor = True
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(302, 58)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(107, 23)
        Me.btnCheckAnswer.TabIndex = 10
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(302, 98)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(107, 23)
        Me.btnShowAnswer.TabIndex = 11
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(44, 103)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(0, 13)
        Me.lblResponse.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 132)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.btnNewProb)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEqualSign)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblOp1)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.lbNum2)
        Me.Controls.Add(Me.op1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents num1 As Label
    Friend WithEvents op1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblOp1 As Label
    Friend WithEvents lbNum2 As Label
    Friend WithEvents lblEqualSign As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnNewProb As Button
    Friend WithEvents btnCheckAnswer As Button
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents lblResponse As Label
End Class
