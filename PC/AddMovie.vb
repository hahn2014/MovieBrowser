Imports System.IO
Imports System.Net
Imports System.Uri
Imports System.Text.RegularExpressions

Public Class AddMovie
    Dim diskLocation As Boolean = True

    Public movieDirS As String = String.Empty
    Public movieFileS As String = String.Empty
    Dim locationSaveFile As String = "C:\Users\" + Environment.UserName + "\AppData\Local\MovieBrowser\MovieData\"


    Private Sub LoadFileBTN_Click(sender As Object, e As EventArgs) Handles LoadFileBTN.Click
        If (diskLocation) Then
            directoryUpdater.Title = "Choose which movie file to add or replace"
            'test to see if the user presses the ok button
            If directoryUpdater.ShowDialog() = Windows.Forms.DialogResult.OK Then
                movieDirS = directoryUpdater.FileName
                movieFileS = System.IO.Path.GetFileName(directoryUpdater.FileName).Substring(0, System.IO.Path.GetFileName(directoryUpdater.FileName).Length - 4)
                dirTextField.Text = movieDirS
            Else
                movieDirS = ""
                movieFileS = ""
                dirTextField.Text = ""
            End If
            If Not movieDirS = "" Then
                predictFilmData(dirTextField.Text, System.IO.Path.GetFileName(directoryUpdater.FileName))
                detailsPanel.Enabled = True
            End If
        Else
            urlTextFieldLB.ForeColor = Color.Black
            If Not (dirTextField.Text = "") Then
                If (authenticateURL(dirTextField.Text)) Then
                    movieDirS = dirTextField.Text
                    urlTextFieldLB.ForeColor = Color.Green
                Else
                    urlTextFieldLB.Text = "Please Enter a Valid URL"
                    urlTextFieldLB.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Function authenticateURL(ByVal url As String) As Boolean
        If Not url.StartsWith("http://") And Not url.StartsWith("https://") Then
            url = "http://" & url
        End If
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse

        request = WebRequest.Create(url)
        request.Timeout = 3000

        Try
            response = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub predictFilmData(ByVal url As String, ByVal name As String)
        Dim splits() As String = {}
        Dim title As String = ""
        Dim year As String = ""
        Dim genre As String = ""

        genre = url.Substring(0, url.Length - name.Length - 1)

        splits = name.Split("-")
        title = splits(0).Substring(0, splits(0).Length - 1)
        titleTB.Text = title

        year = splits(1).Substring(0, 5)
        year = Replace(year, " ", "")
        yearTB.Text = year

        splits = genre.Split("\")
        genre = splits(splits.Length - 1).ToLower()
        GenreBox.SelectedItem = getProperGenre(genre)
        GenreBox.Text = getProperGenre(genre)
    End Sub

    Private Function getProperGenre(ByVal genre As String) As String
        For Each g As String In Form1.genres
            If (genre.Equals(g)) Then
                Return g
            End If
        Next
        Return ""
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Timer1.Stop()
        Form1.Enabled = True
        Form1.BringToFront()
        Form1.CallClearTree()
        Form1.CallTreeUpdate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addMovieBTN.Click
        'save new data file
        If (diskLocation) Then 'creating movie data for a local movie file
            File.WriteAllText(locationSaveFile + movieFileS + ".data", movieDirS + vbNewLine + titleTB.Text + vbNewLine + imdbIDBox.Text + vbNewLine + yearTB.Text + vbNewLine + GenreBox.SelectedItem + vbNewLine +
                              seriesTitleTB.Text + vbNewLine + seriesIterationTB.Text + vbNewLine + "0" + vbNewLine + "0:00:00")
        Else 'creating movie data for a non-existant local movie file(online streaming, dvr viewing, ect..
            File.WriteAllText(locationSaveFile + titleTB.Text + " - " + yearTB.Text + ".data", "$" + movieDirS + vbNewLine + titleTB.Text + vbNewLine + imdbIDBox.Text + vbNewLine + yearTB.Text + vbNewLine + GenreBox.SelectedItem + vbNewLine +
                              seriesTitleTB.Text + vbNewLine + seriesIterationTB.Text + vbNewLine + "0" + vbNewLine + "0:00:00")
        End If
        Button2.PerformClick()
    End Sub

    Private Sub subtractBTN_Click(sender As Object, e As EventArgs) Handles subtractBTN.Click
        If (Integer.Parse(seriesIterationTB.Text) - 1 >= 1) Then
            seriesIterationTB.Text = Integer.Parse(seriesIterationTB.Text - 1)
        End If
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        If (Integer.Parse(seriesIterationTB.Text) + 1 <= 10) Then
            seriesIterationTB.Text = Integer.Parse(seriesIterationTB.Text + 1)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles yearTB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (titleTB.Text.Equals("") Or yearTB.Text.Equals("") Or imdbIDBox.Text.Equals("") Or imdbIDBox.Text.Equals("null")) Then
            addMovieBTN.Enabled = False
        ElseIf Not (titleTB.Text.Equals("") Or yearTB.Text.Equals("") Or imdbIDBox.Text.Equals("") Or imdbIDBox.Text.Equals("null")) Then
            addMovieBTN.Enabled = True
        End If

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

    Public Sub clear()
        titleTB.Text = ""
        yearTB.Text = ""
        seriesTitleTB.Text = ""
        seriesIterationTB.Text = "1"
        dirTextField.Text = ""
        imdbIDBox.Text = ""
        Timer1.Start()
    End Sub

    Private Sub imdbBTN_Click(sender As Object, e As EventArgs) Handles imdbBTN.Click
        If Not (titleTB.Text = "" And yearTB.Text = "") Then
            Dim info As New IMDBinfo(titleTB.Text, yearTB.Text)
            imdbIDBox.Text = info.getID()
        End If
    End Sub

    Private Sub FileOnComputerCB_CheckedChanged(sender As Object, e As EventArgs) Handles FileOnComputerCB.CheckedChanged
        If (FileOnComputerCB.Checked) Then 'allow to load file from computer
            If (dirTextField.Text.Equals("")) Then
                detailsPanel.Enabled = False
            End If
            LoadFileBTN.Text = "Load File"
            urlTextFieldLB.Text = "Directory On Local Drive (Required)"
            diskLocation = True
        Else                               'give option to set viewing URL
            detailsPanel.Enabled = True
            LoadFileBTN.Text = "Authenticate URL"
            urlTextFieldLB.Text = "Streamable URL (Optional)"
            diskLocation = False
        End If
    End Sub
End Class