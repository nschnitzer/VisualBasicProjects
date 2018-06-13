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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGreeting = New System.Windows.Forms.Button()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGoodMorning = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorningEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorningSpanish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorningHebrew = New System.Windows.Forms.ToolStripMenuItem()
        Me.EveningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEveningEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEveningSpanish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEveningHebrew = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHebrew = New System.Windows.Forms.Label()
        Me.lblMorningSpanish = New System.Windows.Forms.Label()
        Me.lblEveningSpanish = New System.Windows.Forms.Label()
        Me.lblMorningEnglish = New System.Windows.Forms.Label()
        Me.lblEveningEnglish = New System.Windows.Forms.Label()
        Me.lblAlertClick = New System.Windows.Forms.Label()
        Me.lblDontLeave = New System.Windows.Forms.Label()
        Me.radSunny = New System.Windows.Forms.RadioButton()
        Me.radCloudy = New System.Windows.Forms.RadioButton()
        Me.radButtonRaining = New System.Windows.Forms.RadioButton()
        Me.grpWeather = New System.Windows.Forms.GroupBox()
        Me.lblSunny = New System.Windows.Forms.Label()
        Me.lblCloudy = New System.Windows.Forms.Label()
        Me.lblRaining = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.grpWeather.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGreeting
        '
        Me.btnGreeting.Location = New System.Drawing.Point(87, 123)
        Me.btnGreeting.Name = "btnGreeting"
        Me.btnGreeting.Size = New System.Drawing.Size(115, 35)
        Me.btnGreeting.TabIndex = 0
        Me.btnGreeting.Text = "Press"
        Me.btnGreeting.UseVisualStyleBackColor = True
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Location = New System.Drawing.Point(115, 94)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(63, 13)
        Me.lblGreeting.TabIndex = 1
        Me.lblGreeting.Text = "What's Up?"
        Me.lblGreeting.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuGoodMorning, Me.EveningToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
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
        'mnuGoodMorning
        '
        Me.mnuGoodMorning.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMorningEnglish, Me.mnuMorningSpanish, Me.mnuMorningHebrew})
        Me.mnuGoodMorning.Name = "mnuGoodMorning"
        Me.mnuGoodMorning.Size = New System.Drawing.Size(65, 20)
        Me.mnuGoodMorning.Text = "Morning"
        '
        'mnuMorningEnglish
        '
        Me.mnuMorningEnglish.Name = "mnuMorningEnglish"
        Me.mnuMorningEnglish.Size = New System.Drawing.Size(152, 22)
        Me.mnuMorningEnglish.Text = "Good Morning"
        '
        'mnuMorningSpanish
        '
        Me.mnuMorningSpanish.Name = "mnuMorningSpanish"
        Me.mnuMorningSpanish.Size = New System.Drawing.Size(152, 22)
        Me.mnuMorningSpanish.Text = "Buenos Dias"
        '
        'mnuMorningHebrew
        '
        Me.mnuMorningHebrew.Name = "mnuMorningHebrew"
        Me.mnuMorningHebrew.Size = New System.Drawing.Size(152, 22)
        Me.mnuMorningHebrew.Text = "Shalom"
        '
        'EveningToolStripMenuItem
        '
        Me.EveningToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEveningEnglish, Me.mnuEveningSpanish, Me.mnuEveningHebrew})
        Me.EveningToolStripMenuItem.Name = "EveningToolStripMenuItem"
        Me.EveningToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EveningToolStripMenuItem.Text = "Evening"
        '
        'mnuEveningEnglish
        '
        Me.mnuEveningEnglish.Name = "mnuEveningEnglish"
        Me.mnuEveningEnglish.Size = New System.Drawing.Size(155, 22)
        Me.mnuEveningEnglish.Text = "Good Evening"
        '
        'mnuEveningSpanish
        '
        Me.mnuEveningSpanish.Name = "mnuEveningSpanish"
        Me.mnuEveningSpanish.Size = New System.Drawing.Size(155, 22)
        Me.mnuEveningSpanish.Text = "Buenas Noches"
        '
        'mnuEveningHebrew
        '
        Me.mnuEveningHebrew.Name = "mnuEveningHebrew"
        Me.mnuEveningHebrew.Size = New System.Drawing.Size(155, 22)
        Me.mnuEveningHebrew.Text = "Shalom"
        '
        'lblHebrew
        '
        Me.lblHebrew.AutoSize = True
        Me.lblHebrew.Location = New System.Drawing.Point(115, 94)
        Me.lblHebrew.Name = "lblHebrew"
        Me.lblHebrew.Size = New System.Drawing.Size(42, 13)
        Me.lblHebrew.TabIndex = 4
        Me.lblHebrew.Text = "Shalom"
        Me.lblHebrew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHebrew.Visible = False
        '
        'lblMorningSpanish
        '
        Me.lblMorningSpanish.AutoSize = True
        Me.lblMorningSpanish.Location = New System.Drawing.Point(111, 94)
        Me.lblMorningSpanish.Name = "lblMorningSpanish"
        Me.lblMorningSpanish.Size = New System.Drawing.Size(67, 13)
        Me.lblMorningSpanish.TabIndex = 5
        Me.lblMorningSpanish.Text = "Buenas Dias"
        Me.lblMorningSpanish.Visible = False
        '
        'lblEveningSpanish
        '
        Me.lblEveningSpanish.AutoSize = True
        Me.lblEveningSpanish.BackColor = System.Drawing.Color.Lime
        Me.lblEveningSpanish.Location = New System.Drawing.Point(103, 94)
        Me.lblEveningSpanish.Name = "lblEveningSpanish"
        Me.lblEveningSpanish.Size = New System.Drawing.Size(83, 13)
        Me.lblEveningSpanish.TabIndex = 6
        Me.lblEveningSpanish.Text = "Buenas Noches"
        Me.lblEveningSpanish.Visible = False
        '
        'lblMorningEnglish
        '
        Me.lblMorningEnglish.AutoSize = True
        Me.lblMorningEnglish.BackColor = System.Drawing.Color.Lime
        Me.lblMorningEnglish.Location = New System.Drawing.Point(103, 94)
        Me.lblMorningEnglish.Name = "lblMorningEnglish"
        Me.lblMorningEnglish.Size = New System.Drawing.Size(74, 13)
        Me.lblMorningEnglish.TabIndex = 7
        Me.lblMorningEnglish.Text = "Good Morning"
        Me.lblMorningEnglish.Visible = False
        '
        'lblEveningEnglish
        '
        Me.lblEveningEnglish.AutoSize = True
        Me.lblEveningEnglish.BackColor = System.Drawing.Color.Lime
        Me.lblEveningEnglish.Location = New System.Drawing.Point(103, 94)
        Me.lblEveningEnglish.Name = "lblEveningEnglish"
        Me.lblEveningEnglish.Size = New System.Drawing.Size(75, 13)
        Me.lblEveningEnglish.TabIndex = 8
        Me.lblEveningEnglish.Text = "Good Evening"
        Me.lblEveningEnglish.Visible = False
        '
        'lblAlertClick
        '
        Me.lblAlertClick.AutoSize = True
        Me.lblAlertClick.BackColor = System.Drawing.Color.Lime
        Me.lblAlertClick.Location = New System.Drawing.Point(127, 172)
        Me.lblAlertClick.Name = "lblAlertClick"
        Me.lblAlertClick.Size = New System.Drawing.Size(30, 13)
        Me.lblAlertClick.TabIndex = 9
        Me.lblAlertClick.Text = "Click"
        Me.lblAlertClick.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAlertClick.Visible = False
        '
        'lblDontLeave
        '
        Me.lblDontLeave.AutoSize = True
        Me.lblDontLeave.BackColor = System.Drawing.Color.Lime
        Me.lblDontLeave.Location = New System.Drawing.Point(113, 172)
        Me.lblDontLeave.Name = "lblDontLeave"
        Me.lblDontLeave.Size = New System.Drawing.Size(65, 13)
        Me.lblDontLeave.TabIndex = 10
        Me.lblDontLeave.Text = "Don't Leave"
        Me.lblDontLeave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblDontLeave.Visible = False
        '
        'radSunny
        '
        Me.radSunny.AutoSize = True
        Me.radSunny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSunny.ForeColor = System.Drawing.Color.Red
        Me.radSunny.Location = New System.Drawing.Point(6, 33)
        Me.radSunny.Name = "radSunny"
        Me.radSunny.Size = New System.Drawing.Size(60, 17)
        Me.radSunny.TabIndex = 11
        Me.radSunny.Text = "Sunny"
        Me.radSunny.UseVisualStyleBackColor = True
        '
        'radCloudy
        '
        Me.radCloudy.AutoSize = True
        Me.radCloudy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCloudy.ForeColor = System.Drawing.Color.Red
        Me.radCloudy.Location = New System.Drawing.Point(106, 33)
        Me.radCloudy.Name = "radCloudy"
        Me.radCloudy.Size = New System.Drawing.Size(63, 17)
        Me.radCloudy.TabIndex = 12
        Me.radCloudy.Text = "Cloudy"
        Me.radCloudy.UseVisualStyleBackColor = True
        '
        'radButtonRaining
        '
        Me.radButtonRaining.AutoSize = True
        Me.radButtonRaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonRaining.ForeColor = System.Drawing.Color.Red
        Me.radButtonRaining.Location = New System.Drawing.Point(211, 33)
        Me.radButtonRaining.Name = "radButtonRaining"
        Me.radButtonRaining.Size = New System.Drawing.Size(68, 17)
        Me.radButtonRaining.TabIndex = 13
        Me.radButtonRaining.Text = "Raining"
        Me.radButtonRaining.UseVisualStyleBackColor = True
        '
        'grpWeather
        '
        Me.grpWeather.BackColor = System.Drawing.Color.Transparent
        Me.grpWeather.Controls.Add(Me.radSunny)
        Me.grpWeather.Controls.Add(Me.radButtonRaining)
        Me.grpWeather.Controls.Add(Me.radCloudy)
        Me.grpWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWeather.ForeColor = System.Drawing.Color.Red
        Me.grpWeather.Location = New System.Drawing.Point(0, 208)
        Me.grpWeather.Name = "grpWeather"
        Me.grpWeather.Size = New System.Drawing.Size(284, 56)
        Me.grpWeather.TabIndex = 14
        Me.grpWeather.TabStop = False
        Me.grpWeather.Text = "Weather"
        '
        'lblSunny
        '
        Me.lblSunny.AutoSize = True
        Me.lblSunny.BackColor = System.Drawing.Color.Lime
        Me.lblSunny.Location = New System.Drawing.Point(86, 51)
        Me.lblSunny.Name = "lblSunny"
        Me.lblSunny.Size = New System.Drawing.Size(92, 13)
        Me.lblSunny.TabIndex = 15
        Me.lblSunny.Text = "It's Sunny Outside"
        Me.lblSunny.Visible = False
        '
        'lblCloudy
        '
        Me.lblCloudy.AutoSize = True
        Me.lblCloudy.BackColor = System.Drawing.Color.Lime
        Me.lblCloudy.Location = New System.Drawing.Point(84, 51)
        Me.lblCloudy.Name = "lblCloudy"
        Me.lblCloudy.Size = New System.Drawing.Size(94, 13)
        Me.lblCloudy.TabIndex = 16
        Me.lblCloudy.Text = "It's Cloudy Outside"
        Me.lblCloudy.Visible = False
        '
        'lblRaining
        '
        Me.lblRaining.AutoSize = True
        Me.lblRaining.BackColor = System.Drawing.Color.Lime
        Me.lblRaining.Location = New System.Drawing.Point(91, 51)
        Me.lblRaining.Name = "lblRaining"
        Me.lblRaining.Size = New System.Drawing.Size(98, 13)
        Me.lblRaining.TabIndex = 17
        Me.lblRaining.Text = "It's Raining Outside"
        Me.lblRaining.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblRaining.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblRaining)
        Me.Controls.Add(Me.lblCloudy)
        Me.Controls.Add(Me.lblSunny)
        Me.Controls.Add(Me.grpWeather)
        Me.Controls.Add(Me.lblDontLeave)
        Me.Controls.Add(Me.lblAlertClick)
        Me.Controls.Add(Me.lblEveningEnglish)
        Me.Controls.Add(Me.lblMorningEnglish)
        Me.Controls.Add(Me.lblEveningSpanish)
        Me.Controls.Add(Me.lblMorningSpanish)
        Me.Controls.Add(Me.lblHebrew)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.btnGreeting)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.grpWeather.ResumeLayout(False)
        Me.grpWeather.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGreeting As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuGoodMorning As ToolStripMenuItem
    Friend WithEvents mnuMorningEnglish As ToolStripMenuItem
    Friend WithEvents mnuMorningSpanish As ToolStripMenuItem
    Friend WithEvents mnuMorningHebrew As ToolStripMenuItem
    Friend WithEvents EveningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEveningEnglish As ToolStripMenuItem
    Friend WithEvents mnuEveningSpanish As ToolStripMenuItem
    Friend WithEvents mnuEveningHebrew As ToolStripMenuItem
    Friend WithEvents lblHebrew As Label
    Friend WithEvents lblMorningSpanish As Label
    Friend WithEvents lblEveningSpanish As Label
    Friend WithEvents lblMorningEnglish As Label
    Friend WithEvents lblEveningEnglish As Label
    Friend WithEvents lblAlertClick As Label
    Friend WithEvents lblDontLeave As Label
    Friend WithEvents radSunny As RadioButton
    Friend WithEvents radCloudy As RadioButton
    Friend WithEvents radButtonRaining As RadioButton
    Friend WithEvents grpWeather As GroupBox
    Friend WithEvents lblSunny As Label
    Friend WithEvents lblCloudy As Label
    Friend WithEvents lblRaining As Label
End Class
