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
        Me.btnMonogram = New System.Windows.Forms.Button()
        Me.lblMonogram = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(34, 49)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(179, 26)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter your first name, middle name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and last name seperated by commas"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(22, 78)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(229, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnMonogram
        '
        Me.btnMonogram.Location = New System.Drawing.Point(22, 181)
        Me.btnMonogram.Name = "btnMonogram"
        Me.btnMonogram.Size = New System.Drawing.Size(75, 23)
        Me.btnMonogram.TabIndex = 2
        Me.btnMonogram.Text = "Monogram"
        Me.btnMonogram.UseVisualStyleBackColor = True
        '
        'lblMonogram
        '
        Me.lblMonogram.AutoSize = True
        Me.lblMonogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonogram.Location = New System.Drawing.Point(151, 186)
        Me.lblMonogram.Name = "lblMonogram"
        Me.lblMonogram.Size = New System.Drawing.Size(0, 25)
        Me.lblMonogram.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblMonogram)
        Me.Controls.Add(Me.btnMonogram)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnMonogram As Button
    Friend WithEvents lblMonogram As Label
End Class
