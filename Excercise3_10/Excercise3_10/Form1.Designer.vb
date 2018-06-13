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
        Me.mnuProgram = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiddleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnnuMRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBCenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblText = New System.Windows.Forms.Label()
        Me.mnuProgram.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuProgram
        '
        Me.mnuProgram.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.PositionToolStripMenuItem})
        Me.mnuProgram.Location = New System.Drawing.Point(0, 0)
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(284, 24)
        Me.mnuProgram.TabIndex = 0
        Me.mnuProgram.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTop, Me.MiddleToolStripMenuItem, Me.BottomToolStripMenuItem})
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'mnuTop
        '
        Me.mnuTop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTLeft, Me.mnuTCenter, Me.mnuTRight})
        Me.mnuTop.Name = "mnuTop"
        Me.mnuTop.Size = New System.Drawing.Size(152, 22)
        Me.mnuTop.Text = "Top"
        '
        'MiddleToolStripMenuItem
        '
        Me.MiddleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMLeft, Me.mnuMCenter, Me.mnnuMRight})
        Me.MiddleToolStripMenuItem.Name = "MiddleToolStripMenuItem"
        Me.MiddleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MiddleToolStripMenuItem.Text = "Middle"
        '
        'BottomToolStripMenuItem
        '
        Me.BottomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBLeft, Me.mnuBCenter, Me.mnuBRight})
        Me.BottomToolStripMenuItem.Name = "BottomToolStripMenuItem"
        Me.BottomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BottomToolStripMenuItem.Text = "Bottom"
        '
        'mnuTLeft
        '
        Me.mnuTLeft.Name = "mnuTLeft"
        Me.mnuTLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuTLeft.Text = "Left"
        '
        'mnuTCenter
        '
        Me.mnuTCenter.Name = "mnuTCenter"
        Me.mnuTCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuTCenter.Text = "Center"
        '
        'mnuTRight
        '
        Me.mnuTRight.Name = "mnuTRight"
        Me.mnuTRight.Size = New System.Drawing.Size(152, 22)
        Me.mnuTRight.Text = "Right"
        '
        'mnuMLeft
        '
        Me.mnuMLeft.Name = "mnuMLeft"
        Me.mnuMLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuMLeft.Text = "Left"
        '
        'mnuMCenter
        '
        Me.mnuMCenter.Name = "mnuMCenter"
        Me.mnuMCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuMCenter.Text = "Center"
        '
        'mnnuMRight
        '
        Me.mnnuMRight.Name = "mnnuMRight"
        Me.mnnuMRight.Size = New System.Drawing.Size(152, 22)
        Me.mnnuMRight.Text = "Right"
        '
        'mnuBLeft
        '
        Me.mnuBLeft.Name = "mnuBLeft"
        Me.mnuBLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuBLeft.Text = "Left"
        '
        'mnuBCenter
        '
        Me.mnuBCenter.Name = "mnuBCenter"
        Me.mnuBCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuBCenter.Text = "Center"
        '
        'mnuBRight
        '
        Me.mnuBRight.Name = "mnuBRight"
        Me.mnuBRight.Size = New System.Drawing.Size(152, 22)
        Me.mnuBRight.Text = "Right"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(106, 113)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(71, 28)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "HERE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.mnuProgram)
        Me.MainMenuStrip = Me.mnuProgram
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.mnuProgram.ResumeLayout(False)
        Me.mnuProgram.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuProgram As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuTop As ToolStripMenuItem
    Friend WithEvents mnuTLeft As ToolStripMenuItem
    Friend WithEvents mnuTCenter As ToolStripMenuItem
    Friend WithEvents mnuTRight As ToolStripMenuItem
    Friend WithEvents MiddleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BottomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuMLeft As ToolStripMenuItem
    Friend WithEvents mnuMCenter As ToolStripMenuItem
    Friend WithEvents mnnuMRight As ToolStripMenuItem
    Friend WithEvents mnuBLeft As ToolStripMenuItem
    Friend WithEvents mnuBCenter As ToolStripMenuItem
    Friend WithEvents mnuBRight As ToolStripMenuItem
    Friend WithEvents lblText As Label
End Class
