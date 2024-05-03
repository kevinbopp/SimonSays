Public Class frmLauncher
    Public blnSFXMuted As Boolean = False
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public intVolume As Integer = 1000
    Public strLastFailSound As String

    Dim rndEasyMusic As New Random
    Dim strMusicWillBe() As String = {"0", "1"}
    Public strMusicEasyIs As String

    ' Call the Sfx class.
    Public sound As New Sfx
    ' Count sounds played.
    Public intSound As Integer = 0

    Dim myPoints As Integer = 0                                 'Declares myPoints as an Integer with the value of 0.





    Private Sub Bopp_Kevin_SimonSays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBackArrow.Visible = False             'Hides the page on startup which displays the buttons to switch levels.
        picBackArrow.Visible = False
        picExitMain.Visible = True
        picEasy.Visible = False
        picMedium.Visible = False
        picHard.Visible = False
        lblChooseAMode.Visible = False

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None         'Centers the game, removes its border, and locks it in place--pre-setup placement.
        Me.WindowState = FormWindowState.Normal
        Me.CenterToScreen()

        'Play music.
        intSound += 1
        With sound
            .Name = "sound" & intSound
            .Play(2, True, intVolume)
        End With
    End Sub

    Public Sub HaltSound()
        For X = 0 To intSound
            sound.Kill("sound" & X)
        Next
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles BorderRegion1.MouseDown, BorderRegion2.MouseDown, BorderRegion3.MouseDown, BorderRegion4.MouseDown,
        BorderRegion5.MouseDown, BorderRegion6.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            'Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles BorderRegion1.MouseMove, BorderRegion2.MouseMove, BorderRegion3.MouseMove, BorderRegion4.MouseMove,
        BorderRegion5.MouseMove, BorderRegion6.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles BorderRegion1.MouseUp, BorderRegion2.MouseUp, BorderRegion3.MouseUp, BorderRegion4.MouseUp,
        BorderRegion5.MouseUp, BorderRegion6.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            'Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Application.Exit()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(1, False, intVolume)
            End With
        End If
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles picSettings.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(0, False, intVolume)
            End With
        End If
        frmSettings.Show()
    End Sub

    Private Sub picHelp_Click(sender As Object, e As EventArgs) Handles picHelp.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(11, False, intVolume)
            End With
        End If
        MsgBox("Simon Says, 20% Time Project." & vbNewLine & vbNewLine & "Version 1.2.2, last updated 3/16/2016." & vbNewLine & vbNewLine & "Written and designed by Kevin Bopp.", , "Simon Says - About")
    End Sub

    Private Sub picPlay_Click(sender As Object, e As EventArgs) Handles picPlay.Click

        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(4, False, intVolume)
            End With
        End If

        picSettingsMain.Visible = False
        picWelcome.Visible = False          'Hides the launcher buttons and shows the buttons to head back or choose a mode.
        picPlay.Visible = False
        picExitMain.Visible = False
        picBackArrow.Visible = True
        picHTPMain.Visible = False
        picEasy.Visible = True
        picMedium.Visible = True
        picHard.Visible = True
        lblChooseAMode.Visible = True
    End Sub

    Private Sub picSettingsMain_Click(sender As Object, e As EventArgs) Handles picSettingsMain.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(0, False, intVolume)
            End With
        End If
        frmSettings.Show()
    End Sub

    Private Sub picHTPMain_Click(sender As Object, e As EventArgs) Handles picHTPMain.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(5, False, intVolume)
            End With
        End If
        frmHowToPlay.Show()
    End Sub

    Private Sub picExitMain_Click(sender As Object, e As EventArgs) Handles picExitMain.Click
        Application.Exit()
    End Sub

    Private Sub picEasy_Click(sender As Object, e As EventArgs) Handles picEasy.Click
        HaltSound()

        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(7, False, intVolume)
            End With
        End If

        strMusicEasyIs = strMusicWillBe(rndEasyMusic.Next(0, 2))

        Me.Hide()
        frmEasy.Show()
    End Sub

    Private Sub picMedium_Click(sender As Object, e As EventArgs) Handles picMedium.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(8, False, intVolume)
            End With
        End If

        MsgBox("Sorry, this gamemode is coming soon!", , "Simon Says - Coming Soon")      'Informs the user that this gamemode is coming soon with a MsgBox.
    End Sub

    Private Sub picHard_Click(sender As Object, e As EventArgs) Handles picHard.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(8, False, intVolume)
            End With
        End If

        MsgBox("Sorry, this gamemode is coming soon!", , "Simon Says - Coming Soon")      'Informs the user that this gamemode is coming soon with a MsgBox.
    End Sub

    Private Sub picBackArrow_Click(sender As Object, e As EventArgs) Handles picBackArrow.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(6, False, intVolume)
            End With
        End If
        picSettingsMain.Visible = True
        picBackArrow.Visible = False             'Unhides the original buttons returning the user back to the Homepage.
        picPlay.Visible = True
        picExitMain.Visible = True
        picBackArrow.Visible = False
        picWelcome.Visible = True
        picHTPMain.Visible = True
        picEasy.Visible = False
        picMedium.Visible = False
        picHard.Visible = False
        lblChooseAMode.Visible = False
    End Sub

    Private Sub menuSettings_Click(sender As Object, e As EventArgs) Handles menuSettings.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(0, False, intVolume)
            End With
        End If
        frmSettings.Show()
    End Sub

    Private Sub menuVersion_Click(sender As Object, e As EventArgs) Handles menuVersion.Click
        If (blnSFXMuted = False) Then
            intSound += 1
            With sound
                .Name = "sound" & intSound
                .Play(11, False, intVolume)
            End With
        End If
        MsgBox("Simon Says, 20% Time Project." & vbNewLine & vbNewLine & "Version 1.2.1, last updated 3/13/2016." & vbNewLine & vbNewLine & "Written and designed by Kevin Bopp.", , "Simon Says - About")
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub cmsLauncherTopBorder_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsLauncherTopBorder.Opening
        'sound
    End Sub

    Private Sub cmsMenuExit_Click(sender As Object, e As EventArgs) Handles cmsMenuExit.Click
        Application.Exit()
    End Sub



    ' Simulates a button click.

    'TMRTICK EVENT PER BUTTON ex. tmrBack_Click
    'If PICBOX.Visible = True Then
    '    PICBOX.Visible = False
    'Else
    '    PICBOX.Visible = True
    '    BUTTONTIMER.Stop()
    'End If
End Class
