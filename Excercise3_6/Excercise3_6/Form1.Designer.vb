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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.btnBye = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.lblBye = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHello = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGoodbye = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(12, 177)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(108, 36)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'btnBye
        '
        Me.btnBye.Location = New System.Drawing.Point(139, 177)
        Me.btnBye.Name = "btnBye"
        Me.btnBye.Size = New System.Drawing.Size(122, 36)
        Me.btnBye.TabIndex = 1
        Me.btnBye.Text = "Goodbye"
        Me.btnBye.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(66, 84)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(125, 33)
        Me.lblHello.TabIndex = 2
        Me.lblHello.Text = "Hello!"
        Me.lblHello.Visible = False
        '
        'lblBye
        '
        Me.lblBye.AutoSize = True
        Me.lblBye.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBye.Location = New System.Drawing.Point(67, 84)
        Me.lblBye.Name = "lblBye"
        Me.lblBye.Size = New System.Drawing.Size(138, 26)
        Me.lblBye.TabIndex = 3
        Me.lblBye.Text = "Goodbye!"
        Me.lblBye.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHello, Me.mnuGoodbye, Me.mnuExit})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'mnuHello
        '
        Me.mnuHello.Name = "mnuHello"
        Me.mnuHello.Size = New System.Drawing.Size(152, 22)
        Me.mnuHello.Text = "Hello"
        '
        'mnuGoodbye
        '
        Me.mnuGoodbye.Name = "mnuGoodbye"
        Me.mnuGoodbye.Size = New System.Drawing.Size(152, 22)
        Me.mnuGoodbye.Text = "Goodbye"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblBye)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnBye)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHello As Button
    Friend WithEvents btnBye As Button
    Friend WithEvents lblHello As Label
    Friend WithEvents lblBye As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHello As ToolStripMenuItem
    Friend WithEvents mnuGoodbye As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
