Imports System.IO
Imports System.Net

Public Class IMDBinfo
    'title: 1, year: 3, rating: 5, plot: 19, poster: 27, imdb rating: 31
    Private title As String = ""
    Private year As String = ""
    Private ageRating As String = ""
    Private plot As String = ""
    Private poster As String = ""
    Private imdbRating As String = ""
    Private id As String = ""
    Private genre As String = ""

    Sub New(ByVal Title As String, ByVal year As Integer)
        Dim finalURL As String = "http://www.omdbapi.com/?t=" + Replace(Title, " ", "+") + "&y=" + year.ToString() + "&r=json"
        Try
            Dim curID As String = New StreamReader(New WebClient().OpenRead(finalURL)).ReadToEnd
            curID = curID.Substring(curID.Length - 44, 9)
            If (curID.Equals("esponse"":")) Then 'non-existant movie found
                id = "null"
            Else
                id = curID
                updateInfo(id)
            End If
        Catch
            id = "null"
        End Try
    End Sub

    Sub New(ByVal curID)
        id = curID
        updateInfo(id)
    End Sub

    Private Sub updateInfo(ByVal movieID As String)
        Dim finalURL As String = "http://www.omdbapi.com/?i=" + movieID + "&plot=full&r=json"

        Try
            Dim json As String = New StreamReader(New WebClient().OpenRead(finalURL)).ReadToEnd
            json = clearErrors(json)
            Dim splits As String() = {}
            splits = json.Split("""")

            Dim importantStuff As List(Of String) = New List(Of String)
            Dim cur = 0
            While (cur < splits.Length)
                If Not (splits(cur).Equals("{") Or splits(cur).Equals("}") Or splits(cur).Equals(":") Or splits(cur).Equals(",")) Then
                    importantStuff.Add(splits(cur))
                End If
                cur += 1
            End While

            'printAll(importantStuff)

            title = importantStuff(1)
            year = importantStuff(3)
            ageRating = importantStuff(5)
            splits = importantStuff(11).Split(",")
            genre = splits(0)
            plot = importantStuff(19)
            poster = importantStuff(27)
            imdbRating = importantStuff(31)
        Catch
        End Try
    End Sub

    Private Function clearErrors(ByVal json As String) As String
        Dim i As Integer = 0
        Dim finalJSOn As String = ""
        Do While i < json.Length
            If (json.Chars(i) = "\") Then
                If (json.Chars(i + 1) = """") Then
                    i += 2
                End If
            Else
                finalJSOn += json.Chars(i)
            End If
            i += 1
        Loop
        Return finalJSOn
    End Function

    Private Sub printAll(ByVal lists As List(Of String))
        Dim i As Integer = 0
        While (i < lists.Count)
            Console.WriteLine(i.ToString() + ": " + lists(i))
            i += 1
        End While
    End Sub

    Public Function getTitle() As String
        Return title
    End Function

    Public Function getYear() As String
        Return year
    End Function

    Public Function getAgeRating() As String
        Return ageRating
    End Function

    Public Function getPlot() As String
        Return plot
    End Function

    Public Function getPoster() As String
        Return poster
    End Function

    Public Function getIMDBRating() As String
        Return imdbRating
    End Function

    Public Function getID() As String
        Return id
    End Function

    Public Function getGenre() As String
        Return genre
    End Function
End Class
