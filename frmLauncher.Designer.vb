<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLauncher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLauncher))
        Me.lblChooseAMode = New System.Windows.Forms.Label()
        Me.picWelcome = New System.Windows.Forms.PictureBox()
        Me.BorderRegion1 = New System.Windows.Forms.PictureBox()
        Me.cmsLauncherTopBorder = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorderRegion2 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion3 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion4 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion6 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion5 = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picSettings = New System.Windows.Forms.PictureBox()
        Me.picHelp = New System.Windows.Forms.PictureBox()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picSettingsMain = New System.Windows.Forms.PictureBox()
        Me.picHTPMain = New System.Windows.Forms.PictureBox()
        Me.picExitMain = New System.Windows.Forms.PictureBox()
        Me.picEasy = New System.Windows.Forms.PictureBox()
        Me.picMedium = New System.Windows.Forms.PictureBox()
        Me.picHard = New System.Windows.Forms.PictureBox()
        Me.picBackArrow = New System.Windows.Forms.PictureBox()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsLauncherTopBorder.SuspendLayout()
        CType(Me.BorderRegion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSettingsMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHTPMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChooseAMode
        '
        Me.lblChooseAMode.AutoSize = True
        Me.lblChooseAMode.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseAMode.ForeColor = System.Drawing.Color.White
        Me.lblChooseAMode.Location = New System.Drawing.Point(50, 58)
        Me.lblChooseAMode.Name = "lblChooseAMode"
        Me.lblChooseAMode.Size = New System.Drawing.Size(574, 23)
        Me.lblChooseAMode.TabIndex = 11
        Me.lblChooseAMode.Text = "Choose a gamemode! Higher tiers have less allotted time and higher difficulty."
        '
        'picWelcome
        '
        Me.picWelcome.BackColor = System.Drawing.Color.Transparent
        Me.picWelcome.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picWelcome_new
        Me.picWelcome.Location = New System.Drawing.Point(54, 12)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(385, 206)
        Me.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWelcome.TabIndex = 12
        Me.picWelcome.TabStop = False
        '
        'BorderRegion1
        '
        Me.BorderRegion1.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion1.ContextMenuStrip = Me.cmsLauncherTopBorder
        Me.BorderRegion1.Location = New System.Drawing.Point(0, 0)
        Me.BorderRegion1.Name = "BorderRegion1"
        Me.BorderRegion1.Size = New System.Drawing.Size(100, 93)
        Me.BorderRegion1.TabIndex = 13
        Me.BorderRegion1.TabStop = False
        '
        'cmsLauncherTopBorder
        '
        Me.cmsLauncherTopBorder.AccessibleName = ""
        Me.cmsLauncherTopBorder.BackColor = System.Drawing.Color.Black
        Me.cmsLauncherTopBorder.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.cmsLauncherTopBorder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.cmsMenuExit})
        Me.cmsLauncherTopBorder.Name = "ContextMenuStrip1"
        Me.cmsLauncherTopBorder.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsLauncherTopBorder.Size = New System.Drawing.Size(102, 48)
        '
        'menuFile
        '
        Me.menuFile.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSettings, Me.menuVersion})
        Me.menuFile.ForeColor = System.Drawing.Color.White
        Me.menuFile.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.cmsFileIconPic
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(101, 22)
        Me.menuFile.Text = "File"
        '
        'menuSettings
        '
        Me.menuSettings.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuSettings.ForeColor = System.Drawing.Color.White
        Me.menuSettings.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.SettingsIcon
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Size = New System.Drawing.Size(124, 22)
        Me.menuSettings.Text = "Settings"
        Me.menuSettings.ToolTipText = "Edit game settings."
        '
        'menuVersion
        '
        Me.menuVersion.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuVersion.ForeColor = System.Drawing.Color.White
        Me.menuVersion.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.HelpIcon
        Me.menuVersion.Name = "menuVersion"
        Me.menuVersion.Size = New System.Drawing.Size(124, 22)
        Me.menuVersion.Text = "Version"
        Me.menuVersion.ToolTipText = "View current version."
        '
        'cmsMenuExit
        '
        Me.cmsMenuExit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmsMenuExit.ForeColor = System.Drawing.Color.White
        Me.cmsMenuExit.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.CloseIconSmall
        Me.cmsMenuExit.Name = "cmsMenuExit"
        Me.cmsMenuExit.Size = New System.Drawing.Size(101, 22)
        Me.cmsMenuExit.Text = "Exit"
        Me.cmsMenuExit.ToolTipText = "Exit the game."
        '
        'BorderRegion2
        '
        Me.BorderRegion2.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion2.ContextMenuStrip = Me.cmsLauncherTopBorder
        Me.BorderRegion2.Location = New System.Drawing.Point(54, 0)
        Me.BorderRegion2.Name = "BorderRegion2"
        Me.BorderRegion2.Size = New System.Drawing.Size(385, 43)
        Me.BorderRegion2.TabIndex = 14
        Me.BorderRegion2.TabStop = False
        '
        'BorderRegion3
        '
        Me.BorderRegion3.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion3.ContextMenuStrip = Me.cmsLauncherTopBorder
        Me.BorderRegion3.Location = New System.Drawing.Point(414, 0)
        Me.BorderRegion3.Name = "BorderRegion3"
        Me.BorderRegion3.Size = New System.Drawing.Size(242, 55)
        Me.BorderRegion3.TabIndex = 15
        Me.BorderRegion3.TabStop = False
        '
        'BorderRegion4
        '
        Me.BorderRegion4.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion4.Location = New System.Drawing.Point(630, 54)
        Me.BorderRegion4.Name = "BorderRegion4"
        Me.BorderRegion4.Size = New System.Drawing.Size(29, 409)
        Me.BorderRegion4.TabIndex = 16
        Me.BorderRegion4.TabStop = False
        '
        'BorderRegion6
        '
        Me.BorderRegion6.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion6.Location = New System.Drawing.Point(0, 90)
        Me.BorderRegion6.Name = "BorderRegion6"
        Me.BorderRegion6.Size = New System.Drawing.Size(17, 373)
        Me.BorderRegion6.TabIndex = 17
        Me.BorderRegion6.TabStop = False
        '
        'BorderRegion5
        '
        Me.BorderRegion5.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion5.Location = New System.Drawing.Point(0, 447)
        Me.BorderRegion5.Name = "BorderRegion5"
        Me.BorderRegion5.Size = New System.Drawing.Size(656, 16)
        Me.BorderRegion5.TabIndex = 18
        Me.BorderRegion5.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.CloseIcon
        Me.picClose.Location = New System.Drawing.Point(604, 5)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(41, 44)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picClose.TabIndex = 19
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackColor = System.Drawing.Color.Transparent
        Me.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimize.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.MinimizeIcon
        Me.picMinimize.Location = New System.Drawing.Point(555, 5)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(41, 44)
        Me.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picMinimize.TabIndex = 20
        Me.picMinimize.TabStop = False
        '
        'picSettings
        '
        Me.picSettings.BackColor = System.Drawing.Color.Transparent
        Me.picSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSettings.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.SettingsIcon
        Me.picSettings.Location = New System.Drawing.Point(503, 5)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.Size = New System.Drawing.Size(41, 44)
        Me.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSettings.TabIndex = 21
        Me.picSettings.TabStop = False
        '
        'picHelp
        '
        Me.picHelp.BackColor = System.Drawing.Color.Transparent
        Me.picHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHelp.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.HelpIcon
        Me.picHelp.Location = New System.Drawing.Point(457, 6)
        Me.picHelp.Name = "picHelp"
        Me.picHelp.Size = New System.Drawing.Size(31, 40)
        Me.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picHelp.TabIndex = 22
        Me.picHelp.TabStop = False
        '
        'picPlay
        '
        Me.picPlay.BackColor = System.Drawing.Color.Transparent
        Me.picPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPlay.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.playButton
        Me.picPlay.Location = New System.Drawing.Point(106, 250)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(200, 65)
        Me.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlay.TabIndex = 23
        Me.picPlay.TabStop = False
        '
        'picSettingsMain
        '
        Me.picSettingsMain.BackColor = System.Drawing.Color.Transparent
        Me.picSettingsMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSettingsMain.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.SettingsButtonIcon
        Me.picSettingsMain.Location = New System.Drawing.Point(106, 329)
        Me.picSettingsMain.Name = "picSettingsMain"
        Me.picSettingsMain.Size = New System.Drawing.Size(200, 65)
        Me.picSettingsMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSettingsMain.TabIndex = 24
        Me.picSettingsMain.TabStop = False
        '
        'picHTPMain
        '
        Me.picHTPMain.BackColor = System.Drawing.Color.Transparent
        Me.picHTPMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHTPMain.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.htpButtonIcon
        Me.picHTPMain.Location = New System.Drawing.Point(371, 250)
        Me.picHTPMain.Name = "picHTPMain"
        Me.picHTPMain.Size = New System.Drawing.Size(200, 65)
        Me.picHTPMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHTPMain.TabIndex = 25
        Me.picHTPMain.TabStop = False
        '
        'picExitMain
        '
        Me.picExitMain.BackColor = System.Drawing.Color.Transparent
        Me.picExitMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExitMain.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.ExitButtonIcon
        Me.picExitMain.Location = New System.Drawing.Point(371, 329)
        Me.picExitMain.Name = "picExitMain"
        Me.picExitMain.Size = New System.Drawing.Size(200, 65)
        Me.picExitMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExitMain.TabIndex = 26
        Me.picExitMain.TabStop = False
        '
        'picEasy
        '
        Me.picEasy.BackColor = System.Drawing.Color.Transparent
        Me.picEasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEasy.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.EasyButtonIcon
        Me.picEasy.Location = New System.Drawing.Point(219, 99)
        Me.picEasy.Name = "picEasy"
        Me.picEasy.Size = New System.Drawing.Size(256, 87)
        Me.picEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEasy.TabIndex = 27
        Me.picEasy.TabStop = False
        '
        'picMedium
        '
        Me.picMedium.BackColor = System.Drawing.Color.Transparent
        Me.picMedium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMedium.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.MediumButtonIcon
        Me.picMedium.Location = New System.Drawing.Point(219, 205)
        Me.picMedium.Name = "picMedium"
        Me.picMedium.Size = New System.Drawing.Size(256, 87)
        Me.picMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMedium.TabIndex = 28
        Me.picMedium.TabStop = False
        '
        'picHard
        '
        Me.picHard.BackColor = System.Drawing.Color.Transparent
        Me.picHard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHard.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.HardButtonIcon
        Me.picHard.Location = New System.Drawing.Point(219, 307)
        Me.picHard.Name = "picHard"
        Me.picHard.Size = New System.Drawing.Size(256, 87)
        Me.picHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHard.TabIndex = 29
        Me.picHard.TabStop = False
        '
        'picBackArrow
        '
        Me.picBackArrow.BackColor = System.Drawing.Color.Transparent
        Me.picBackArrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBackArrow.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.backArrow
        Me.picBackArrow.Location = New System.Drawing.Point(12, 414)
        Me.picBackArrow.Name = "picBackArrow"
        Me.picBackArrow.Size = New System.Drawing.Size(60, 36)
        Me.picBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBackArrow.TabIndex = 31
        Me.picBackArrow.TabStop = False
        '
        'menuExit
        '
        Me.menuExit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.menuExit.ForeColor = System.Drawing.Color.White
        Me.menuExit.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.CloseIconSmall
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(152, 22)
        Me.menuExit.Text = "Exit"
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picBorder_Launcher
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(656, 462)
        Me.Controls.Add(Me.picBackArrow)
        Me.Controls.Add(Me.picExitMain)
        Me.Controls.Add(Me.picHTPMain)
        Me.Controls.Add(Me.picSettingsMain)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picWelcome)
        Me.Controls.Add(Me.picHelp)
        Me.Controls.Add(Me.picSettings)
        Me.Controls.Add(Me.picMinimize)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.BorderRegion4)
        Me.Controls.Add(Me.lblChooseAMode)
        Me.Controls.Add(Me.BorderRegion1)
        Me.Controls.Add(Me.BorderRegion2)
        Me.Controls.Add(Me.BorderRegion3)
        Me.Controls.Add(Me.BorderRegion5)
        Me.Controls.Add(Me.BorderRegion6)
        Me.Controls.Add(Me.picMedium)
        Me.Controls.Add(Me.picEasy)
        Me.Controls.Add(Me.picHard)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLauncher"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simon Says - Easy"
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsLauncherTopBorder.ResumeLayout(False)
        CType(Me.BorderRegion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSettingsMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHTPMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExitMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picWelcome As PictureBox
    Friend WithEvents lblChooseAMode As System.Windows.Forms.Label
    Friend WithEvents BorderRegion1 As PictureBox
    Friend WithEvents BorderRegion2 As PictureBox
    Friend WithEvents BorderRegion3 As PictureBox
    Friend WithEvents BorderRegion4 As PictureBox
    Friend WithEvents BorderRegion6 As PictureBox
    Friend WithEvents BorderRegion5 As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picSettings As PictureBox
    Friend WithEvents picHelp As PictureBox
    Friend WithEvents picPlay As PictureBox
    Friend WithEvents picSettingsMain As PictureBox
    Friend WithEvents picHTPMain As PictureBox
    Friend WithEvents picExitMain As PictureBox
    Friend WithEvents picEasy As PictureBox
    Friend WithEvents picMedium As PictureBox
    Friend WithEvents picHard As PictureBox
    Friend WithEvents picBackArrow As PictureBox
    Friend WithEvents cmsLauncherTopBorder As ContextMenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuSettings As ToolStripMenuItem
    Friend WithEvents menuVersion As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents cmsMenuExit As ToolStripMenuItem
End Class
