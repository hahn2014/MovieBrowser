Public Class VideoPlayer
    Dim playing As Boolean = False

    Dim timeleft As Integer = 0
    Dim curTimeSeconds As Integer = 0
    Dim durationSeconds As Integer = 0
    Dim url As String = ""
    Dim filename As String = ""

    Dim plays As Integer = 0
    Dim ticks As Integer = 0
    Private Sub VideoPlayer_Show(sender As Object, e As EventArgs) Handles MyBase.Load
        'load video
        eliteMoviePlayer.URL = url
        PlayButton.Text = "Pause"
        Timer1.Start()
        'trackbar shit for video position
        moviePosition.TickStyle = TickStyle.None
        VolumeAdjuster.TickStyle = TickStyle.None
        moviePosition.TickFrequency = 1
    End Sub

    Private Sub VolumeAdjuster_Scroll(sender As Object, e As EventArgs) Handles VolumeAdjuster.Scroll
        eliteMoviePlayer.settings.volume = VolumeAdjuster.Value
    End Sub

    Private Sub SkipBackButton_Click(sender As Object, e As EventArgs) Handles SkipBackButton.Click
        eliteMoviePlayer.Ctlcontrols.fastReverse()
    End Sub

    Private Sub SkipButton_Click(sender As Object, e As EventArgs) Handles SkipButton.Click
        eliteMoviePlayer.Ctlcontrols.fastForward()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If (eliteMoviePlayer.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            playing = False
            eliteMoviePlayer.Ctlcontrols.pause()
            Timer1.Stop()
            PlayButton.Text = "Play"
        ElseIf (eliteMoviePlayer.playState = WMPLib.WMPPlayState.wmppsPaused) Then
            playing = True
            eliteMoviePlayer.Ctlcontrols.play()
            Timer1.Start()
            PlayButton.Text = "Pause"
        ElseIf (eliteMoviePlayer.playState = WMPLib.WMPPlayState.wmppsScanForward) Then
            playing = True
            eliteMoviePlayer.Ctlcontrols.play()
            PlayButton.Text = "Pause"
        ElseIf (eliteMoviePlayer.playState = WMPLib.WMPPlayState.wmppsScanReverse) Then
            playing = True
            eliteMoviePlayer.Ctlcontrols.play()
            PlayButton.Text = "Pause"
        End If
    End Sub

    Private Sub FSButton_Click(sender As Object, e As EventArgs) Handles FSButton.Click
        If (eliteMoviePlayer.fullScreen = False) Then
            eliteMoviePlayer.fullScreen = True
        ElseIf (eliteMoviePlayer.fullScreen = True) Then
            eliteMoviePlayer.fullScreen = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = eliteMoviePlayer.Ctlcontrols.currentPositionString + " of " + eliteMoviePlayer.currentMedia.durationString
        ticks += 1
        If (ticks > 10) Then
            getTimeLeft(eliteMoviePlayer.Ctlcontrols.currentPositionString, eliteMoviePlayer.currentMedia.durationString)
            moviePosition.Maximum = durationSeconds
            moviePosition.Value = curTimeSeconds
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        If (timeleft < (60 * 5)) Then 'have watched it all the way to 5 minutes from the end
            Form1.updateMovieData(filename, "0:00:00", plays + 1)
        Else 'they didn't watch 
            Form1.updateMovieData(filename, eliteMoviePlayer.Ctlcontrols.currentPositionString, plays)
        End If
        Me.Close()
        Form1.Show()
    End Sub

    Public Sub GetMovieData(ByVal c As String, ByVal p As Integer)
        Dim s As Integer = 0
        Dim m As Integer = 0
        Dim h As Integer = 0

        plays = p

        s = Convert.ToInt32(c.Substring(3, 2))
        m = Convert.ToInt32(c.Substring(0, 2))

        curTimeSeconds = (m * 60)
        curTimeSeconds += s

        eliteMoviePlayer.Ctlcontrols.currentPosition = curTimeSeconds
        moviePosition.Value = curTimeSeconds
    End Sub

    Private Sub getTimeLeft(ByVal curPos As String, ByVal duration As String)
        Dim s As Integer = 0
        Dim m As Integer = 0
        Dim h As Integer = 0

        Dim curtimesec As Integer = 0 '00:00
        Dim durationsec As Integer = 0 '00:00:00

        s = Convert.ToInt32(curPos.Substring(3, 2))
        m = Convert.ToInt32(curPos.Substring(0, 2))

        curtimesec += (m * 60) 'get minutes to seconds
        curtimesec += s
        curTimeSeconds = curtimesec

        s = Convert.ToInt32(duration.Substring(6, 2))
        m = Convert.ToInt32(duration.Substring(3, 2))
        h = Convert.ToInt32(duration.Substring(0, 2))

        durationsec = (h * 60) * 60 'get hours to seconds
        durationsec += (m * 60) 'get minutes to seconds
        durationsec += s
        durationSeconds = durationsec

        timeleft = durationsec - curtimesec
    End Sub

    Private Sub moviePosition_Scroll(sender As Object, e As EventArgs) Handles moviePosition.Scroll
        eliteMoviePlayer.Ctlcontrols.pause()
        curTimeSeconds = moviePosition.Value
        eliteMoviePlayer.Ctlcontrols.currentPosition = curTimeSeconds
        eliteMoviePlayer.Ctlcontrols.play()
    End Sub

    Public Sub getMovieDataFromForm1(ByVal url As String, ByVal title As String, ByVal filename As String)
        Me.url = url
        Me.Text = "Video Player - " + title
        Me.filename = filename
    End Sub
End Class