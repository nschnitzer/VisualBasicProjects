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
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.txtJump1 = New System.Windows.Forms.TextBox()
        Me.txtJump2 = New System.Windows.Forms.TextBox()
        Me.txtJump3 = New System.Windows.Forms.TextBox()
        Me.txtJump4 = New System.Windows.Forms.TextBox()
        Me.btnAvg = New System.Windows.Forms.Button()
        Me.lblAverageLabel = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(12, 56)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(97, 13)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "Length of 1st jump:"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(12, 87)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(101, 13)
        Me.lblSecond.TabIndex = 2
        Me.lblSecond.Text = "Length of 2nd jump:"
        '
        'lblThird
        '
        Me.lblThird.AutoSize = True
        Me.lblThird.Location = New System.Drawing.Point(12, 114)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(98, 13)
        Me.lblThird.TabIndex = 3
        Me.lblThird.Text = "Length of 3rd jump:"
        '
        'lblFourth
        '
        Me.lblFourth.AutoSize = True
        Me.lblFourth.Location = New System.Drawing.Point(12, 139)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(96, 13)
        Me.lblFourth.TabIndex = 4
        Me.lblFourth.Text = "Length of 4th junp:"
        '
        'txtJump1
        '
        Me.txtJump1.Location = New System.Drawing.Point(114, 53)
        Me.txtJump1.Name = "txtJump1"
        Me.txtJump1.Size = New System.Drawing.Size(64, 20)
        Me.txtJump1.TabIndex = 5
        '
        'txtJump2
        '
        Me.txtJump2.Location = New System.Drawing.Point(115, 84)
        Me.txtJump2.Name = "txtJump2"
        Me.txtJump2.Size = New System.Drawing.Size(64, 20)
        Me.txtJump2.TabIndex = 6
        '
        'txtJump3
        '
        Me.txtJump3.Location = New System.Drawing.Point(115, 107)
        Me.txtJump3.Name = "txtJump3"
        Me.txtJump3.Size = New System.Drawing.Size(63, 20)
        Me.txtJump3.TabIndex = 7
        '
        'txtJump4
        '
        Me.txtJump4.Location = New System.Drawing.Point(114, 132)
        Me.txtJump4.Name = "txtJump4"
        Me.txtJump4.Size = New System.Drawing.Size(64, 20)
        Me.txtJump4.TabIndex = 8
        '
        'btnAvg
        '
        Me.btnAvg.Location = New System.Drawing.Point(175, 195)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(75, 23)
        Me.btnAvg.TabIndex = 9
        Me.btnAvg.Text = "Average"
        Me.btnAvg.UseVisualStyleBackColor = True
        '
        'lblAverageLabel
        '
        Me.lblAverageLabel.AutoSize = True
        Me.lblAverageLabel.Location = New System.Drawing.Point(12, 200)
        Me.lblAverageLabel.Name = "lblAverageLabel"
        Me.lblAverageLabel.Size = New System.Drawing.Size(50, 13)
        Me.lblAverageLabel.TabIndex = 10
        Me.lblAverageLabel.Text = "Average:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(68, 200)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAverageLabel)
        Me.Controls.Add(Me.btnAvg)
        Me.Controls.Add(Me.txtJump4)
        Me.Controls.Add(Me.txtJump3)
        Me.Controls.Add(Me.txtJump2)
        Me.Controls.Add(Me.txtJump1)
        Me.Controls.Add(Me.lblFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProgram As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblThird As Label
    Public WithEvents lblFourth As Label
    Friend WithEvents txtJump1 As TextBox
    Friend WithEvents txtJump2 As TextBox
    Friend WithEvents txtJump3 As TextBox
    Friend WithEvents txtJump4 As TextBox
    Friend WithEvents btnAvg As Button
    Friend WithEvents lblAverageLabel As Label
    Friend WithEvents lblAverage As Label
End Class
