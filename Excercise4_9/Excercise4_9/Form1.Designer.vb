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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpConversion = New System.Windows.Forms.GroupBox()
        Me.radMin2Sec = New System.Windows.Forms.RadioButton()
        Me.radHourMin = New System.Windows.Forms.RadioButton()
        Me.lblTimeSeconds = New System.Windows.Forms.Label()
        Me.lblHourMin = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.grpConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(12, 45)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(128, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter the time in minutes: "
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(146, 45)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(58, 20)
        Me.txtInput.TabIndex = 1
        '
        'grpConversion
        '
        Me.grpConversion.Controls.Add(Me.radHourMin)
        Me.grpConversion.Controls.Add(Me.radMin2Sec)
        Me.grpConversion.Location = New System.Drawing.Point(15, 89)
        Me.grpConversion.Name = "grpConversion"
        Me.grpConversion.Size = New System.Drawing.Size(257, 100)
        Me.grpConversion.TabIndex = 2
        Me.grpConversion.TabStop = False
        Me.grpConversion.Text = "Time Conversions"
        '
        'radMin2Sec
        '
        Me.radMin2Sec.AutoSize = True
        Me.radMin2Sec.Checked = True
        Me.radMin2Sec.Location = New System.Drawing.Point(6, 50)
        Me.radMin2Sec.Name = "radMin2Sec"
        Me.radMin2Sec.Size = New System.Drawing.Size(119, 17)
        Me.radMin2Sec.TabIndex = 0
        Me.radMin2Sec.TabStop = True
        Me.radMin2Sec.Text = "Minutes to Seconds"
        Me.radMin2Sec.UseVisualStyleBackColor = True
        '
        'radHourMin
        '
        Me.radHourMin.AutoSize = True
        Me.radHourMin.Location = New System.Drawing.Point(131, 50)
        Me.radHourMin.Name = "radHourMin"
        Me.radHourMin.Size = New System.Drawing.Size(115, 30)
        Me.radHourMin.TabIndex = 1
        Me.radHourMin.Text = "Minutes to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hour:Minute format"
        Me.radHourMin.UseVisualStyleBackColor = True
        '
        'lblTimeSeconds
        '
        Me.lblTimeSeconds.AutoSize = True
        Me.lblTimeSeconds.Location = New System.Drawing.Point(18, 208)
        Me.lblTimeSeconds.Name = "lblTimeSeconds"
        Me.lblTimeSeconds.Size = New System.Drawing.Size(115, 13)
        Me.lblTimeSeconds.TabIndex = 2
        Me.lblTimeSeconds.Text = "The time in seconds is:"
        '
        'lblHourMin
        '
        Me.lblHourMin.AutoSize = True
        Me.lblHourMin.Location = New System.Drawing.Point(18, 208)
        Me.lblHourMin.Name = "lblHourMin"
        Me.lblHourMin.Size = New System.Drawing.Size(162, 13)
        Me.lblHourMin.TabIndex = 3
        Me.lblHourMin.Text = "The time in hour:minute format is:"
        Me.lblHourMin.Visible = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(186, 208)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblHourMin)
        Me.Controls.Add(Me.lblTimeSeconds)
        Me.Controls.Add(Me.grpConversion)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpConversion.ResumeLayout(False)
        Me.grpConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents grpConversion As GroupBox
    Friend WithEvents radHourMin As RadioButton
    Friend WithEvents radMin2Sec As RadioButton
    Friend WithEvents lblTimeSeconds As Label
    Friend WithEvents lblHourMin As Label
    Friend WithEvents lblResult As Label
End Class
