Public Class frmHowToPlay

    Dim strHTP1 As String = "Hello and welcome to Simon Says!" & vbNewLine & "I, Señor Mejor, will be your host."
    Dim strHTP2 As String = "Simon Says is a game about accuracy and speed. In this version, you can"
    Dim strHTP3 As String = "choose Easy, Normal, or Hard modes. Normal is recommended."
    Dim strHTP4 As String = "The object of this game is simple:" & vbNewLine & "follow the instructions."
    Dim strHTP5 As String = "If Simon tells you to click a color," & vbNewLine & "then click it! For each correct click,"
    Dim strHTP6 As String = "you will earn one point. If you get" & vbNewLine & "one wrong, you automatically lose!"
    Dim strHTP7 As String = "Be warned, you have a decreasing time limit per each level."
    Dim strHTP8 As String = "Also, if Simon doesn't tell you to click something, do NOT click anything."
    Dim strHTP9 As String = "That's all for now. Good luck, and try not to mess up!"

    Private Sub frmHowToPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_HTP.Text = strHTP1
        picReadAgain.Visible = False
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

    Private Sub picCloseSmall_Click(sender As Object, e As EventArgs) Handles picCloseSmall.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(6, False)
            End With
        End If
        Me.Close()
    End Sub

    Private Sub picMinimizeSmall_Click(sender As Object, e As EventArgs) Handles picMinimizeSmall.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(1, False)
            End With
        End If

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picBackArrow_Click(sender As Object, e As EventArgs) Handles picBackArrow.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(6, False)
            End With
        End If
        Me.Close()
        frmLauncher.Show()
    End Sub

    Private Sub picReadAgain_Click(sender As Object, e As EventArgs) Handles picReadAgain.Click
        If (frmLauncher.blnSFXMuted = False) Then
            frmLauncher.intSound += 1
            With frmLauncher.sound
                .Name = "sound" & frmLauncher.intSound
                .Play(10, False)
            End With
        End If

        If (lbl_HTP.Text = strHTP2) Then
            picReadAgain.Visible = False
            lbl_HTP.Text = strHTP1
        ElseIf (lbl_HTP.Text = strHTP3) Then
            lbl_HTP.Text = strHTP2
        ElseIf (lbl_HTP.Text = strHTP4) Then
            lbl_HTP.Text = strHTP3
        ElseIf (lbl_HTP.Text = strHTP5) Then
            lbl_HTP.Text = strHTP4
        ElseIf (lbl_HTP.Text = strHTP6) Then
            lbl_HTP.Text = strHTP5
        ElseIf (lbl_HTP.Text = strHTP7) Then
            lbl_HTP.Text = strHTP6
        ElseIf (lbl_HTP.Text = strHTP8) Then
            lbl_HTP.Text = strHTP7
        ElseIf (lbl_HTP.Text = strHTP9) Then
            lbl_HTP.Text = strHTP8
        End If
    End Sub

    Private Sub picRead_Click(sender As Object, e As EventArgs) Handles picRead.Click

        If (lbl_HTP.Text = strHTP1) Then
            picReadAgain.Visible = True
            lbl_HTP.Text = strHTP2

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP2) Then
            lbl_HTP.Text = strHTP3

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP3) Then
            lbl_HTP.Text = strHTP4

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP4) Then
            lbl_HTP.Text = strHTP5

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP5) Then
            lbl_HTP.Text = strHTP6

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP6) Then
            lbl_HTP.Text = strHTP7

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP7) Then
            lbl_HTP.Text = strHTP8

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP8) Then
            lbl_HTP.Text = strHTP9

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(9, False)
                End With
            End If
        ElseIf (lbl_HTP.Text = strHTP9) Then

            If (frmLauncher.blnSFXMuted = False) Then
                frmLauncher.intSound += 1
                With frmLauncher.sound
                    .Name = "sound" & frmLauncher.intSound
                    .Play(6, False)
                End With
            End If
            Me.Close()
            frmLauncher.Show()
        End If
    End Sub
End Class