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
        Me.lblLengthPrompt = New System.Windows.Forms.Label()
        Me.lblWidthPrompt = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblPerimeterLabel = New System.Windows.Forms.Label()
        Me.lblAreaLabel = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.blnCalc = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLengthPrompt
        '
        Me.lblLengthPrompt.AutoSize = True
        Me.lblLengthPrompt.Location = New System.Drawing.Point(22, 76)
        Me.lblLengthPrompt.Name = "lblLengthPrompt"
        Me.lblLengthPrompt.Size = New System.Drawing.Size(119, 13)
        Me.lblLengthPrompt.TabIndex = 0
        Me.lblLengthPrompt.Text = "Please enter the length:"
        '
        'lblWidthPrompt
        '
        Me.lblWidthPrompt.AutoSize = True
        Me.lblWidthPrompt.Location = New System.Drawing.Point(22, 109)
        Me.lblWidthPrompt.Name = "lblWidthPrompt"
        Me.lblWidthPrompt.Size = New System.Drawing.Size(115, 13)
        Me.lblWidthPrompt.TabIndex = 1
        Me.lblWidthPrompt.Text = "Please enter the width:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(147, 73)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(62, 20)
        Me.txtLength.TabIndex = 3
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(147, 99)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(62, 20)
        Me.txtWidth.TabIndex = 4
        '
        'lblPerimeterLabel
        '
        Me.lblPerimeterLabel.AutoSize = True
        Me.lblPerimeterLabel.Location = New System.Drawing.Point(22, 168)
        Me.lblPerimeterLabel.Name = "lblPerimeterLabel"
        Me.lblPerimeterLabel.Size = New System.Drawing.Size(57, 13)
        Me.lblPerimeterLabel.TabIndex = 5
        Me.lblPerimeterLabel.Text = "Perimeter: "
        '
        'lblAreaLabel
        '
        Me.lblAreaLabel.AutoSize = True
        Me.lblAreaLabel.Location = New System.Drawing.Point(22, 196)
        Me.lblAreaLabel.Name = "lblAreaLabel"
        Me.lblAreaLabel.Size = New System.Drawing.Size(35, 13)
        Me.lblAreaLabel.TabIndex = 6
        Me.lblAreaLabel.Text = "Area: "
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(85, 168)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(0, 13)
        Me.lblPerimeter.TabIndex = 7
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(85, 196)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 13)
        Me.lblArea.TabIndex = 8
        '
        'blnCalc
        '
        Me.blnCalc.Location = New System.Drawing.Point(174, 177)
        Me.blnCalc.Name = "blnCalc"
        Me.blnCalc.Size = New System.Drawing.Size(75, 23)
        Me.blnCalc.TabIndex = 9
        Me.blnCalc.Text = "Calculate"
        Me.blnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.blnCalc)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblAreaLabel)
        Me.Controls.Add(Me.lblPerimeterLabel)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblWidthPrompt)
        Me.Controls.Add(Me.lblLengthPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLengthPrompt As Label
    Friend WithEvents lblWidthPrompt As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProgram As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblPerimeterLabel As Label
    Friend WithEvents lblAreaLabel As Label
    Friend WithEvents lblPerimeter As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents blnCalc As Button
End Class
