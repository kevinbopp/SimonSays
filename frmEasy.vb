'Kevin Bopp
'Period 8
'20% Time Project
'Simon Says

'To-Do:
'Every two levels, check the past two and RANDOMIZE if it's the same. Modulus function If level Mod 2 = 0 randomize

Public Class frmEasy

    Dim intScore As Integer = 0
    Dim intCurrentLevel As Integer = 0
    Dim strCorrectButtonWillBe() As String = {"ssgreen", "ssred", "ssblue", "ssyellow", "green", "red", "blue", "yellow"}
    Dim strCorrectButton As String
    Dim strButtonClicked As String = "none"
    Dim rndColor As New Random
    Dim blnGameOver As Boolean = False
    'Dim blnLevelChanged As Boolean = False
    Dim strColorWas As String
    Dim strColorWasTwoLevelsAgo As String
    'Dim blnMusicMuted As Boolean = False
    'Dim blnSfxMuted As Boolean = False
    Dim intGettingFasterTicks As Integer = 0
    Dim blnFirstLevel As Boolean = True

    Dim rndFailSound As New Random
    Dim strFailSoundWillBe() As String = {"0", "1", "2"}
    Dim strFailSoundIs As String

    Dim strLastCorrectSound As String

    Dim rndCorrectSound As New Random
    Dim strCorrectSoundWillBe() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Dim strCorrectSoundIs As String

    Dim strPrepareToStart1 As String = "Are you ready?"
    Dim strPrepareToStart2 As String = "Are you ready?"
    Dim strPrepareToStart3 As String = "Are you ready?"
    Dim strPrepareToStart4 As String = "Starting in 3..."
    Dim strPrepareToStart5 As String = "Starting in 2..."
    Dim strPrepareToStart6 As String = "Starting in 1..."

    Private Sub FirstLevel()
        tmrPreparingToStart.Stop()

        Select Case frmLauncher.strMusicEasyIs
            Case 0
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(14, True, frmLauncher.intVolume)
                    End With
                End If
            Case 1
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(15, True, frmLauncher.intVolume)
                    End With
                End If
        End Select

        strCorrectButton = strCorrectButtonWillBe(rndColor.Next(0, 5))
        strColorWas = strCorrectButton
        strColorWasTwoLevelsAgo = strCorrectButton

        intCurrentLevel += 1
        'lblCurrentLevel.Text = "Level:  " & intCurrentLevel

        If (strCorrectButton = "ssgreen" Or strCorrectButton = "ssred" Or strCorrectButton = "ssblue" Or strCorrectButton = "ssyellow") Then
            strCorrectButton = Strings.Right(strCorrectButton, (Strings.Len(strCorrectButton) - 2))
            lblInstruction.Text = "Simon says click " & strCorrectButton & "!"

        Else
            lblInstruction.Text = "Click " & strCorrectButton & "!"
            strCorrectButton = "none"
        End If

        lblTime.Text = "3"
        tmrLessTime.Start()


    End Sub

    Private Sub NextLevel()

        strCorrectSoundIs = strCorrectSoundWillBe(rndCorrectSound.Next(0, 10))

        While (strCorrectSoundIs = strLastCorrectSound)
            strCorrectSoundIs = strCorrectSoundWillBe(rndCorrectSound.Next(0, 10))
        End While

        Select Case strCorrectSoundIs
            Case 0
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(22, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "0"
                End If
            Case 1
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(23, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "1"
                End If
            Case 2
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(24, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "2"
                End If
            Case 3
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(25, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "3"
                End If
            Case 4
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(26, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "4"
                End If
            Case 5
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(27, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "5"
                End If
            Case 6
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(28, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "6"
                End If
            Case 7
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(29, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "7"
                End If
            Case 8
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(30, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "8"
                End If
            Case 9
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(31, False, frmLauncher.intVolume)
                    End With
                    strLastCorrectSound = "9"
                End If
        End Select



        intScore += 1
        lblScore.Text = "Score: " & intScore

        intCurrentLevel += 1
        lblCurrentLevel.Text = "Level: " & intCurrentLevel

        strCorrectButton = strCorrectButtonWillBe(rndColor.Next(0, 8))

        While (strCorrectButton = strColorWas)
            strCorrectButton = strCorrectButtonWillBe(rndColor.Next(0, 8))
        End While

        ' If two levels has passed, then...
        'If (intCurrentLevel Mod 2 = 0) Then
        '    While (strColorWasTwoLevelsAgo = strCorrectButton)
        '        strCorrectButton = strCorrectButtonWillBe(rndColor.Next(0, 8))
        '    End While

        '    While (strColorWasTwoLevelsAgo = strCorrectButton) Or (strColorWas = strCorrectButton)
        '        strCorrectButton = strCorrectButtonWillBe(rndColor.Next(0, 8))
        '    End While
        '    strColorWasTwoLevelsAgo = strCorrectButton
        'Else
        '    If (intCurrentLevel Mod 2 = 1) Then
        '        While strColorWas = strCorrectButton
        '            strCorrectButton = strCorrectButtonWillBe(rndColor.Next(0, 8))
        '        End While
        '    End If
        'End If

        strButtonClicked = "none"
        strColorWas = strCorrectButton

        If (strCorrectButton = "ssgreen" Or strCorrectButton = "ssred" Or strCorrectButton = "ssblue" Or strCorrectButton = "ssyellow") Then
            strCorrectButton = Strings.Right(strCorrectButton, (Strings.Len(strCorrectButton) - 2))
            lblInstruction.Text = "Simon says click " & strCorrectButton & "!"
        Else
            lblInstruction.Text = "Click " & strCorrectButton & "!"
            strCorrectButton = "none"
        End If

        lblTime.Text = "3"
        tmrLessTime.Start()
        SpeedUpTimer()
    End Sub

    Private Sub tmrLessTime_Tick(sender As Object, e As EventArgs) Handles tmrLessTime.Tick
        lblTime.Text = Val(lblTime.Text) - 1

        If (lblTime.Text) = 0 Then
            CheckCorrectButton()
        End If
    End Sub

    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picGreen.Hide()
        picYellow.Hide()
        picRed.Hide()
        picBlue.Hide()
        picGreen_Clicked.Hide()
        picYellow_Clicked.Hide()
        picRed_Clicked.Hide()
        picBlue_Clicked.Hide()
        lblTime.Hide()
        lblTimeLeft.Hide()
        lblInstruction.Hide()
        lblScore.Text = "Score: " & intScore
        lblScore.Hide()
        lblCurrentLevel.Text = "Level: 1"
        lblCurrentLevel.Hide()
        picBlack1.Hide()
        picBlack2.Hide()
        picBlack3.Hide()
        picBlack4.Hide()
        lblGameOver.Hide()
        picBlackSquare.Hide()
        lblGettingFaster.Hide()

        lblPrepareToStart.Text = strPrepareToStart1
        lblPrepareToStart.Show()

        tmrPreparingToStart.Start()
    End Sub

    Private Sub tmrPreparingToStart_Tick(sender As Object, e As EventArgs) Handles tmrPreparingToStart.Tick
        If lblPrepareToStart.Text = strPrepareToStart1 Then
            lblPrepareToStart.Text = strPrepareToStart2
            strPrepareToStart1 = ""

        ElseIf lblPrepareToStart.Text = strPrepareToStart2 Then
            lblPrepareToStart.Text = strPrepareToStart3
            strPrepareToStart2 = ""

        ElseIf lblPrepareToStart.Text = strPrepareToStart3 Then
            lblPrepareToStart.Text = strPrepareToStart4
            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(20, False, frmLauncher.intVolume)
                End With
            End If

        ElseIf lblPrepareToStart.Text = strPrepareToStart4 Then
            lblPrepareToStart.Text = strPrepareToStart5

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(20, False, frmLauncher.intVolume)
                End With
            End If

        ElseIf lblPrepareToStart.Text = strPrepareToStart5 Then
            lblPrepareToStart.Text = strPrepareToStart6

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(20, False, frmLauncher.intVolume)
                End With
            End If

        Else
            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(21, False, frmLauncher.intVolume)
                End With
            End If
            lblPrepareToStart.Hide()
            picGreen.Show()
            picYellow.Show()
            picRed.Show()
            picBlue.Show()
            picGreen_Clicked.Show()
            picYellow_Clicked.Show()
            picRed_Clicked.Show()
            picBlue_Clicked.Show()
            lblTime.Show()
            lblTimeLeft.Show()
            lblInstruction.Show()
            lblScore.Text = "Score: " & intScore
            lblScore.Show()
            lblCurrentLevel.Text = "Level: 1"
            lblCurrentLevel.Show()
            picBlack1.Show()
            picBlack2.Show()
            picBlack3.Show()
            picBlack4.Show()
            picBlackSquare.Show()
            FirstLevel()
        End If
    End Sub

    Private Sub picGreen_Click(sender As Object, e As EventArgs) Handles picGreen.Click
        strButtonClicked = "green"
        CheckCorrectButton()
    End Sub

    Private Sub picRed_Click(sender As Object, e As EventArgs) Handles picRed.Click
        strButtonClicked = "red"
        CheckCorrectButton()
    End Sub

    Private Sub picBlue_Click(sender As Object, e As EventArgs) Handles picBlue.Click
        strButtonClicked = "blue"
        CheckCorrectButton()
    End Sub

    Private Sub picYellow_Click(sender As Object, e As EventArgs) Handles picYellow.Click
        strButtonClicked = "yellow"
        CheckCorrectButton()
    End Sub

    Private Sub CheckCorrectButton()
        ' The purpose of this timer is to constantly check if the correct button was hit. This is so that if the user hits a button before their time runs out, they won't have to wait until 0.
        ' If the timer hits 0, however, then this subroutine is run again.

        If (lblTime.Text = "0") Then
            If (strCorrectButton = "none") Then
                'Simon didn't say to click anything and the user didn't.

                tmrLessTime.Stop()
                NextLevel()

                If (blnFirstLevel = True) Then
                    blnFirstLevel = False
                    If (frmLauncher.blnSFXMuted = False) Then
                        frmLauncher.intSound += 1
                        With frmLauncher.sound
                            .Name = "sound" & frmLauncher.intSound
                            .Play(31, False, frmLauncher.intVolume)
                        End With
                    End If
                End If
                Exit Sub
            Else
                'Simon did say something to click but the user didn't click anything within the alloted time.
                GameOverNotFastEnough()
                Exit Sub
            End If
        End If

        'If the user selected the right button which Simon told them to click, advance to the next level.
        If (strButtonClicked = strCorrectButton) Then
            If (strButtonClicked = "green") Then
                tmrGreenClick.Start()
                tmrLessTime.Stop()
                NextLevel()
            ElseIf (strButtonClicked = "red") Then
                tmrRedClick.Start()
                tmrLessTime.Stop()
                NextLevel()
            ElseIf (strButtonClicked = "blue") Then
                tmrBlueClick.Start()
                tmrLessTime.Stop()
                NextLevel()
            ElseIf (strButtonClicked = "yellow") Then
                tmrYellowClick.Start()
                tmrLessTime.Stop()
                NextLevel()
            End If

        Else
            'Otherwise, if the user clicked a button but Simon didn't tell them to, then Game Over.
            If (strCorrectButton = "none") Then
                If (strButtonClicked = "green") Then
                    tmrGreenClick.Start()
                    GameOverSimonDidNotSay()
                ElseIf (strButtonClicked = "red") Then
                    tmrRedClick.Start()
                    GameOverSimonDidNotSay()
                ElseIf (strButtonClicked = "blue") Then
                    tmrBlueClick.Start()
                    GameOverSimonDidNotSay()
                ElseIf (strButtonClicked = "yellow") Then
                    tmrYellowClick.Start()
                    GameOverSimonDidNotSay()
                End If
            Else
                If (strButtonClicked = "green") Then
                    tmrGreenClick.Start()
                    GameOverWrongButton()
                ElseIf (strButtonClicked = "red") Then
                    tmrRedClick.Start()
                    GameOverWrongButton()
                ElseIf (strButtonClicked = "blue") Then
                    tmrBlueClick.Start()
                    GameOverWrongButton()
                ElseIf (strButtonClicked = "yellow") Then
                    tmrYellowClick.Start()
                    GameOverWrongButton()
                End If
            End If
        End If
    End Sub

    Private Sub GameOverNotFastEnough()
        frmLauncher.HaltSound()
        tmrLessTime.Stop()

        strFailSoundIs = strFailSoundWillBe(rndFailSound.Next(0, 3))

        While (strFailSoundIs = frmLauncher.strLastFailSound)
            strFailSoundIs = strFailSoundWillBe(rndFailSound.Next(0, 3))
        End While

        Select Case strFailSoundIs
            Case 0
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(16, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "0"
                End If
            Case 1
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(17, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "1"
                End If
            Case 2
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(18, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "2"
                End If
        End Select


        tmrBlueClick.Stop()
        tmrRedClick.Stop()
        tmrYellowClick.Stop()
        tmrGreenClick.Stop()
        picGreen.Hide()
        picYellow.Hide()
        picRed.Hide()
        picBlue.Hide()
        picGreen_Clicked.Hide()
        picYellow_Clicked.Hide()
        picRed_Clicked.Hide()
        picBlue_Clicked.Hide()
        lblTime.Hide()
        lblTimeLeft.Hide()
        lblInstruction.Hide()
        lblScore.Hide()
        lblCurrentLevel.Hide()
        picBlack1.Hide()
        picBlack2.Hide()
        picBlack3.Hide()
        picBlack4.Hide()
        picBlackSquare.Hide()

        blnGameOver = True
        Me.BackColor = Color.Red
        lblGameOver.Show()
        lblGameOver.Text = "You weren't fast enough—game over!" & vbNewLine & vbNewLine & "Score: " & intScore & vbNewLine & "Level: " & intCurrentLevel
    End Sub

    Private Sub GameOverSimonDidNotSay()
        frmLauncher.HaltSound()
        tmrLessTime.Stop()

        strFailSoundIs = strFailSoundWillBe(rndFailSound.Next(0, 3))

        While (strFailSoundIs = frmLauncher.strLastFailSound)
            strFailSoundIs = strFailSoundWillBe(rndFailSound.Next(0, 3))
        End While

        Select Case strFailSoundIs
            Case 0
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(16, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "0"
                End If
            Case 1
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(17, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "1"
                End If
            Case 2
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(18, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "2"
                End If
        End Select

        tmrBlueClick.Stop()
        tmrRedClick.Stop()
        tmrYellowClick.Stop()
        tmrGreenClick.Stop()
        picGreen.Hide()
        picYellow.Hide()
        picRed.Hide()
        picBlue.Hide()
        picGreen_Clicked.Hide()
        picYellow_Clicked.Hide()
        picRed_Clicked.Hide()
        picBlue_Clicked.Hide()
        lblTime.Hide()
        lblTimeLeft.Hide()
        lblInstruction.Hide()
        lblScore.Hide()
        lblCurrentLevel.Hide()
        picBlack1.Hide()
        picBlack2.Hide()
        picBlack3.Hide()
        picBlack4.Hide()
        picBlackSquare.Hide()

        blnGameOver = True
        Me.BackColor = Color.Red
        lblGameOver.Show()
        lblGameOver.Text = "Simon didn't say to click anything—game over!" & vbNewLine & vbNewLine & "Score: " & intScore & vbNewLine & "Level: " & intCurrentLevel
    End Sub

    Private Sub GameOverWrongButton()
        frmLauncher.HaltSound()
        tmrLessTime.Stop()

        strFailSoundIs = strFailSoundWillBe(rndFailSound.Next(0, 3))

        While (strFailSoundIs = frmLauncher.strLastFailSound)
            strFailSoundIs = strFailSoundWillBe(rndFailSound.Next(0, 3))
        End While

        Select Case strFailSoundIs
            Case 0
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(16, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "0"
                End If
            Case 1
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(17, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "1"
                End If
            Case 2
                If (frmLauncher.blnSFXMuted = False) Then
                    frmLauncher.intSound += 1
                    With frmLauncher.sound
                        .Name = "sound" & frmLauncher.intSound
                        .Play(18, False, frmLauncher.intVolume)
                    End With
                    frmLauncher.strLastFailSound = "2"
                End If
        End Select

        tmrBlueClick.Stop()
        tmrRedClick.Stop()
        tmrYellowClick.Stop()
        tmrGreenClick.Stop()
        picGreen.Hide()
        picYellow.Hide()
        picRed.Hide()
        picBlue.Hide()
        picGreen_Clicked.Hide()
        picYellow_Clicked.Hide()
        picRed_Clicked.Hide()
        picBlue_Clicked.Hide()
        lblTime.Hide()
        lblTimeLeft.Hide()
        lblInstruction.Hide()
        lblScore.Hide()
        lblCurrentLevel.Hide()
        picBlack1.Hide()
        picBlack2.Hide()
        picBlack3.Hide()
        picBlack4.Hide()
        picBlackSquare.Hide()

        blnGameOver = True
        Me.BackColor = Color.Red
        lblGameOver.Show()
        lblGameOver.Text = "You clicked the " & strButtonClicked & " button" & vbNewLine & "when you should have clicked the " & strCorrectButton & " button—game over!" & vbNewLine & vbNewLine & "Score: " & intScore & vbNewLine & "Level: " & intCurrentLevel
    End Sub

    Private Sub SpeedUpTimer()

        If (tmrLessTime.Interval >= 250) Then
            If (Strings.Right(intCurrentLevel, 1) = 0) Then
                tmrLessTime.Interval -= 100
                tmrGettingFasterLabel.Start()
            ElseIf (Strings.Left(intCurrentLevel, 1) = 1) And (Strings.Right(intCurrentLevel, 1) = 0) Then
                tmrLessTime.Interval -= 10
                tmrGettingFasterLabel.Start()
            End If
        End If



    End Sub

    Private Sub tmrGettingFasterLabel_Tick(sender As Object, e As EventArgs) Handles tmrGettingFasterLabel.Tick
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(32, False, frmLauncher.intVolume)
            End With
        End If
        lblGettingFaster.Visible = Not lblGettingFaster.Visible
        intGettingFasterTicks += 1

        If (intGettingFasterTicks = 5) Then
            intGettingFasterTicks = 0
            lblGettingFaster.Hide()
            tmrGettingFasterLabel.Stop()
        End If

    End Sub

    Private Sub tmrGreenClick_Tick(sender As Object, e As EventArgs) Handles tmrGreenClick.Tick
        If picGreen.Visible = True Then
            picGreen.Visible = False
        Else
            picGreen.Visible = True
            tmrGreenClick.Stop()
        End If
    End Sub

    Private Sub tmrRedClick_Tick(sender As Object, e As EventArgs) Handles tmrRedClick.Tick
        If picRed.Visible = True Then
            picRed.Visible = False
        Else
            picRed.Visible = True
            tmrRedClick.Stop()
        End If
    End Sub

    Private Sub tmrBlueClick_Tick(sender As Object, e As EventArgs) Handles tmrBlueClick.Tick
        If picBlue.Visible = True Then
            picBlue.Visible = False
        Else
            picBlue.Visible = True
            tmrBlueClick.Stop()
        End If
    End Sub

    Private Sub tmrYellowClick_Tick(sender As Object, e As EventArgs) Handles tmrYellowClick.Tick
        If picYellow.Visible = True Then
            picYellow.Visible = False
        Else
            picYellow.Visible = True
            tmrYellowClick.Stop()
        End If
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles BorderRegion1.MouseDown, BorderRegion2.MouseDown, BorderRegion3.MouseDown, BorderRegion4.MouseDown,
        BorderRegion5.MouseDown, BorderRegion6.MouseDown
        If e.Button = MouseButtons.Left Then
            frmLauncher.MoveForm = True
            'Me.Cursor = Cursors.NoMove2D
            frmLauncher.MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles BorderRegion1.MouseMove, BorderRegion2.MouseMove, BorderRegion3.MouseMove, BorderRegion4.MouseMove,
        BorderRegion5.MouseMove, BorderRegion6.MouseMove
        If frmLauncher.MoveForm Then
            Me.Location = Me.Location + (e.Location - frmLauncher.MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles BorderRegion1.MouseUp, BorderRegion2.MouseUp, BorderRegion3.MouseUp, BorderRegion4.MouseUp,
        BorderRegion5.MouseUp, BorderRegion6.MouseUp
        If e.Button = MouseButtons.Left Then
            frmLauncher.MoveForm = False
            'Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        frmLauncher.HaltSound()
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(6, False, frmLauncher.intVolume)
            End With
        End If

        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With
        End If

        Me.Close()
        frmLauncher.Show()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(1, False, frmLauncher.intVolume)
            End With
        End If
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picVersion_Click(sender As Object, e As EventArgs) Handles picVersion.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(11, False, frmLauncher.intVolume)
            End With
        End If
        MsgBox("Simon Says, 20% Time Project." & vbNewLine & vbNewLine & "Version 1.2.2, last updated 3/16/2016." & vbNewLine & vbNewLine & "Written and designed by Kevin Bopp.", , "Simon Says - About")
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

        frmLauncher.HaltSound()

        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(5, False, frmLauncher.intVolume)
            End With
        End If

        Me.Close()
        frmLauncher.Show()

        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With
        End If
    End Sub
End Class