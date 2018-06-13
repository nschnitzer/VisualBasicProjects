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
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Quarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblQuarterAmount = New System.Windows.Forms.Label()
        Me.lblDimeAmount = New System.Windows.Forms.Label()
        Me.lblNickelAmount = New System.Windows.Forms.Label()
        Me.lblPennyAmount = New System.Windows.Forms.Label()
        Me.btnCoins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(23, 61)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(144, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input the amount of change: "
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(172, 58)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(64, 20)
        Me.txtChange.TabIndex = 1
        '
        'Quarters
        '
        Me.Quarters.AutoSize = True
        Me.Quarters.Location = New System.Drawing.Point(23, 115)
        Me.Quarters.Name = "Quarters"
        Me.Quarters.Size = New System.Drawing.Size(50, 13)
        Me.Quarters.TabIndex = 2
        Me.Quarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(23, 143)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 3
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(23, 178)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(45, 13)
        Me.lblNickels.TabIndex = 4
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(23, 210)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 5
        Me.lblPennies.Text = "Pennies:"
        '
        'lblQuarterAmount
        '
        Me.lblQuarterAmount.AutoSize = True
        Me.lblQuarterAmount.Location = New System.Drawing.Point(79, 115)
        Me.lblQuarterAmount.Name = "lblQuarterAmount"
        Me.lblQuarterAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblQuarterAmount.TabIndex = 6
        '
        'lblDimeAmount
        '
        Me.lblDimeAmount.AutoSize = True
        Me.lblDimeAmount.Location = New System.Drawing.Point(92, 143)
        Me.lblDimeAmount.Name = "lblDimeAmount"
        Me.lblDimeAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblDimeAmount.TabIndex = 7
        '
        'lblNickelAmount
        '
        Me.lblNickelAmount.AutoSize = True
        Me.lblNickelAmount.Location = New System.Drawing.Point(92, 178)
        Me.lblNickelAmount.Name = "lblNickelAmount"
        Me.lblNickelAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblNickelAmount.TabIndex = 8
        '
        'lblPennyAmount
        '
        Me.lblPennyAmount.AutoSize = True
        Me.lblPennyAmount.Location = New System.Drawing.Point(92, 210)
        Me.lblPennyAmount.Name = "lblPennyAmount"
        Me.lblPennyAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblPennyAmount.TabIndex = 9
        '
        'btnCoins
        '
        Me.btnCoins.Location = New System.Drawing.Point(172, 200)
        Me.btnCoins.Name = "btnCoins"
        Me.btnCoins.Size = New System.Drawing.Size(75, 23)
        Me.btnCoins.TabIndex = 10
        Me.btnCoins.Text = "Coins"
        Me.btnCoins.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCoins)
        Me.Controls.Add(Me.lblPennyAmount)
        Me.Controls.Add(Me.lblNickelAmount)
        Me.Controls.Add(Me.lblDimeAmount)
        Me.Controls.Add(Me.lblQuarterAmount)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.Quarters)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInput As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Quarters As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblQuarterAmount As Label
    Friend WithEvents lblDimeAmount As Label
    Friend WithEvents lblNickelAmount As Label
    Friend WithEvents lblPennyAmount As Label
    Friend WithEvents btnCoins As Button
End Class
