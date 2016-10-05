Public Class MovieDB
    Public Property title As String
    Public Property year As String
    Public Property plot As String
    Public Property poster As String

    Public Function getAll() As String
        Return title + " [" + year + "] - " + plot + " {" + poster + "}"
    End Function
End Class
