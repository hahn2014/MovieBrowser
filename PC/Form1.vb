Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Text.RegularExpressions


Public Class Form1
    Dim selectedMovie As TreeNode

    Dim searchResults As Integer = 0
    Dim TreeListGB As Long = 0
    Public locationForData As String = "C:\Users\" + Environment.UserName + "\AppData\Local\MovieBrowser\MovieData\"

    Public genres As String() = {"action", "adventure", "animation", "biography", "comedy", "crime", "documentary", "drama", "family", "fantasy", "history", "horror", "musical", "mystery", "romance", "sci-fi", "science fiction", "sport", "thriller", "war", "western"}

    Public BUILD As String = "1.25"
    Public UPDBuild As String = ""

    Dim curMovieURL As String = ""
    Dim curMovieTime As String = ""
    Dim curMoviePlays As Integer = 0
    Public curMovieYear As Integer = 0
    Public curMovieTitle As String = ""
    Public curMovieFile As String = ""
    Dim curMoviePoster As String = ""
    Dim curMovieID As String = ""
    Dim curMovieGenre As String = ""
    Dim curMovieSeriesTitle As String = ""
    Dim curMovieSeriesIteration As Integer = 1
    Dim localMovieFile As Boolean = True

    Dim selectedNode As TreeNode

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MovieTreeList.Nodes.Count > 0) Then
            CallClearTree()
        End If
        CallTreeUpdate()
    End Sub

    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        Dim folder As String = String.Empty
        Try
            'Add the files to treeview
            Dim files() As String = IO.Directory.GetFiles(dir)
            If files.Length <> 0 Then
                Dim fileNode As TreeNode = Nothing
                For Each file As String In files
                    If IO.Path.GetFileName(file).EndsWith(".data") Then
                        fileNode = parentNode.Nodes.Add(IO.Path.GetFileName(file))
                        fileNode.Tag = file
                        fileNode.Text = IO.Path.GetFileName(file)
                        searchResults += 1
                        Dim loc As String = getMovieFileFromDataFile(file)
                        If Not (loc = "null") Then
                            Dim infoReader As System.IO.FileInfo
                            infoReader = My.Computer.FileSystem.GetFileInfo(loc)
                            TreeListGB += infoReader.Length
                        End If
                    End If
                Next
            End If
            'Add folders to treeview
            Dim folders() As String = IO.Directory.GetDirectories(dir)
            If folders.Length <> 0 Then
                Dim folderNode As TreeNode = Nothing
                Dim folderName As String = String.Empty
                For Each folder In folders
                    folderName = IO.Path.GetFileName(folder)
                    folderNode = parentNode.Nodes.Add(folderName)
                    folderNode.Tag = folder
                    PopulateTreeView(folder, folderNode)
                Next
            End If
        Catch ex As UnauthorizedAccessException
            parentNode.Nodes.Add("Access Denied")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        searchResults = 0
        TreeListGB = 0
        TreeListData.Text = ""
        'search throught the list for movies, genres, qualities, years, extensions, ect...
        If Not (SearchBox.Text = "") Then
            'textbox is not empty, lets search for the title, date, quality, or filetype
            'set to search view
            MovieTreeList.Nodes.Clear()
            SearchBackButton.Visible = True
            Dim text As String = SearchBox.Text.ToLower()
            'the easiest search, look for a file type
            If (text.Contains(".mp4")) Then
                SearchMoviesForKeyword(".mp4", 1)
            End If
            If (text.Contains(".mkv")) Then
                SearchMoviesForKeyword(".mkv", 1)
            End If
            'video quality
            If (text.Contains("1080")) Then
                SearchMoviesForKeyword("1080p", 2)
            End If
            If (text.Contains("720")) Then
                SearchMoviesForKeyword("720p", 2)
            End If
            'genres
            For Each g As String In genres
                If (text.Contains(g)) Then
                    SearchMoviesForKeyword(text, 4)
                End If
            Next
            'year / series itteration if number low enough
            If (IsNumeric(text)) Then
                SearchMoviesForKeyword(text, 5)
            End If
            SearchMoviesForKeyword(SearchBox.Text, 3)
            updateTreeListDataLabel()
        End If
    End Sub

    Private Sub SearchMoviesForKeyword(ByVal keyword As String, ByVal searchType As Integer)
        Dim s As New Search()
        Dim files As List(Of String) = New List(Of String)
        If (searchType = 1) Then 'file type
            Console.WriteLine("Searching For File Types Of " + keyword)
            files = s.SearchForMovieFormat(keyword)
        ElseIf (searchType = 2) Then 'movie quality
            Console.WriteLine("Searching For Movie Quality Of " + keyword)
            files = s.SearchForMovieQuality(keyword)
        ElseIf (searchType = 3) Then 'title
            Console.WriteLine("Searching For Title Of " + keyword)
            files = s.SearchForMovieTitle(keyword)
        ElseIf (searchType = 4) Then 'genre
            Console.WriteLine("Searching For Genres Of " + keyword)
            files = s.SearchForMovieGenre(keyword)
        ElseIf (searchType = 5) Then 'year or series itteration
            If (Convert.ToInt32(keyword) < 50) Then 'series itteration
                Console.WriteLine("Searching For A Series Itteration Of " + keyword)
                files = s.SearchForMovieSeriesItteration(keyword)
            Else
                Console.WriteLine("Searching For Titles In Year Of " + keyword)
                files = s.SearchForMovieYear(keyword)
            End If
        End If

        Dim node As TreeNode = Nothing
        Dim rootDir As String = locationForData
        Dim root As TreeNode = MovieTreeList.Nodes.Add(rootDir)
        root.Tag = rootDir
        If (files.Count >= 1) Then
            root.Text = "Results For " + keyword + " Query"
            For Each File In files
                node = MovieTreeList.Nodes(0).Nodes.Add(IO.Path.GetFileName(File))
                searchResults += 1
                Dim loc As String = getMovieFileFromDataFile(File)
                If Not (loc = "null") Then
                    Dim infoReader As System.IO.FileInfo
                    infoReader = My.Computer.FileSystem.GetFileInfo(loc)
                    TreeListGB += infoReader.Length
                End If
                node.Tag = File
                node.Text = IO.Path.GetFileName(File)
                'MovieTreeList.Nodes(0).Nodes.Add(node)
            Next
            MovieTreeList.ExpandAll()
            MovieTreeList.SelectedNode = MovieTreeList.Nodes(0)
            MovieTreeList.Select()
        Else
            root.Text = "No Results Were Found For " + keyword + " Query"
        End If
        Console.WriteLine("Search Completed. There were " + searchResults.ToString() + " results for the query " + keyword.ToString())
    End Sub

    Public Sub CallTreeUpdate()
        TreeListData.Text = ""
        TreeListGB = 0
        searchResults = 0
        MovieTreeList.Nodes.Clear()
        Dim rootDir As String = locationForData
        'Add this drive as a root node
        Dim root As TreeNode = MovieTreeList.Nodes.Add(rootDir)
        root.Tag = rootDir
        root.Text = "Movies"
        'Populate this root node
        PopulateTreeView(rootDir, MovieTreeList.Nodes(0))
        'show all movie options and open all folders
        MovieTreeList.ExpandAll()
        MovieTreeList.SelectedNode = MovieTreeList.Nodes(0)
        MovieTreeList.Select()
        updateTreeListDataLabel()
    End Sub

    Public Sub CallClearTree()
        MovieTreeList.Nodes.Clear()
    End Sub

    Public Sub updateMovieData(ByVal filename As String, ByVal curpos As String, ByVal views As Integer)
        filename = filename + ".data"
        Console.WriteLine("Updating Movie Data In -> " + locationForData + filename)
        Dim objWriter As New System.IO.StreamWriter(locationForData + filename, False)
        objWriter.WriteLine(curMovieURL + vbNewLine + curMovieTitle + vbNewLine + curMovieID + vbNewLine + curMovieYear.ToString() + vbNewLine + curMovieGenre + vbNewLine + curMovieSeriesTitle + vbNewLine + curMovieSeriesIteration.ToString() + vbNewLine + views.ToString() + vbNewLine + curpos.ToString())
        objWriter.Close()
    End Sub

    Private Sub SearchBackButton_Click(sender As Object, e As EventArgs) Handles SearchBackButton.Click
        'set view back to main directory list
        SearchBackButton.Visible = False
        CallTreeUpdate()
        SearchBox.Text = ""
    End Sub

    Private Sub StartMovieButton_Click(sender As Object, e As EventArgs) Handles StartMovieButton.Click
        If (localMovieFile) Then
            If (File.Exists(curMovieURL)) Then
                'open video player starting at designated position in data file
                VideoPlayer.getMovieDataFromForm1(curMovieURL, curMovieTitle, curMovieFile)
                VideoPlayer.GetMovieData(curMovieTime, curMoviePlays)
                VideoPlayer.Show()
                Me.Hide()
            Else
                Dim result = MsgBox("The Movie File Was Not Found In The Location [" + curMovieURL + "]" + vbNewLine + "Maybe You Deleted The Movie File." + vbNewLine + "Do You Wish To Delete The Movie Data?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "File Not Found")
                If (result = MsgBoxResult.Yes) Then
                    Console.WriteLine("deleting " + locationForData + selectedNode.Text)
                    File.Delete(locationForData + selectedNode.Text)
                    CallClearTree()
                    CallTreeUpdate()
                    MovieTreeList.SelectedNode = MovieTreeList.Nodes(0)
                    MovieTreeList.Select()
                    hideMovieInfoPanel()
                    Exit Sub
                ElseIf (result = MsgBoxResult.No) Then
                    Console.WriteLine("User chose to keep movie data")
                End If
            End If
        Else
            Dim webAddress As String = curMovieURL
            Process.Start(webAddress)
        End If
    End Sub

    Private Sub RestartMovieButton_Click(sender As Object, e As EventArgs) Handles RestartMovieButton.Click
        'open video player starting at begining
        VideoPlayer.getMovieDataFromForm1(curMovieURL, curMovieTitle, curMovieFile)
        VideoPlayer.GetMovieData("00:00", curMoviePlays)
        VideoPlayer.Show()
        Me.Hide()
    End Sub

    Private Function retreieveMovieDataFromAPI(ByVal movieID As String) As String
        curMoviePoster = "http://img.omdbapi.com/?apikey=3088e9b6&i=" + movieID
        Return curMoviePoster
    End Function

    Private Sub AddMovieFile_Click(sender As Object, e As EventArgs) Handles AddMovieFile.Click
        AddMovie.clear()
        AddMovie.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check for environment vars to see if application was updated
        If Environment.GetCommandLineArgs.Count <> 1 Then
            If Environment.GetCommandLineArgs(1).StartsWith("-updatedF") Then
                AutoUpdate.removeOldFilesOnStartup(Environment.GetCommandLineArgs(1))
            End If
        End If

        Button2.PerformClick()
        Me.Text = "Movie Browser PC - Version " + BUILD
        checkForUpdate()
    End Sub

    Private Sub MovieTreeList_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MovieTreeList.KeyDown
        If e.KeyCode < Keys.Down Then
            If (MovieTreeList.SelectedNode.Index + 1 < MovieTreeList.Nodes.Count) Then
                Console.WriteLine(MovieTreeList.SelectedNode.Index + " / " + MovieTreeList.Nodes.Count)
            End If
        ElseIf e.KeyCode < Keys.Up Then
            
        End If
    End Sub

    Private Sub MovieTreeList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MovieTreeList.AfterSelect
        'if the node you're clicking on is an actual movie file
        If (e.Node.Text.EndsWith(".data")) Then
            selectedNode = e.Node
            selectedMovie = e.Node
            'display current viewing data
            Dim reader As New System.IO.StreamReader(locationForData + e.Node.Text)
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim info As New IMDBinfo(allLines(2))
            curMovieFile = e.Node.Text.Substring(0, e.Node.Text.Length - 5)
            PlayPositionLabel.Text = "Current Viewing Position: " + allLines(8)
            curMovieTime = allLines(8)
            PlayCountLabel.Text = "Full Plays: " + allLines(7)
            curMoviePlays = Convert.ToInt32(allLines(7))
            yearLabel.Text = "Year: " + allLines(3) + " / Genre: " + allLines(4)
            curMovieYear = Convert.ToInt32(allLines(3))
            If (allLines(0).StartsWith("$")) Then
                curMovieURL = allLines(0).Substring(1, allLines(0).Length - 1)
                localMovieFile = False
            Else
                curMovieURL = allLines(0)
                localMovieFile = True
            End If
            'enable movie info view
            StartMovieButton.Visible = True
            If (localMovieFile) Then
                If Not (PlayPositionLabel.Text.EndsWith("0:00:00")) Then
                    StartMovieButton.Text = "Resume Movie"
                    RestartMovieButton.Visible = True
                Else
                    If (PlayCountLabel.Text.EndsWith("0")) Then
                        StartMovieButton.Text = "Start Movie"
                    Else
                        StartMovieButton.Text = "Replay Movie"
                    End If
                    RestartMovieButton.Visible = False
                End If
            Else
                StartMovieButton.Text = "View Streaming Page"
                RestartMovieButton.Visible = False
            End If
            MovieTitleLabel.Visible = True
            PlayPositionLabel.Visible = True
            PlayCountLabel.Visible = True
            updateMovieDataBTN.Visible = True
            deleteBTN.Visible = True
            yearLabel.Visible = True
            SeriesItterationLabel.Visible = True
            MovieTitleLabel.Text = allLines(1)
            If (allLines(5).Equals("")) Then
                SeriesItterationLabel.Text = ""
            Else
                SeriesItterationLabel.Text = allLines(6) + getNumericEnding(allLines(6)) + " Film Of " + allLines(5) + " Series"
            End If

            curMovieTitle = info.getTitle()
            curMovieID = info.getID()
            curMovieGenre = allLines(4)
            If (allLines(4).Equals("")) Then
                yearLabel.Text = "Year: " + allLines(3) + " / Genre: " + info.getGenre()
                curMovieGenre = info.getGenre()
            End If
            curMovieSeriesTitle = allLines(5)
            curMovieSeriesIteration = allLines(6)
            Try
                MovieImageBox.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(info.getPoster())))
            Catch
                MovieImageBox.Image = My.Resources.placeholder
            End Try
        End If
    End Sub

    Private Function getNumericEnding(ByVal number As String) As String
        Dim a As String = ""
        If (Convert.ToInt32(number) > 10 And Convert.ToInt32(number) < 21) Then
            If (number.EndsWith("1")) Then
                a = "th"
            ElseIf (number.EndsWith("2")) Then
                a = "th"
            ElseIf (number.EndsWith("3")) Then
                a = "th"
            ElseIf (number.EndsWith("4")) Then
                a = "th"
            ElseIf (number.EndsWith("5")) Then
                a = "th"
            ElseIf (number.EndsWith("6")) Then
                a = "th"
            ElseIf (number.EndsWith("7")) Then
                a = "th"
            ElseIf (number.EndsWith("8")) Then
                a = "th"
            ElseIf (number.EndsWith("9")) Then
                a = "th"
            ElseIf (number.EndsWith("0")) Then
                a = "th"
            End If
        Else
            If (number.EndsWith("1")) Then
                a = "st"
            ElseIf (number.EndsWith("2")) Then
                a = "nd"
            ElseIf (number.EndsWith("3")) Then
                a = "rd"
            ElseIf (number.EndsWith("4")) Then
                a = "th"
            ElseIf (number.EndsWith("5")) Then
                a = "th"
            ElseIf (number.EndsWith("6")) Then
                a = "th"
            ElseIf (number.EndsWith("7")) Then
                a = "th"
            ElseIf (number.EndsWith("8")) Then
                a = "th"
            ElseIf (number.EndsWith("9")) Then
                a = "th"
            ElseIf (number.EndsWith("0")) Then
                a = "th"
            End If
        End If
        Return a
    End Function

    Private Sub updateMovieDataBTN_Click(sender As Object, e As EventArgs) Handles updateMovieDataBTN.Click
        UpdateData.Show()
        UpdateData.setMovieFileURL(curMovieFile, curMovieURL)
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles deleteBTN.Click
        My.Computer.FileSystem.DeleteFile(locationForData + curMovieFile + ".data", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
        Button2.PerformClick()
        CallClearTree()
        CallTreeUpdate()
        MovieTreeList.SelectedNode = MovieTreeList.Nodes(0)
        MovieTreeList.Select()
        hideMovieInfoPanel()
    End Sub

    Private Sub hideMovieInfoPanel()
        StartMovieButton.Visible = False
        RestartMovieButton.Visible = False
        MovieTitleLabel.Visible = False
        PlayPositionLabel.Visible = False
        PlayCountLabel.Visible = False
        updateMovieDataBTN.Visible = False
        deleteBTN.Visible = False
        yearLabel.Visible = False
        SeriesItterationLabel.Visible = False
        MovieImageBox.Image = Nothing
    End Sub

    Private Sub updateTreeListDataLabel()
        If (searchResults > 0) Then
            If (searchResults = 1) Then
                TreeListData.Text = (Math.Round((TreeListGB / 1073741824), 2, MidpointRounding.AwayFromZero)).ToString() + " GB" + vbNewLine + "1 result"
            Else
                TreeListData.Text = (Math.Round((TreeListGB / 1073741824), 2, MidpointRounding.AwayFromZero)).ToString() + " GB" + vbNewLine + searchResults.ToString() + " results"
            End If
        Else
            TreeListData.Text = ""
        End If
    End Sub

    Private Function getMovieFileFromDataFile(ByVal a As String) As String
        Dim reader As New System.IO.StreamReader(a)
        Dim allLines As List(Of String) = New List(Of String)
        Do While Not reader.EndOfStream
            allLines.Add(reader.ReadLine())
        Loop
        reader.Close()
        If Not (allLines(0).StartsWith("$")) Then
            Return allLines(0)
        Else
            Return "null"
        End If
    End Function

    Private Sub checkForUpdate()
        AutoUpdate.removeOldFilesOnStartup("-updateF1.22")
        Dim address As String = "https://raw.githubusercontent.com/hahn2014/MovieBrowser/master/.autoupdate"
        Dim client As WebClient = New WebClient()
        Dim t As String = ""
        Try
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            t = reader.ReadToEnd
            reader.Close()
        Catch
            Console.WriteLine("We couldnt find the update file????")
        End Try
        If (t.StartsWith("PC")) Then
            Dim version = t.Substring(2, t.Length - 2)
            UPDBuild = version
            If (BUILD = version) Then
            Else
                'test if it is higher or lower.. should never be higher but ya never know what people are doing with my code ;P
                Dim onlineRelease As Integer = Convert.ToInt32(version.Substring(0, 1))
                Dim onlineBuild As Integer = Convert.ToInt32(version.Substring(2, 2))
                Dim localRelease As Integer = Convert.ToInt32(BUILD.Substring(0, 1))
                Dim localBuild As Integer = Convert.ToInt32(BUILD.Substring(2, 2))

                Dim needsUpdate = False
                If (localRelease < onlineRelease) Then
                    'we are behind on a release, definitely update!
                    needsUpdate = True
                Else
                    If (localBuild < onlineBuild) Then
                        needsUpdate = True
                    Else
                        needsUpdate = False
                    End If
                End If
                If (needsUpdate) Then
                    Console.WriteLine("There is a new update available! local version: " + BUILD + ", online version: " + version)
                    Me.Enabled = False
                    AutoUpdate.Show()
                Else
                    Console.WriteLine("There is an older update available... local version: " + BUILD + ", online version: " + version)
                End If
            End If
        End If
    End Sub
End Class