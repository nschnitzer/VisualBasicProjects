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
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.grpFixings = New System.Windows.Forms.GroupBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.lblPriceLabel = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.grpFixings.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(377, 24)
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
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Location = New System.Drawing.Point(12, 44)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(234, 100)
        Me.grpSize.TabIndex = 1
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Sandwich Size"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(6, 45)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(105, 45)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 1
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'grpFixings
        '
        Me.grpFixings.Controls.Add(Me.chkMayo)
        Me.grpFixings.Controls.Add(Me.chkCheese)
        Me.grpFixings.Controls.Add(Me.chkOnion)
        Me.grpFixings.Controls.Add(Me.chkMustard)
        Me.grpFixings.Controls.Add(Me.chkTomato)
        Me.grpFixings.Controls.Add(Me.chkLettuce)
        Me.grpFixings.Location = New System.Drawing.Point(12, 150)
        Me.grpFixings.Name = "grpFixings"
        Me.grpFixings.Size = New System.Drawing.Size(298, 100)
        Me.grpFixings.TabIndex = 2
        Me.grpFixings.TabStop = False
        Me.grpFixings.Text = "Fixings"
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(6, 19)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 0
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(91, 19)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 1
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(171, 19)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 2
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(6, 54)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 3
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(91, 54)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(171, 54)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 5
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'lblPriceLabel
        '
        Me.lblPriceLabel.AutoSize = True
        Me.lblPriceLabel.Location = New System.Drawing.Point(15, 272)
        Me.lblPriceLabel.Name = "lblPriceLabel"
        Me.lblPriceLabel.Size = New System.Drawing.Size(61, 13)
        Me.lblPriceLabel.TabIndex = 6
        Me.lblPriceLabel.Text = "Total Price:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(235, 272)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(96, 29)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(82, 272)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 321)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPriceLabel)
        Me.Controls.Add(Me.grpFixings)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpFixings.ResumeLayout(False)
        Me.grpFixings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpFixings As GroupBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkOnion As CheckBox
    Friend WithEvents chkMustard As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkMayo As CheckBox
    Friend WithEvents lblPriceLabel As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblPrice As Label
End Class
