Public Class frmSettings

    Private Sub picBackArrow_Click(sender As Object, e As EventArgs) Handles picBackArrow.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(6, False, frmLauncher.intVolume)
            End With
        End If

        Me.Hide()
        frmLauncher.Show()
    End Sub

    Private Sub tbVolumeControl_Scroll(sender As Object, e As EventArgs) Handles tbVolumeControl.Scroll
        frmLauncher.intVolume = tbVolumeControl.Value

        Select Case tbVolumeControl.Value
            Case 0
                frmLauncher.blnSFXMuted = True
                picVolume.Image = My.Resources.volume0
                picVolume.Tag = "muted"
                lblVolume.Text = "Volume: Muted"
                frmLauncher.intVolume = 0

                frmLauncher.HaltSound()

            Case 1 To 9
                frmLauncher.blnSFXMuted = False
                picVolume.Image = My.Resources.volume1To9
                picVolume.Tag = "superlow"
                lblVolume.Text = "Volume: " & frmLauncher.intVolume & "%"
                frmLauncher.intVolume = frmLauncher.intVolume & 0

                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(12, False, frmLauncher.intVolume)
                End With

                frmLauncher.HaltSound()
            Case 10 To 32
                frmLauncher.blnSFXMuted = False
                picVolume.Image = My.Resources.volume10To32
                picVolume.Tag = "low"
                lblVolume.Text = "Volume: " & frmLauncher.intVolume & "%"
                frmLauncher.intVolume = frmLauncher.intVolume & 0

                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(12, False, frmLauncher.intVolume)
                End With

                frmLauncher.HaltSound()
            Case 33 To 65
                frmLauncher.blnSFXMuted = False
                picVolume.Image = My.Resources.volume33To65
                picVolume.Tag = "medium"
                lblVolume.Text = "Volume: " & frmLauncher.intVolume & "%"
                frmLauncher.intVolume = frmLauncher.intVolume & 0

                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(12, False, frmLauncher.intVolume)
                End With

                frmLauncher.HaltSound()
            Case 66 To 100
                frmLauncher.blnSFXMuted = False
                picVolume.Image = My.Resources.volume66To100
                picVolume.Tag = "high"
                lblVolume.Text = "Volume: " & frmLauncher.intVolume & "%"
                frmLauncher.intVolume = frmLauncher.intVolume & 0

                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(12, False, frmLauncher.intVolume)
                End With

                frmLauncher.HaltSound()
        End Select

        'If (frmLauncher.blnSFXMuted = False) Then
        '    frmLauncher.intSound += 1
        '    With frmLauncher.sound
        '        .Name = "sound" & frmLauncher.intSound
        '        .Play(12, False, frmLauncher.intVolume)
        '    End With
        'End If

        'frmLauncher.HaltSound()



    End Sub

    Private Sub picVolume_Click(sender As Object, e As EventArgs) Handles picVolume.Click

        If (picVolume.Tag = "max") Then
            picVolume.Image = My.Resources.volume33To65
            picVolume.Tag = "medium"
            tbVolumeControl.Value = 65
            lblVolume.Text = "Volume: " & tbVolumeControl.Value & "%"
            frmLauncher.intVolume = 650

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(13, False, frmLauncher.intVolume)
            End With

            frmLauncher.HaltSound()

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With

            Exit Sub
        ElseIf (picVolume.Tag = "medium") Then
            picVolume.Image = My.Resources.volume10To32
            picVolume.Tag = "low"
            tbVolumeControl.Value = 32
            lblVolume.Text = "Volume: " & tbVolumeControl.Value & "%"
            frmLauncher.intVolume = 320

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(13, False, frmLauncher.intVolume)
            End With

            frmLauncher.HaltSound()

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With
            Exit Sub
        ElseIf (picVolume.Tag = "low") Then
            picVolume.Image = My.Resources.volume1To9
            picVolume.Tag = "superlow"
            tbVolumeControl.Value = 9
            lblVolume.Text = "Volume: " & tbVolumeControl.Value & "%"
            frmLauncher.intVolume = 90

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(13, False, frmLauncher.intVolume)
            End With

            frmLauncher.HaltSound()

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With
            Exit Sub
        ElseIf (picVolume.Tag = "superlow") Then
            picVolume.Image = My.Resources.volume0
            picVolume.Tag = "muted"
            tbVolumeControl.Value = 0
            lblVolume.Text = "Volume: Muted"
            frmLauncher.intVolume = 0

            frmLauncher.HaltSound()

            frmLauncher.blnSFXMuted = True
            Exit Sub
        ElseIf (picVolume.Tag = "muted") Then
            picVolume.Image = My.Resources.volume66To100
            picVolume.Tag = "max"
            tbVolumeControl.Value = 100
            lblVolume.Text = "Volume: " & tbVolumeControl.Value & "%"
            frmLauncher.intVolume = 1000

            frmLauncher.blnSFXMuted = False

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(13, False, frmLauncher.intVolume)
            End With

            frmLauncher.HaltSound()

            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With
            Exit Sub
        End If
    End Sub

    Private Sub picVersionMain_Click(sender As Object, e As EventArgs) Handles picVersionMain.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(11, False, frmLauncher.intVolume)
            End With
        End If
        MsgBox("Simon Says, 20% Time Project." & vbNewLine & vbNewLine & "Version 1.2.2, last updated 3/16/2016." & vbNewLine & vbNewLine & "Written and designed by Kevin Bopp.", , "Simon Says - About")
    End Sub

    Private Sub tbVolumeControl_MouseUp(sender As Object, e As MouseEventArgs) Handles tbVolumeControl.MouseUp
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(2, True, frmLauncher.intVolume)
            End With
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

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(6, False)
            End With
        End If
        Me.Hide()
        frmLauncher.Show()
    End Sub
End Class