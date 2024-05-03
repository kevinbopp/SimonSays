

Public Class Sfx
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String,
        ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private oName As String = Nothing

    Public Property Name As String
        Set(value As String)
            oName = value
        End Set
        Get
            Return oName
        End Get
    End Property

    Public Sub Play(ByVal id As Integer, ByVal blnRepeat As Boolean, Optional intVolume As Integer = 1000)

        ' One for repeating and one not for repeating. 2 sendstrings

        If (blnRepeat = True) Then
            ' Opens file (loads)
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            ' Plays file, repeating (bkgd music)
            mciSendString("play " & oName & " repeat ", CStr(0), 0, 0)
            ' If isn't a sound that repeats (beep sfx, success btnclick, etc., play w/o repeat
        Else
            ' Opens file (loads)
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            ' Plays file, not repeating (simple sfx)
            mciSendString("play " & oName, CStr(0), 0, 0)
        End If
        ' Optionally, Set Volume
        mciSendString("setaudio " & oName & " volume to " & intVolume, CStr(0), 0, 0)
    End Sub

    ' Media Library - sets paths of files
    Private Function GetFile(ByVal id As Integer) As String
        Dim strPath As String = ""
        Dim tempPath As String = ""


        ' Spaces cause failure to load (add quotation marks).
        ' Dots in the path can cause failure to load, because the dot marks the beginning of the file extension.
        ' Very long paths will cause failure to load. Maximum 255 char?
        ' Relative paths will cause failure to load.
        ' .wav files will fail to load if "repeat" = true.

        Select Case id
            Case 0 ' Open settings window
                strPath = "alert2.wav"
            Case 1 ' Minimize window
                strPath = "select2.wav"
            Case 2 ' bkgd music launcher sound - repeat true
                strPath = "launcherBkgd.mp3"
            Case 3 ' Version messagebox
                strPath = "alert5.wav"
            Case 4 'Play button goes to Easy Medium or Hard Chooser 
                strPath = "transfer4.wav"
            Case 5 'Clicks how to play
                strPath = "transfer5.wav"
            Case 6 'Back buttons
                strPath = "transfer6.wav"
            Case 7 'Play a gamemode
                strPath = "alert3.wav"
            Case 8 ' Gamemode not available or incorrect button push (exception push)
                strPath = "alert4.wav"
            Case 9 ' How to play - advance instructions
                strPath = "select1.wav"
            Case 10 ' How to play - read again arrow
                strPath = "select9.wav"
            Case 11 'version button question mark
                strPath = "transfer2.wav"
            Case 12 'Volume scrollbar
                strPath = "select8.wav"
            Case 13 'Volume Icon click
                strPath = "transfer3.wav"
            Case 14 'Easy gamemode - sound 1 repeat true
                strPath = "easy1.mp3"
            Case 15 'Easy gamemode - sound 2 repeat true
                strPath = "easy2.mp3"
            Case 16 'fail sound 0
                strPath = "gameover1.mp3"
            Case 17 'fail sound 1
                strPath = "gameover2.mp3"
            Case 18 'fail sound 2
                strPath = "gameover3.mp3"
            Case 19 'countdown for Easy gamemode ///THIS FILE WAS UNUSED
                strPath = "countdown1.wav"
            Case 20 'countdown2 for Easy gamemode - 3 2 1
                strPath = "countdown2.mp3"
            Case 21 'gamemode Easy start game - diiiing
                strPath = "countdown3.mp3"
            Case 22 'User selects correct button 1
                strPath = "correct1.mp3"
            Case 23 'User selects correct button 2
                strPath = "correct2.mp3"
            Case 24 'User selects correct button 3
                strPath = "correct3.mp3"
            Case 25 'User selects correct button 4
                strPath = "correct4.mp3"
            Case 26 'User selects correct button 5
                strPath = "correct5.mp3"
            Case 27 'User selects correct button 6
                strPath = "correct6.mp3"
            Case 28 'User selects correct button 7
                strPath = "correct7.mp3"
            Case 29 'User selects correct button 8
                strPath = "correct8.mp3"
            Case 30 'User selects correct button 9
                strPath = "correct9.mp3"
            Case 31 'User selects correct button 10
                strPath = "correct10.mp3"
            Case 32 'getting faster label easy mode
                strPath = "alert7.wav"
        End Select
        tempPath = strPath

        ' path for use with My.Resources Chr(34) is "
        'strPath = Strings.Left(Application.StartupPath, Strings.Len(Application.StartupPath) - 9) & "Resources\" & tempPath
        strPath = Chr(34) & Strings.Left(Application.StartupPath, Strings.Len(Application.StartupPath) - 9) & "audiofiles\" & tempPath & Chr(34)
        Return strPath
    End Function

    Public Sub Kill(ByVal music As String)
        mciSendString("close " & music, CStr(0), 0, 0)
        oName = Nothing
    End Sub
End Class
