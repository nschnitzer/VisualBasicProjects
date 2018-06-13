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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblDigit1 = New System.Windows.Forms.Label()
        Me.lblDigit2 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(12, 57)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(138, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Please enter a 2 digit value:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(173, 54)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(64, 20)
        Me.txtInput.TabIndex = 1
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(12, 112)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(53, 13)
        Me.lblFirst.TabIndex = 2
        Me.lblFirst.Text = "First Digit:"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(12, 142)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(71, 13)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Second Digit:"
        '
        'lblDigit1
        '
        Me.lblDigit1.AutoSize = True
        Me.lblDigit1.Location = New System.Drawing.Point(71, 112)
        Me.lblDigit1.Name = "lblDigit1"
        Me.lblDigit1.Size = New System.Drawing.Size(0, 13)
        Me.lblDigit1.TabIndex = 4
        '
        'lblDigit2
        '
        Me.lblDigit2.AutoSize = True
        Me.lblDigit2.Location = New System.Drawing.Point(89, 142)
        Me.lblDigit2.Name = "lblDigit2"
        Me.lblDigit2.Size = New System.Drawing.Size(0, 13)
        Me.lblDigit2.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(103, 184)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Digits"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblDigit2)
        Me.Controls.Add(Me.lblDigit1)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblDigit1 As Label
    Friend WithEvents lblDigit2 As Label
    Friend WithEvents btnCalc As Button
End Class
