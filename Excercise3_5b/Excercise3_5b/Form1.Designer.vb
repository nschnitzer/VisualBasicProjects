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
        Me.btnAssoc = New System.Windows.Forms.Button()
        Me.btnComm = New System.Windows.Forms.Button()
        Me.lblAssoc = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAssoc
        '
        Me.btnAssoc.Location = New System.Drawing.Point(12, 190)
        Me.btnAssoc.Name = "btnAssoc"
        Me.btnAssoc.Size = New System.Drawing.Size(110, 40)
        Me.btnAssoc.TabIndex = 0
        Me.btnAssoc.Text = "Associative"
        Me.btnAssoc.UseVisualStyleBackColor = True
        '
        'btnComm
        '
        Me.btnComm.Location = New System.Drawing.Point(153, 190)
        Me.btnComm.Name = "btnComm"
        Me.btnComm.Size = New System.Drawing.Size(119, 40)
        Me.btnComm.TabIndex = 1
        Me.btnComm.Text = "Commutative"
        Me.btnComm.UseVisualStyleBackColor = True
        '
        'lblAssoc
        '
        Me.lblAssoc.AutoSize = True
        Me.lblAssoc.Location = New System.Drawing.Point(94, 95)
        Me.lblAssoc.Name = "lblAssoc"
        Me.lblAssoc.Size = New System.Drawing.Size(115, 13)
        Me.lblAssoc.TabIndex = 2
        Me.lblAssoc.Text = "(a + b) + c = a + (b + c)"
        Me.lblAssoc.Visible = False
        '
        'lblComm
        '
        Me.lblComm.AutoSize = True
        Me.lblComm.Location = New System.Drawing.Point(109, 95)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(67, 13)
        Me.lblComm.TabIndex = 3
        Me.lblComm.Text = "a + b = b + a"
        Me.lblComm.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.lblAssoc)
        Me.Controls.Add(Me.btnComm)
        Me.Controls.Add(Me.btnAssoc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAssoc As Button
    Friend WithEvents btnComm As Button
    Friend WithEvents lblAssoc As Label
    Friend WithEvents lblComm As Label
End Class
