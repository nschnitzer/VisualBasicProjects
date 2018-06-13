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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkWaiting = New System.Windows.Forms.CheckBox()
        Me.chkForward = New System.Windows.Forms.CheckBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
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
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkID)
        Me.grpOptions.Controls.Add(Me.chkForward)
        Me.grpOptions.Controls.Add(Me.chkWaiting)
        Me.grpOptions.Location = New System.Drawing.Point(52, 40)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(157, 155)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Please Select"
        '
        'chkWaiting
        '
        Me.chkWaiting.AutoSize = True
        Me.chkWaiting.Location = New System.Drawing.Point(20, 31)
        Me.chkWaiting.Name = "chkWaiting"
        Me.chkWaiting.Size = New System.Drawing.Size(82, 17)
        Me.chkWaiting.TabIndex = 2
        Me.chkWaiting.Text = "Call Waiting"
        Me.chkWaiting.UseVisualStyleBackColor = True
        '
        'chkForward
        '
        Me.chkForward.AutoSize = True
        Me.chkForward.Location = New System.Drawing.Point(20, 69)
        Me.chkForward.Name = "chkForward"
        Me.chkForward.Size = New System.Drawing.Size(98, 17)
        Me.chkForward.TabIndex = 3
        Me.chkForward.Text = "Call Forwarding"
        Me.chkForward.UseVisualStyleBackColor = True
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Location = New System.Drawing.Point(21, 108)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(66, 17)
        Me.chkID.TabIndex = 4
        Me.chkID.Text = "Caller ID"
        Me.chkID.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(52, 211)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(170, 216)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkID As CheckBox
    Friend WithEvents chkForward As CheckBox
    Friend WithEvents chkWaiting As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblPrice As Label
End Class
