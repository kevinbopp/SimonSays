<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEasy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEasy))
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picBlack4 = New System.Windows.Forms.PictureBox()
        Me.picBlackSquare = New System.Windows.Forms.PictureBox()
        Me.picGreen_Clicked = New System.Windows.Forms.PictureBox()
        Me.picRed_Clicked = New System.Windows.Forms.PictureBox()
        Me.picBlue_Clicked = New System.Windows.Forms.PictureBox()
        Me.picYellow_Clicked = New System.Windows.Forms.PictureBox()
        Me.picBlack3 = New System.Windows.Forms.PictureBox()
        Me.picGreen = New System.Windows.Forms.PictureBox()
        Me.picRed = New System.Windows.Forms.PictureBox()
        Me.picBlue = New System.Windows.Forms.PictureBox()
        Me.picYellow = New System.Windows.Forms.PictureBox()
        Me.picBlack1 = New System.Windows.Forms.PictureBox()
        Me.picBlack2 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.tmrLessTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.lblPrepareToStart = New System.Windows.Forms.Label()
        Me.lblCurrentLevel = New System.Windows.Forms.Label()
        Me.tmrPreparingToStart = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblGettingFaster = New System.Windows.Forms.Label()
        Me.tmrGettingFasterLabel = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGreenClick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRedClick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBlueClick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrYellowClick = New System.Windows.Forms.Timer(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picVersion = New System.Windows.Forms.PictureBox()
        Me.BorderRegion1 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion2 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion3 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion4 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion6 = New System.Windows.Forms.PictureBox()
        Me.BorderRegion5 = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picBlack4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlackSquare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreen_Clicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed_Clicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue_Clicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellow_Clicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlack3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlack1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlack2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRegion5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(71, 103)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(64, 19)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "Score: 0"
        '
        'picBlack4
        '
        Me.picBlack4.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.Black_Bkgd
        Me.picBlack4.Location = New System.Drawing.Point(368, 103)
        Me.picBlack4.Name = "picBlack4"
        Me.picBlack4.Size = New System.Drawing.Size(21, 355)
        Me.picBlack4.TabIndex = 24
        Me.picBlack4.TabStop = False
        '
        'picBlackSquare
        '
        Me.picBlackSquare.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.Black_Bkgd
        Me.picBlackSquare.Location = New System.Drawing.Point(304, 212)
        Me.picBlackSquare.Name = "picBlackSquare"
        Me.picBlackSquare.Size = New System.Drawing.Size(137, 141)
        Me.picBlackSquare.TabIndex = 25
        Me.picBlackSquare.TabStop = False
        '
        'picGreen_Clicked
        '
        Me.picGreen_Clicked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGreen_Clicked.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picGreen_Click
        Me.picGreen_Clicked.Location = New System.Drawing.Point(165, 71)
        Me.picGreen_Clicked.Name = "picGreen_Clicked"
        Me.picGreen_Clicked.Size = New System.Drawing.Size(212, 208)
        Me.picGreen_Clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreen_Clicked.TabIndex = 26
        Me.picGreen_Clicked.TabStop = False
        '
        'picRed_Clicked
        '
        Me.picRed_Clicked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRed_Clicked.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picRed_Click
        Me.picRed_Clicked.Location = New System.Drawing.Point(376, 74)
        Me.picRed_Clicked.Name = "picRed_Clicked"
        Me.picRed_Clicked.Size = New System.Drawing.Size(208, 208)
        Me.picRed_Clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRed_Clicked.TabIndex = 27
        Me.picRed_Clicked.TabStop = False
        '
        'picBlue_Clicked
        '
        Me.picBlue_Clicked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBlue_Clicked.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picBlue_Click
        Me.picBlue_Clicked.Location = New System.Drawing.Point(373, 282)
        Me.picBlue_Clicked.Name = "picBlue_Clicked"
        Me.picBlue_Clicked.Size = New System.Drawing.Size(206, 211)
        Me.picBlue_Clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBlue_Clicked.TabIndex = 28
        Me.picBlue_Clicked.TabStop = False
        '
        'picYellow_Clicked
        '
        Me.picYellow_Clicked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picYellow_Clicked.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picYellow_Click
        Me.picYellow_Clicked.Location = New System.Drawing.Point(161, 279)
        Me.picYellow_Clicked.Name = "picYellow_Clicked"
        Me.picYellow_Clicked.Size = New System.Drawing.Size(212, 208)
        Me.picYellow_Clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYellow_Clicked.TabIndex = 29
        Me.picYellow_Clicked.TabStop = False
        '
        'picBlack3
        '
        Me.picBlack3.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.Black_Bkgd
        Me.picBlack3.Location = New System.Drawing.Point(199, 268)
        Me.picBlack3.Name = "picBlack3"
        Me.picBlack3.Size = New System.Drawing.Size(352, 23)
        Me.picBlack3.TabIndex = 30
        Me.picBlack3.TabStop = False
        '
        'picGreen
        '
        Me.picGreen.BackColor = System.Drawing.Color.Transparent
        Me.picGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGreen.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picGreen
        Me.picGreen.Location = New System.Drawing.Point(165, 71)
        Me.picGreen.Name = "picGreen"
        Me.picGreen.Size = New System.Drawing.Size(212, 208)
        Me.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreen.TabIndex = 31
        Me.picGreen.TabStop = False
        '
        'picRed
        '
        Me.picRed.BackColor = System.Drawing.Color.Transparent
        Me.picRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRed.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picRed
        Me.picRed.Location = New System.Drawing.Point(376, 74)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(208, 208)
        Me.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRed.TabIndex = 32
        Me.picRed.TabStop = False
        '
        'picBlue
        '
        Me.picBlue.BackColor = System.Drawing.Color.Transparent
        Me.picBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBlue.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picBlue
        Me.picBlue.Location = New System.Drawing.Point(373, 282)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(206, 211)
        Me.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBlue.TabIndex = 33
        Me.picBlue.TabStop = False
        '
        'picYellow
        '
        Me.picYellow.BackColor = System.Drawing.Color.Transparent
        Me.picYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picYellow.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.picYellow
        Me.picYellow.Location = New System.Drawing.Point(161, 279)
        Me.picYellow.Name = "picYellow"
        Me.picYellow.Size = New System.Drawing.Size(212, 208)
        Me.picYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYellow.TabIndex = 34
        Me.picYellow.TabStop = False
        '
        'picBlack1
        '
        Me.picBlack1.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.Black_Bkgd
        Me.picBlack1.Location = New System.Drawing.Point(368, 103)
        Me.picBlack1.Name = "picBlack1"
        Me.picBlack1.Size = New System.Drawing.Size(21, 355)
        Me.picBlack1.TabIndex = 35
        Me.picBlack1.TabStop = False
        '
        'picBlack2
        '
        Me.picBlack2.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.Black_Bkgd
        Me.picBlack2.Location = New System.Drawing.Point(199, 268)
        Me.picBlack2.Name = "picBlack2"
        Me.picBlack2.Size = New System.Drawing.Size(349, 23)
        Me.picBlack2.TabIndex = 36
        Me.picBlack2.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(145, 64)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 38)
        Me.lblTime.TabIndex = 37
        Me.lblTime.Text = "5"
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.White
        Me.lblInstruction.Location = New System.Drawing.Point(91, 21)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(419, 38)
        Me.lblInstruction.TabIndex = 37
        Me.lblInstruction.Text = "<Simon says> click <color>!"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrLessTime
        '
        Me.tmrLessTime.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLeft.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.Color.White
        Me.lblTimeLeft.Location = New System.Drawing.Point(33, 71)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(122, 30)
        Me.lblTimeLeft.TabIndex = 38
        Me.lblTimeLeft.Text = "Time Left:"
        '
        'lblPrepareToStart
        '
        Me.lblPrepareToStart.BackColor = System.Drawing.Color.Transparent
        Me.lblPrepareToStart.Font = New System.Drawing.Font("Comic Sans MS", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrepareToStart.ForeColor = System.Drawing.Color.White
        Me.lblPrepareToStart.Location = New System.Drawing.Point(89, 144)
        Me.lblPrepareToStart.Name = "lblPrepareToStart"
        Me.lblPrepareToStart.Size = New System.Drawing.Size(595, 248)
        Me.lblPrepareToStart.TabIndex = 40
        Me.lblPrepareToStart.Text = "Are you ready?"
        Me.lblPrepareToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentLevel
        '
        Me.lblCurrentLevel.AutoSize = True
        Me.lblCurrentLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentLevel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentLevel.ForeColor = System.Drawing.Color.White
        Me.lblCurrentLevel.Location = New System.Drawing.Point(71, 122)
        Me.lblCurrentLevel.Name = "lblCurrentLevel"
        Me.lblCurrentLevel.Size = New System.Drawing.Size(64, 19)
        Me.lblCurrentLevel.TabIndex = 41
        Me.lblCurrentLevel.Text = "Level: 1"
        '
        'tmrPreparingToStart
        '
        Me.tmrPreparingToStart.Interval = 1000
        '
        'lblGameOver
        '
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.White
        Me.lblGameOver.Location = New System.Drawing.Point(33, 50)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(703, 460)
        Me.lblGameOver.TabIndex = 42
        Me.lblGameOver.Text = "<game over msg>"
        Me.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGettingFaster
        '
        Me.lblGettingFaster.AutoSize = True
        Me.lblGettingFaster.BackColor = System.Drawing.Color.Transparent
        Me.lblGettingFaster.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGettingFaster.ForeColor = System.Drawing.Color.White
        Me.lblGettingFaster.Location = New System.Drawing.Point(576, 64)
        Me.lblGettingFaster.Name = "lblGettingFaster"
        Me.lblGettingFaster.Size = New System.Drawing.Size(177, 30)
        Me.lblGettingFaster.TabIndex = 43
        Me.lblGettingFaster.Text = "Getting faster..."
        '
        'tmrGettingFasterLabel
        '
        Me.tmrGettingFasterLabel.Interval = 500
        '
        'tmrGreenClick
        '
        Me.tmrGreenClick.Interval = 50
        '
        'tmrRedClick
        '
        '
        'tmrBlueClick
        '
        '
        'tmrYellowClick
        '
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.CloseIcon
        Me.picClose.Location = New System.Drawing.Point(709, 7)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(44, 44)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picClose.TabIndex = 44
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackColor = System.Drawing.Color.Transparent
        Me.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimize.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.MinimizeIcon
        Me.picMinimize.Location = New System.Drawing.Point(653, 7)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(44, 44)
        Me.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picMinimize.TabIndex = 45
        Me.picMinimize.TabStop = False
        '
        'picVersion
        '
        Me.picVersion.BackColor = System.Drawing.Color.Transparent
        Me.picVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVersion.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.HelpIcon
        Me.picVersion.Location = New System.Drawing.Point(596, 7)
        Me.picVersion.Name = "picVersion"
        Me.picVersion.Size = New System.Drawing.Size(44, 44)
        Me.picVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picVersion.TabIndex = 46
        Me.picVersion.TabStop = False
        '
        'BorderRegion1
        '
        Me.BorderRegion1.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion1.Location = New System.Drawing.Point(-2, -8)
        Me.BorderRegion1.Name = "BorderRegion1"
        Me.BorderRegion1.Size = New System.Drawing.Size(101, 108)
        Me.BorderRegion1.TabIndex = 47
        Me.BorderRegion1.TabStop = False
        '
        'BorderRegion2
        '
        Me.BorderRegion2.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion2.Location = New System.Drawing.Point(98, -6)
        Me.BorderRegion2.Name = "BorderRegion2"
        Me.BorderRegion2.Size = New System.Drawing.Size(450, 25)
        Me.BorderRegion2.TabIndex = 48
        Me.BorderRegion2.TabStop = False
        '
        'BorderRegion3
        '
        Me.BorderRegion3.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion3.Location = New System.Drawing.Point(544, -6)
        Me.BorderRegion3.Name = "BorderRegion3"
        Me.BorderRegion3.Size = New System.Drawing.Size(228, 65)
        Me.BorderRegion3.TabIndex = 49
        Me.BorderRegion3.TabStop = False
        '
        'BorderRegion4
        '
        Me.BorderRegion4.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion4.Location = New System.Drawing.Point(750, 57)
        Me.BorderRegion4.Name = "BorderRegion4"
        Me.BorderRegion4.Size = New System.Drawing.Size(22, 460)
        Me.BorderRegion4.TabIndex = 50
        Me.BorderRegion4.TabStop = False
        '
        'BorderRegion6
        '
        Me.BorderRegion6.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion6.Location = New System.Drawing.Point(-2, 99)
        Me.BorderRegion6.Name = "BorderRegion6"
        Me.BorderRegion6.Size = New System.Drawing.Size(22, 418)
        Me.BorderRegion6.TabIndex = 51
        Me.BorderRegion6.TabStop = False
        '
        'BorderRegion5
        '
        Me.BorderRegion5.BackColor = System.Drawing.Color.Transparent
        Me.BorderRegion5.Location = New System.Drawing.Point(-2, 493)
        Me.BorderRegion5.Name = "BorderRegion5"
        Me.BorderRegion5.Size = New System.Drawing.Size(769, 25)
        Me.BorderRegion5.TabIndex = 52
        Me.BorderRegion5.TabStop = False
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.Transparent
        Me.picBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBack.Image = Global.Bopp_Kevin_SimonSays.My.Resources.Resources.backArrow
        Me.picBack.Location = New System.Drawing.Point(20, 468)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(50, 25)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBack.TabIndex = 53
        Me.picBack.TabStop = False
        '
        'frmEasy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(765, 515)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.picVersion)
        Me.Controls.Add(Me.picMinimize)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblGettingFaster)
        Me.Controls.Add(Me.lblCurrentLevel)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.picBlack2)
        Me.Controls.Add(Me.picBlackSquare)
        Me.Controls.Add(Me.picBlack1)
        Me.Controls.Add(Me.picRed)
        Me.Controls.Add(Me.picBlack4)
        Me.Controls.Add(Me.picBlack3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picRed_Clicked)
        Me.Controls.Add(Me.picBlue)
        Me.Controls.Add(Me.picYellow)
        Me.Controls.Add(Me.picYellow_Clicked)
        Me.Controls.Add(Me.picBlue_Clicked)
        Me.Controls.Add(Me.picGreen)
        Me.Controls.Add(Me.picGreen_Clicked)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblPrepareToStart)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.BorderRegion1)
        Me.Controls.Add(Me.BorderRegion3)
        Me.Controls.Add(Me.BorderRegion2)
        Me.Controls.Add(Me.BorderRegion4)
        Me.Controls.Add(Me.BorderRegion6)
        Me.Controls.Add(Me.BorderRegion5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEasy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simon Says - Easy"
        CType(Me.picBlack4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlackSquare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreen_Clicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed_Clicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue_Clicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellow_Clicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlack3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlack1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlack2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRegion5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picBlack4 As PictureBox
    Friend WithEvents picBlackSquare As PictureBox
    Friend WithEvents picGreen_Clicked As PictureBox
    Friend WithEvents picRed_Clicked As PictureBox
    Friend WithEvents picBlue_Clicked As PictureBox
    Friend WithEvents picYellow_Clicked As PictureBox
    Friend WithEvents picBlack3 As PictureBox
    Friend WithEvents picGreen As PictureBox
    Friend WithEvents picRed As PictureBox
    Friend WithEvents picBlue As PictureBox
    Friend WithEvents picYellow As PictureBox
    Friend WithEvents picBlack1 As PictureBox
    Friend WithEvents picBlack2 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents tmrLessTime As Timer
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents lblPrepareToStart As Label
    Friend WithEvents lblCurrentLevel As Label
    Friend WithEvents tmrPreparingToStart As Timer
    Friend WithEvents lblGameOver As Label
    Friend WithEvents lblGettingFaster As Label
    Friend WithEvents tmrGettingFasterLabel As Timer
    Friend WithEvents tmrGreenClick As Timer
    Friend WithEvents tmrRedClick As Timer
    Friend WithEvents tmrBlueClick As Timer
    Friend WithEvents tmrYellowClick As Timer
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picVersion As PictureBox
    Friend WithEvents BorderRegion1 As PictureBox
    Friend WithEvents BorderRegion2 As PictureBox
    Friend WithEvents BorderRegion3 As PictureBox
    Friend WithEvents BorderRegion4 As PictureBox
    Friend WithEvents BorderRegion6 As PictureBox
    Friend WithEvents BorderRegion5 As PictureBox
    Friend WithEvents picBack As PictureBox
End Class
