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
        Me.grpBands = New System.Windows.Forms.GroupBox()
        Me.radBand4 = New System.Windows.Forms.RadioButton()
        Me.radBand3 = New System.Windows.Forms.RadioButton()
        Me.radBand2 = New System.Windows.Forms.RadioButton()
        Me.radBand1 = New System.Windows.Forms.RadioButton()
        Me.lblBand1 = New System.Windows.Forms.Label()
        Me.lblBand2 = New System.Windows.Forms.Label()
        Me.lblBand3 = New System.Windows.Forms.Label()
        Me.lblBand4 = New System.Windows.Forms.Label()
        Me.grpBands.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBands
        '
        Me.grpBands.Controls.Add(Me.radBand4)
        Me.grpBands.Controls.Add(Me.radBand3)
        Me.grpBands.Controls.Add(Me.radBand2)
        Me.grpBands.Controls.Add(Me.radBand1)
        Me.grpBands.Location = New System.Drawing.Point(12, 12)
        Me.grpBands.Name = "grpBands"
        Me.grpBands.Size = New System.Drawing.Size(108, 237)
        Me.grpBands.TabIndex = 0
        Me.grpBands.TabStop = False
        Me.grpBands.Text = "Bands"
        '
        'radBand4
        '
        Me.radBand4.AutoSize = True
        Me.radBand4.Location = New System.Drawing.Point(0, 179)
        Me.radBand4.Name = "radBand4"
        Me.radBand4.Size = New System.Drawing.Size(106, 17)
        Me.radBand4.TabIndex = 3
        Me.radBand4.TabStop = True
        Me.radBand4.Text = "Black Eyed Peas"
        Me.radBand4.UseVisualStyleBackColor = True
        '
        'radBand3
        '
        Me.radBand3.AutoSize = True
        Me.radBand3.Location = New System.Drawing.Point(0, 119)
        Me.radBand3.Name = "radBand3"
        Me.radBand3.Size = New System.Drawing.Size(82, 17)
        Me.radBand3.TabIndex = 2
        Me.radBand3.TabStop = True
        Me.radBand3.Text = "The Beatles"
        Me.radBand3.UseVisualStyleBackColor = True
        '
        'radBand2
        '
        Me.radBand2.AutoSize = True
        Me.radBand2.Location = New System.Drawing.Point(3, 80)
        Me.radBand2.Name = "radBand2"
        Me.radBand2.Size = New System.Drawing.Size(90, 17)
        Me.radBand2.TabIndex = 1
        Me.radBand2.TabStop = True
        Me.radBand2.Text = "One Direction"
        Me.radBand2.UseVisualStyleBackColor = True
        '
        'radBand1
        '
        Me.radBand1.AutoSize = True
        Me.radBand1.Checked = True
        Me.radBand1.Location = New System.Drawing.Point(0, 41)
        Me.radBand1.Name = "radBand1"
        Me.radBand1.Size = New System.Drawing.Size(113, 17)
        Me.radBand1.TabIndex = 0
        Me.radBand1.TabStop = True
        Me.radBand1.Text = "The Chainsmokers"
        Me.radBand1.UseVisualStyleBackColor = True
        '
        'lblBand1
        '
        Me.lblBand1.AutoSize = True
        Me.lblBand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand1.Location = New System.Drawing.Point(126, 92)
        Me.lblBand1.Name = "lblBand1"
        Me.lblBand1.Size = New System.Drawing.Size(159, 72)
        Me.lblBand1.TabIndex = 4
        Me.lblBand1.Text = "Alex Paul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Andrew Taggart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBand2
        '
        Me.lblBand2.AutoSize = True
        Me.lblBand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand2.Location = New System.Drawing.Point(119, 92)
        Me.lblBand2.Name = "lblBand2"
        Me.lblBand2.Size = New System.Drawing.Size(164, 96)
        Me.lblBand2.TabIndex = 5
        Me.lblBand2.Text = "Harry Styles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Liam Payne" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nial Horan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Louis Tomlinson"
        Me.lblBand2.Visible = False
        '
        'lblBand3
        '
        Me.lblBand3.AutoSize = True
        Me.lblBand3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand3.Location = New System.Drawing.Point(118, 92)
        Me.lblBand3.Name = "lblBand3"
        Me.lblBand3.Size = New System.Drawing.Size(165, 96)
        Me.lblBand3.TabIndex = 6
        Me.lblBand3.Text = "Paul McCartney" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ringo Star" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "John Lennon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "George Harrison"
        Me.lblBand3.Visible = False
        '
        'lblBand4
        '
        Me.lblBand4.AutoSize = True
        Me.lblBand4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand4.Location = New System.Drawing.Point(119, 116)
        Me.lblBand4.Name = "lblBand4"
        Me.lblBand4.Size = New System.Drawing.Size(92, 72)
        Me.lblBand4.TabIndex = 7
        Me.lblBand4.Text = "Fergie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Will.I.Am" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Taboo"
        Me.lblBand4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblBand4)
        Me.Controls.Add(Me.lblBand3)
        Me.Controls.Add(Me.lblBand2)
        Me.Controls.Add(Me.lblBand1)
        Me.Controls.Add(Me.grpBands)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpBands.ResumeLayout(False)
        Me.grpBands.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBands As GroupBox
    Friend WithEvents radBand4 As RadioButton
    Friend WithEvents radBand3 As RadioButton
    Friend WithEvents radBand2 As RadioButton
    Friend WithEvents radBand1 As RadioButton
    Friend WithEvents lblBand1 As Label
    Friend WithEvents lblBand2 As Label
    Friend WithEvents lblBand3 As Label
    Friend WithEvents lblBand4 As Label
End Class
