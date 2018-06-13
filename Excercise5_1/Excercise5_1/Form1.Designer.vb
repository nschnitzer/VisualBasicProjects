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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOneDigit = New System.Windows.Forms.Label()
        Me.lblTwoDigit = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(12, 68)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(179, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Please enter a number less than 100"
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
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(197, 65)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(36, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblOneDigit
        '
        Me.lblOneDigit.AutoSize = True
        Me.lblOneDigit.Location = New System.Drawing.Point(73, 170)
        Me.lblOneDigit.Name = "lblOneDigit"
        Me.lblOneDigit.Size = New System.Drawing.Size(118, 13)
        Me.lblOneDigit.TabIndex = 3
        Me.lblOneDigit.Text = "This number is one digit"
        Me.lblOneDigit.Visible = False
        '
        'lblTwoDigit
        '
        Me.lblTwoDigit.AutoSize = True
        Me.lblTwoDigit.Location = New System.Drawing.Point(70, 170)
        Me.lblTwoDigit.Name = "lblTwoDigit"
        Me.lblTwoDigit.Size = New System.Drawing.Size(121, 13)
        Me.lblTwoDigit.TabIndex = 4
        Me.lblTwoDigit.Text = "The number is two digits"
        Me.lblTwoDigit.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(186, 214)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblTwoDigit)
        Me.Controls.Add(Me.lblOneDigit)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOneDigit As Label
    Friend WithEvents lblTwoDigit As Label
    Friend WithEvents btnCheck As Button
End Class
