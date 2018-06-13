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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVowelsLabel = New System.Windows.Forms.Label()
        Me.lblVowels = New System.Windows.Forms.Label()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 77)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(59, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter Text:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(77, 74)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(156, 20)
        Me.txtInput.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 2
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
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblVowelsLabel
        '
        Me.lblVowelsLabel.AutoSize = True
        Me.lblVowelsLabel.Location = New System.Drawing.Point(100, 112)
        Me.lblVowelsLabel.Name = "lblVowelsLabel"
        Me.lblVowelsLabel.Size = New System.Drawing.Size(66, 13)
        Me.lblVowelsLabel.TabIndex = 3
        Me.lblVowelsLabel.Text = "# of Vowels:"
        '
        'lblVowels
        '
        Me.lblVowels.AutoSize = True
        Me.lblVowels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVowels.Location = New System.Drawing.Point(172, 112)
        Me.lblVowels.Name = "lblVowels"
        Me.lblVowels.Size = New System.Drawing.Size(0, 15)
        Me.lblVowels.TabIndex = 4
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(94, 140)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(102, 31)
        Me.btnCount.TabIndex = 5
        Me.btnCount.Text = "Count Vowels"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 183)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.lblVowels)
        Me.Controls.Add(Me.lblVowelsLabel)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblVowelsLabel As Label
    Friend WithEvents lblVowels As Label
    Friend WithEvents btnCount As Button
End Class
