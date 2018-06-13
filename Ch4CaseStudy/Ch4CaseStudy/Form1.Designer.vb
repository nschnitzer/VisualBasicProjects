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
        Me.lblOperand1 = New System.Windows.Forms.Label()
        Me.lblOperand2 = New System.Windows.Forms.Label()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.grpOperations = New System.Windows.Forms.GroupBox()
        Me.radSub = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radMod = New System.Windows.Forms.RadioButton()
        Me.radIntDiv = New System.Windows.Forms.RadioButton()
        Me.radDiv = New System.Windows.Forms.RadioButton()
        Me.radMult = New System.Windows.Forms.RadioButton()
        Me.radExponent = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.grpOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOperand1
        '
        Me.lblOperand1.AutoSize = True
        Me.lblOperand1.Location = New System.Drawing.Point(85, 46)
        Me.lblOperand1.Name = "lblOperand1"
        Me.lblOperand1.Size = New System.Drawing.Size(70, 13)
        Me.lblOperand1.TabIndex = 0
        Me.lblOperand1.Text = "First Operand"
        '
        'lblOperand2
        '
        Me.lblOperand2.AutoSize = True
        Me.lblOperand2.Location = New System.Drawing.Point(264, 46)
        Me.lblOperand2.Name = "lblOperand2"
        Me.lblOperand2.Size = New System.Drawing.Size(91, 13)
        Me.lblOperand2.TabIndex = 1
        Me.lblOperand2.Text = "Second Operand:"
        '
        'txtOp1
        '
        Me.txtOp1.Location = New System.Drawing.Point(173, 43)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(45, 20)
        Me.txtOp1.TabIndex = 2
        '
        'txtOp2
        '
        Me.txtOp2.Location = New System.Drawing.Point(360, 43)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(41, 20)
        Me.txtOp2.TabIndex = 3
        '
        'grpOperations
        '
        Me.grpOperations.Controls.Add(Me.radSub)
        Me.grpOperations.Controls.Add(Me.radAdd)
        Me.grpOperations.Controls.Add(Me.radMod)
        Me.grpOperations.Controls.Add(Me.radIntDiv)
        Me.grpOperations.Controls.Add(Me.radDiv)
        Me.grpOperations.Controls.Add(Me.radMult)
        Me.grpOperations.Controls.Add(Me.radExponent)
        Me.grpOperations.Location = New System.Drawing.Point(88, 84)
        Me.grpOperations.Name = "grpOperations"
        Me.grpOperations.Size = New System.Drawing.Size(336, 100)
        Me.grpOperations.TabIndex = 4
        Me.grpOperations.TabStop = False
        Me.grpOperations.Text = "Operations"
        '
        'radSub
        '
        Me.radSub.AutoSize = True
        Me.radSub.Location = New System.Drawing.Point(293, 48)
        Me.radSub.Name = "radSub"
        Me.radSub.Size = New System.Drawing.Size(28, 17)
        Me.radSub.TabIndex = 6
        Me.radSub.TabStop = True
        Me.radSub.Text = "-"
        Me.radSub.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(248, 48)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(31, 17)
        Me.radAdd.TabIndex = 5
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "+"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radMod
        '
        Me.radMod.AutoSize = True
        Me.radMod.Location = New System.Drawing.Point(187, 48)
        Me.radMod.Name = "radMod"
        Me.radMod.Size = New System.Drawing.Size(46, 17)
        Me.radMod.TabIndex = 4
        Me.radMod.TabStop = True
        Me.radMod.Text = "Mod"
        Me.radMod.UseVisualStyleBackColor = True
        '
        'radIntDiv
        '
        Me.radIntDiv.AutoSize = True
        Me.radIntDiv.Location = New System.Drawing.Point(138, 48)
        Me.radIntDiv.Name = "radIntDiv"
        Me.radIntDiv.Size = New System.Drawing.Size(30, 17)
        Me.radIntDiv.TabIndex = 3
        Me.radIntDiv.TabStop = True
        Me.radIntDiv.Text = "\"
        Me.radIntDiv.UseVisualStyleBackColor = True
        '
        'radDiv
        '
        Me.radDiv.AutoSize = True
        Me.radDiv.Location = New System.Drawing.Point(93, 48)
        Me.radDiv.Name = "radDiv"
        Me.radDiv.Size = New System.Drawing.Size(30, 17)
        Me.radDiv.TabIndex = 2
        Me.radDiv.TabStop = True
        Me.radDiv.Text = "/"
        Me.radDiv.UseVisualStyleBackColor = True
        '
        'radMult
        '
        Me.radMult.AutoSize = True
        Me.radMult.Location = New System.Drawing.Point(46, 48)
        Me.radMult.Name = "radMult"
        Me.radMult.Size = New System.Drawing.Size(29, 17)
        Me.radMult.TabIndex = 1
        Me.radMult.TabStop = True
        Me.radMult.Text = "*"
        Me.radMult.UseVisualStyleBackColor = True
        '
        'radExponent
        '
        Me.radExponent.AutoSize = True
        Me.radExponent.Location = New System.Drawing.Point(0, 48)
        Me.radExponent.Name = "radExponent"
        Me.radExponent.Size = New System.Drawing.Size(31, 17)
        Me.radExponent.TabIndex = 0
        Me.radExponent.TabStop = True
        Me.radExponent.Text = "^"
        Me.radExponent.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(85, 216)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Result:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(131, 216)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 261)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grpOperations)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtOp1)
        Me.Controls.Add(Me.lblOperand2)
        Me.Controls.Add(Me.lblOperand1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpOperations.ResumeLayout(False)
        Me.grpOperations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOperand1 As Label
    Friend WithEvents lblOperand2 As Label
    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents grpOperations As GroupBox
    Friend WithEvents radSub As RadioButton
    Friend WithEvents radAdd As RadioButton
    Friend WithEvents radMod As RadioButton
    Friend WithEvents radIntDiv As RadioButton
    Friend WithEvents radDiv As RadioButton
    Friend WithEvents radMult As RadioButton
    Friend WithEvents radExponent As RadioButton
    Friend WithEvents lblResult As Label
    Friend WithEvents lblAnswer As Label
End Class
