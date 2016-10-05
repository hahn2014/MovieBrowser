Imports System.IO
Imports System.Net

Public Class UpdateData
    Dim maxMovieSeriesCount As Integer = 10
    Dim movieFile As String = ""
    Dim fileURL As String = ""

    Public Sub setMovieFileURL(ByVal url As String, ByVal file As String)
        fileURL = url
        movieFile = file
        Dim reader As New System.IO.StreamReader(Form1.locationForData + url + ".data")
        Dim allLines As List(Of String) = New List(Of String)
        Dim i As Integer = 0
        Do While Not reader.EndOfStream
            allLines.Add(reader.ReadLine())
            i += 1
        Loop
        reader.Close()

        titleTB.Text = allLines(1)
        imdbIDBox.Text = allLines(2)
        yearTB.Text = allLines(3)
        GenreBox.SelectedItem = getProperGenre(allLines(4).ToLower())
        GenreBox.Text = getProperGenre(allLines(4).ToLower())
        seriesTitleTB.Text = allLines(5)
        seriesIterationTB.Text = allLines(6)

        If (seriesTitleTB.Text.Equals("")) Then
            seriesIterationTB.Enabled = False
            subtractBTN.Enabled = False
            addBTN.Enabled = False
        End If

        PlayCountBox.Text = Integer.Parse(allLines(7))
        updatePlayTime(allLines(8))

        updateIMDBinfo()

    End Sub

    Private Sub updatePlayTime(ByVal times As String)
        Dim hours As Integer
        Dim mins As Integer
        Dim seconds As Integer

        Dim toBeConverted As Integer

        Dim splits() As String = {}
        splits = times.Split(":")

        If (splits.Length = 2) Then
            toBeConverted = Convert.ToInt32(splits(0))
            If (toBeConverted < 60) Then
                hours = 0
                mins = toBeConverted
            ElseIf (toBeConverted = 60) Then
                hours = 1
                mins = 0
            ElseIf (toBeConverted > 60) Then
                hours = Math.Sign(toBeConverted / 60) * Math.Floor(Math.Abs(toBeConverted / 60) * 100) / 100.0
                mins = toBeConverted - (60 * hours)
            End If
            seconds = Convert.ToInt32(splits(1))
        ElseIf (splits.Length = 3) Then
            hours = Convert.ToInt32(splits(0))
            mins = Convert.ToInt32(splits(1))
            seconds = Convert.ToInt32(splits(2))
        End If

        hourBox.Text = hours
        minBox.Text = mins
        If (mins < 10) Then
            minBox.Text = "0" + mins.ToString()
        End If
        secBox.Text = seconds
        If (seconds < 10) Then
            secBox.Text = "0" + seconds.ToString()
        End If
    End Sub

    Private Function getProperGenre(ByVal genre As String) As String
        For Each g As String In Form1.genres
            If (genre.Equals(g)) Then
                Console.WriteLine("Genre: " + g)
                Return g
            End If
        Next
        Return ""
    End Function

    Private Sub CancleBTN_Click(sender As Object, e As EventArgs) Handles CancleBTN.Click
        Me.Dispose()
        Form1.Show()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        If (Integer.Parse(seriesIterationTB.Text) + 1 <= maxMovieSeriesCount) Then
            seriesIterationTB.Text = Integer.Parse(seriesIterationTB.Text + 1)
        End If
    End Sub

    Private Sub subtractBTN_Click(sender As Object, e As EventArgs) Handles subtractBTN.Click
        If (Integer.Parse(seriesIterationTB.Text) - 1 >= 1) Then
            seriesIterationTB.Text = Integer.Parse(seriesIterationTB.Text - 1)
        End If
    End Sub

    Private Sub imdbBTN_Click(sender As Object, e As EventArgs) Handles imdbBTN.Click
        Dim info As New IMDBinfo(titleTB.Text, yearTB.Text)
        imdbIDBox.Text = info.getID()
        updateIMDBinfo()
    End Sub

    Private Sub subtractBTN2_Click(sender As Object, e As EventArgs) Handles subtractBTN2.Click
        If (Integer.Parse(seriesIterationTB.Text) - 1 >= 1) Then
            PlayCountBox.Text = Integer.Parse(PlayCountBox.Text - 1)
        End If
    End Sub

    Private Sub addBTN2_Click(sender As Object, e As EventArgs) Handles addBTN2.Click
        If (Integer.Parse(seriesIterationTB.Text) + 1 <= 100) Then
            PlayCountBox.Text = Integer.Parse(PlayCountBox.Text + 1)
        End If
    End Sub

    Private Sub updateIMDBinfo()
        Dim info As New IMDBinfo(imdbIDBox.Text)
        'get imdb info
        Try
            IMDBpic.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(info.getPoster())))
            IMDBTitle.Text = info.getTitle() + " - " + info.getYear() + " [" + info.getAgeRating() + "]"
            IMDBinfo.Text = info.getIMDBRating() + "/10 stars"
            IMDBplot.Text = info.getPlot()
        Catch
            IMDBpic.Image = My.Resources.placeholder
            IMDBTitle.Text = "Failed To Connect To The Internet"
            IMDBinfo.Text = ""
            IMDBplot.Text = ""
        End Try
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        File.WriteAllText(Form1.locationForData + fileURL + ".data", movieFile + vbNewLine + titleTB.Text + vbNewLine + imdbIDBox.Text + vbNewLine + yearTB.Text + vbNewLine + GenreBox.SelectedItem + vbNewLine +
                              seriesTitleTB.Text + vbNewLine + seriesIterationTB.Text + vbNewLine + PlayCountBox.Text + vbNewLine + hourBox.Text + ":" + minBox.Text + ":" + secBox.Text)
        CancleBTN.PerformClick()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (seriesTitleTB.Text.Equals("")) Then
            seriesIterationTB.Enabled = False
            subtractBTN.Enabled = False
            addBTN.Enabled = False
        Else
            seriesIterationTB.Enabled = True
            subtractBTN.Enabled = True
            addBTN.Enabled = True
        End If
    End Sub

    Private Sub UpdateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class