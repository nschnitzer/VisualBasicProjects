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
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.Replace = New System.Windows.Forms.Button()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(12, 69)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(81, 13)
        Me.lblSentence.TabIndex = 0
        Me.lblSentence.Text = "Enter Sentence"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(12, 100)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(14, 134)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(47, 13)
        Me.lblReplace.TabIndex = 2
        Me.lblReplace.Text = "Replace"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(99, 66)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(124, 20)
        Me.txtSentence.TabIndex = 3
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(59, 97)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 4
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(67, 131)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(100, 20)
        Me.txtReplace.TabIndex = 5
        '
        'Replace
        '
        Me.Replace.Location = New System.Drawing.Point(197, 134)
        Me.Replace.Name = "Replace"
        Me.Replace.Size = New System.Drawing.Size(75, 23)
        Me.Replace.TabIndex = 6
        Me.Replace.Text = "Button1"
        Me.Replace.UseVisualStyleBackColor = True
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Location = New System.Drawing.Point(22, 204)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(0, 13)
        Me.lblCompleted.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblCompleted)
        Me.Controls.Add(Me.Replace)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.lblReplace)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblSentence)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSentence As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblReplace As Label
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents Replace As Button
    Friend WithEvents lblCompleted As Label
End Class
