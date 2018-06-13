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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.lblMinLabel = New System.Windows.Forms.Label()
        Me.lblMaxLabel = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(22, 61)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(66, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter Score:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(99, 58)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(25, 165)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter Score"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(143, 165)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(75, 23)
        Me.btnStats.TabIndex = 3
        Me.btnStats.Text = "Statistics"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'lblMinLabel
        '
        Me.lblMinLabel.AutoSize = True
        Me.lblMinLabel.Location = New System.Drawing.Point(22, 110)
        Me.lblMinLabel.Name = "lblMinLabel"
        Me.lblMinLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblMinLabel.TabIndex = 4
        Me.lblMinLabel.Text = "Min Score:"
        Me.lblMinLabel.Visible = False
        '
        'lblMaxLabel
        '
        Me.lblMaxLabel.AutoSize = True
        Me.lblMaxLabel.Location = New System.Drawing.Point(140, 110)
        Me.lblMaxLabel.Name = "lblMaxLabel"
        Me.lblMaxLabel.Size = New System.Drawing.Size(61, 13)
        Me.lblMaxLabel.TabIndex = 5
        Me.lblMaxLabel.Text = "Max Score:"
        Me.lblMaxLabel.Visible = False
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(86, 110)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(0, 13)
        Me.lblMin.TabIndex = 6
        Me.lblMin.Visible = False
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(207, 110)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(0, 13)
        Me.lblMax.TabIndex = 7
        Me.lblMax.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblMaxLabel)
        Me.Controls.Add(Me.lblMinLabel)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents lblMinLabel As Label
    Friend WithEvents lblMaxLabel As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblMax As Label
End Class
