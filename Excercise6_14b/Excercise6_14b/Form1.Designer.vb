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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.grpOption = New System.Windows.Forms.GroupBox()
        Me.radEncode = New System.Windows.Forms.RadioButton()
        Me.radDecode = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
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
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(57, 27)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(154, 31)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter a message"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'grpOption
        '
        Me.grpOption.Controls.Add(Me.radDecode)
        Me.grpOption.Controls.Add(Me.radEncode)
        Me.grpOption.Location = New System.Drawing.Point(35, 88)
        Me.grpOption.Name = "grpOption"
        Me.grpOption.Size = New System.Drawing.Size(200, 100)
        Me.grpOption.TabIndex = 2
        Me.grpOption.TabStop = False
        Me.grpOption.Text = "Options"
        '
        'radEncode
        '
        Me.radEncode.AutoSize = True
        Me.radEncode.Checked = True
        Me.radEncode.Location = New System.Drawing.Point(22, 52)
        Me.radEncode.Name = "radEncode"
        Me.radEncode.Size = New System.Drawing.Size(62, 17)
        Me.radEncode.TabIndex = 0
        Me.radEncode.TabStop = True
        Me.radEncode.Text = "Encode"
        Me.radEncode.UseVisualStyleBackColor = True
        '
        'radDecode
        '
        Me.radDecode.AutoSize = True
        Me.radDecode.Location = New System.Drawing.Point(101, 52)
        Me.radDecode.Name = "radDecode"
        Me.radDecode.Size = New System.Drawing.Size(63, 17)
        Me.radDecode.TabIndex = 1
        Me.radDecode.Text = "Decode"
        Me.radDecode.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(32, 218)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grpOption)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Caesar Cipher"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpOption.ResumeLayout(False)
        Me.grpOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnEnter As Button
    Friend WithEvents grpOption As GroupBox
    Friend WithEvents radEncode As RadioButton
    Friend WithEvents radDecode As RadioButton
    Friend WithEvents lblResult As Label
End Class
