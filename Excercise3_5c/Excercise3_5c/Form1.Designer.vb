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
        Me.lblAssoc = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssociativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommutitveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAssoc = New System.Windows.Forms.Button()
        Me.btnComm = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAssoc
        '
        Me.lblAssoc.AutoSize = True
        Me.lblAssoc.Location = New System.Drawing.Point(102, 142)
        Me.lblAssoc.Name = "lblAssoc"
        Me.lblAssoc.Size = New System.Drawing.Size(115, 13)
        Me.lblAssoc.TabIndex = 0
        Me.lblAssoc.Text = "(a + b) + c = a + (b + c)"
        Me.lblAssoc.Visible = False
        '
        'lblComm
        '
        Me.lblComm.AutoSize = True
        Me.lblComm.Location = New System.Drawing.Point(102, 142)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(67, 13)
        Me.lblComm.TabIndex = 1
        Me.lblComm.Text = "a + b = b + a"
        Me.lblComm.Visible = False
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
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssociativeToolStripMenuItem, Me.CommutitveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'AssociativeToolStripMenuItem
        '
        Me.AssociativeToolStripMenuItem.Name = "AssociativeToolStripMenuItem"
        Me.AssociativeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AssociativeToolStripMenuItem.Text = "Associative"
        '
        'CommutitveToolStripMenuItem
        '
        Me.CommutitveToolStripMenuItem.Name = "CommutitveToolStripMenuItem"
        Me.CommutitveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CommutitveToolStripMenuItem.Text = "Commutative"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnAssoc
        '
        Me.btnAssoc.Location = New System.Drawing.Point(35, 195)
        Me.btnAssoc.Name = "btnAssoc"
        Me.btnAssoc.Size = New System.Drawing.Size(97, 32)
        Me.btnAssoc.TabIndex = 3
        Me.btnAssoc.Text = "Associative"
        Me.btnAssoc.UseVisualStyleBackColor = True
        '
        'btnComm
        '
        Me.btnComm.Location = New System.Drawing.Point(161, 195)
        Me.btnComm.Name = "btnComm"
        Me.btnComm.Size = New System.Drawing.Size(96, 32)
        Me.btnComm.TabIndex = 4
        Me.btnComm.Text = "Commutative"
        Me.btnComm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnComm)
        Me.Controls.Add(Me.btnAssoc)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.lblAssoc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAssoc As Label
    Friend WithEvents lblComm As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuProgram As ToolStripMenuItem
    Friend WithEvents AssociativeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommutitveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAssoc As Button
    Friend WithEvents btnComm As Button
End Class
