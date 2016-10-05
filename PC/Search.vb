Public Class Search
    Public Function SearchForMovieFormat(ByVal format As String) As List(Of String)
        Dim returnURLs As List(Of String) = New List(Of String)

        Dim files() As String = IO.Directory.GetFiles(Form1.locationForData)
        Dim info As List(Of String) = New List(Of String)
        If files.Length <> 0 Then
            For Each file As String In files
                If IO.Path.GetFileName(file).EndsWith(".data") Then 'proper data file
                    info = getInfo(file)
                    For Each inf As String In info
                        If (inf.Contains(format)) Then
                            returnURLs.Add(file)
                        End If
                    Next
                End If
            Next
        End If
        Return clearDuplicates(returnURLs)
    End Function

    Public Function SearchForMovieGenre(ByVal genre As String) As List(Of String)
        Dim returnURLs As List(Of String) = New List(Of String)

        Dim files() As String = IO.Directory.GetFiles(Form1.locationForData)
        Dim info As List(Of String) = New List(Of String)
        If files.Length <> 0 Then
            For Each file As String In files
                If IO.Path.GetFileName(file).EndsWith(".data") Then 'proper data file
                    info = getInfo(file)
                    If (info(4).Contains(genre)) Then
                        returnURLs.Add(file)
                    End If
                End If
            Next
        End If
        Return clearDuplicates(returnURLs)
    End Function

    Public Function SearchForMovieQuality(ByVal quality As String) As List(Of String)
        Dim returnURLs As List(Of String) = New List(Of String)

        Dim files() As String = IO.Directory.GetFiles(Form1.locationForData)
        Dim info As List(Of String) = New List(Of String)
        If files.Length <> 0 Then
            For Each file As String In files
                If IO.Path.GetFileName(file).EndsWith(".data") Then 'proper data file
                    info = getInfo(file)
                    For Each inf As String In info
                        If (inf.Contains(quality)) Then
                            returnURLs.Add(file)
                        End If
                    Next
                End If
            Next
        End If
        Return clearDuplicates(returnURLs)
    End Function

    Public Function SearchForMovieTitle(ByVal title As String) As List(Of String)
        Dim returnURLs As List(Of String) = New List(Of String)

        Dim files() As String = IO.Directory.GetFiles(Form1.locationForData)
        Dim info As List(Of String) = New List(Of String)
        If files.Length <> 0 Then
            For Each file As String In files
                If IO.Path.GetFileName(file).EndsWith(".data") Then 'proper data file
                    info = getInfo(file)
                    For Each inf As String In info
                        info = getInfo(file)
                        If (info(1).Contains(title) Or info(5).Contains(title)) Then
                            returnURLs.Add(file)
                        End If
                    Next
                End If
            Next
        End If
        Return clearDuplicates(returnURLs)
    End Function

    Public Function SearchForMovieSeriesItteration(ByVal itteration As Integer) As List(Of String)
        Dim returnURLs As List(Of String) = New List(Of String)

        Dim files() As String = IO.Directory.GetFiles(Form1.locationForData)
        Dim info As List(Of String) = New List(Of String)
        If files.Length <> 0 Then
            For Each file As String In files
                If IO.Path.GetFileName(file).EndsWith(".data") Then 'proper data file
                    info = getInfo(file)
                    For Each inf As String In info
                        info = getInfo(file)
                        If (info(6).Contains(itteration)) Then
                            returnURLs.Add(file)
                        End If
                    Next
                End If
            Next
        End If
        Return clearDuplicates(returnURLs)
    End Function

    Public Function SearchForMovieYear(ByVal year As Integer) As List(Of String)
        Dim returnURLs As List(Of String) = New List(Of String)

        Dim files() As String = IO.Directory.GetFiles(Form1.locationForData)
        Dim info As List(Of String) = New List(Of String)
        If files.Length <> 0 Then
            For Each file As String In files
                If IO.Path.GetFileName(file).EndsWith(".data") Then 'proper data file
                    info = getInfo(file)
                    For Each inf As String In info
                        info = getInfo(file)
                        If (info(3).Contains(year)) Then
                            returnURLs.Add(file)
                        End If
                    Next
                End If
            Next
        End If
        Return clearDuplicates(returnURLs)
    End Function

    Private Function getInfo(ByVal file As String) As List(Of String)
        Dim allLines As List(Of String) = New List(Of String)

        Dim reader As New System.IO.StreamReader(file)
        Do While Not reader.EndOfStream
            allLines.Add(reader.ReadLine().ToLower())
        Loop
        reader.Close()
        Return allLines
    End Function

    Private Function clearDuplicates(ByVal urls As List(Of String)) As List(Of String)
        Dim finalreturn As List(Of String) = New List(Of String)
        For Each url In urls
            If Not (finalreturn.Contains(url)) Then
                finalreturn.Add(url)
            End If
        Next
        Return finalreturn
    End Function
End Class
