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
        Me.lblInputF = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCelsius = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFahrenheit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTempType = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInputF
        '
        Me.lblInputF.AutoSize = True
        Me.lblInputF.Location = New System.Drawing.Point(26, 107)
        Me.lblInputF.Name = "lblInputF"
        Me.lblInputF.Size = New System.Drawing.Size(175, 13)
        Me.lblInputF.TabIndex = 0
        Me.lblInputF.Text = "Input the temperature in Fahrenheit:"
        Me.lblInputF.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCelsius, Me.mnuFahrenheit, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuCelsius
        '
        Me.mnuCelsius.Name = "mnuCelsius"
        Me.mnuCelsius.Size = New System.Drawing.Size(152, 22)
        Me.mnuCelsius.Text = "Celsius"
        '
        'mnuFahrenheit
        '
        Me.mnuFahrenheit.Name = "mnuFahrenheit"
        Me.mnuFahrenheit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFahrenheit.Text = "Fahrenheit"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblCelsius
        '
        Me.lblCelsius.AutoSize = True
        Me.lblCelsius.Location = New System.Drawing.Point(26, 107)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(159, 13)
        Me.lblCelsius.TabIndex = 2
        Me.lblCelsius.Text = "Enter the temperature in Celsius:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(207, 100)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(36, 20)
        Me.txtInput.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(38, 183)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(78, 13)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Temperature in"
        '
        'lblTempType
        '
        Me.lblTempType.AutoSize = True
        Me.lblTempType.Location = New System.Drawing.Point(113, 183)
        Me.lblTempType.Name = "lblTempType"
        Me.lblTempType.Size = New System.Drawing.Size(60, 13)
        Me.lblTempType.TabIndex = 6
        Me.lblTempType.Text = "Fahrenheit:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(179, 183)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblTempType)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblCelsius)
        Me.Controls.Add(Me.lblInputF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputF As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuCelsius As ToolStripMenuItem
    Friend WithEvents mnuFahrenheit As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblCelsius As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblTempType As Label
    Friend WithEvents lblAnswer As Label
End Class
