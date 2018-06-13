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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtTempF = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTempC = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 94)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(176, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Enter the temperature in Fahrenheit:"
        '
        'txtTempF
        '
        Me.txtTempF.Location = New System.Drawing.Point(194, 91)
        Me.txtTempF.Name = "txtTempF"
        Me.txtTempF.Size = New System.Drawing.Size(37, 20)
        Me.txtTempF.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 151)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(139, 13)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "The Temperature in Celsius:"
        '
        'lblTempC
        '
        Me.lblTempC.AutoSize = True
        Me.lblTempC.Location = New System.Drawing.Point(157, 151)
        Me.lblTempC.Name = "lblTempC"
        Me.lblTempC.Size = New System.Drawing.Size(0, 13)
        Me.lblTempC.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(15, 188)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 38)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "To Celsius"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblTempC)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtTempF)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInput As Label
    Friend WithEvents txtTempF As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblTempC As Label
    Friend WithEvents btnConvert As Button
End Class
