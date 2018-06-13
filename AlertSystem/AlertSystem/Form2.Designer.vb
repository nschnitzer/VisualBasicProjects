<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUpgrade1 = New System.Windows.Forms.Label()
        Me.lblUpgrade3 = New System.Windows.Forms.Label()
        Me.lblUpgrade4 = New System.Windows.Forms.Label()
        Me.lblUpgrade2 = New System.Windows.Forms.Label()
        Me.lblUpgrade5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblUpgrade1
        '
        Me.lblUpgrade1.AutoSize = True
        Me.lblUpgrade1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade1.Location = New System.Drawing.Point(-1, 22)
        Me.lblUpgrade1.Name = "lblUpgrade1"
        Me.lblUpgrade1.Size = New System.Drawing.Size(283, 23)
        Me.lblUpgrade1.TabIndex = 0
        Me.lblUpgrade1.Text = "Upgrade to Windows 10"
        '
        'lblUpgrade3
        '
        Me.lblUpgrade3.AutoSize = True
        Me.lblUpgrade3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade3.Location = New System.Drawing.Point(-1, 91)
        Me.lblUpgrade3.Name = "lblUpgrade3"
        Me.lblUpgrade3.Size = New System.Drawing.Size(283, 23)
        Me.lblUpgrade3.TabIndex = 1
        Me.lblUpgrade3.Text = "Upgrade to Windows 10"
        '
        'lblUpgrade4
        '
        Me.lblUpgrade4.AutoSize = True
        Me.lblUpgrade4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade4.Location = New System.Drawing.Point(-1, 190)
        Me.lblUpgrade4.Name = "lblUpgrade4"
        Me.lblUpgrade4.Size = New System.Drawing.Size(283, 23)
        Me.lblUpgrade4.TabIndex = 2
        Me.lblUpgrade4.Text = "Upgrade to Windows 10"
        '
        'lblUpgrade2
        '
        Me.lblUpgrade2.AutoSize = True
        Me.lblUpgrade2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade2.Location = New System.Drawing.Point(-1, 59)
        Me.lblUpgrade2.Name = "lblUpgrade2"
        Me.lblUpgrade2.Size = New System.Drawing.Size(283, 23)
        Me.lblUpgrade2.TabIndex = 3
        Me.lblUpgrade2.Text = "Upgrade to Windows 10"
        '
        'lblUpgrade5
        '
        Me.lblUpgrade5.AutoSize = True
        Me.lblUpgrade5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade5.Location = New System.Drawing.Point(-1, 156)
        Me.lblUpgrade5.Name = "lblUpgrade5"
        Me.lblUpgrade5.Size = New System.Drawing.Size(283, 23)
        Me.lblUpgrade5.TabIndex = 4
        Me.lblUpgrade5.Text = "Upgrade to Windows 10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Upgrade to Windows 10"
        '
        'btnInstall
        '
        Me.btnInstall.Location = New System.Drawing.Point(118, 225)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(154, 33)
        Me.btnInstall.TabIndex = 6
        Me.btnInstall.Text = "Install Windows 10"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.HotPink
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUpgrade5)
        Me.Controls.Add(Me.lblUpgrade2)
        Me.Controls.Add(Me.lblUpgrade4)
        Me.Controls.Add(Me.lblUpgrade3)
        Me.Controls.Add(Me.lblUpgrade1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUpgrade1 As Label
    Friend WithEvents lblUpgrade3 As Label
    Friend WithEvents lblUpgrade4 As Label
    Friend WithEvents lblUpgrade2 As Label
    Friend WithEvents lblUpgrade5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInstall As Button
End Class
