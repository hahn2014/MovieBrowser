Imports System.Net
Imports System.IO
Imports System.IO.Compression
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class AutoUpdate
    Dim updated As Boolean = False
    Dim fileDownloadPath As String = AppDomain.CurrentDomain.BaseDirectory

    Public Sub downloadToTemp()
        Console.WriteLine("Downloading new Update! Thank you for updating")
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        client.DownloadFileAsync(New Uri("https://github.com/hahn2014/MovieBrowser/blob/master/PC/bin/Debug/Movie%20Browser.exe?raw=true"), fileDownloadPath + "Movie Browser " + Form1.UPDBuild + ".exe")
        UpdateBTN.Text = "Downloading..."
        UpdateBTN.Enabled = False
        Later.Visible = False
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        Me.Text = Math.Truncate(percentage).ToString() + "%"
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        updated = True
        UpdateBTN.Text = "Install"
        UpdateBTN.Enabled = True
    End Sub

    Private Sub AutoUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        UpdateText.Text = "We found an update available online. It is highly recommended to update. Bringing new features and stability improvements and bug fixes, new updates are the best way to enjoy Movie Browser PC." + vbNewLine + vbNewLine +
            "Current Version: " + Form1.BUILD + " -- Update Available: " + Form1.UPDBuild
    End Sub

    Private Sub restart()
        Process.Start(fileDownloadPath + "Movie Browser " + Form1.UPDBuild + ".exe", "-updatedF" + Form1.BUILD)
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Later.Click
        Form1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        If (updated = False) Then
            downloadToTemp()
        Else
            'extract and close program.
            UpdateBTN.Visible = False
            restart()
        End If
    End Sub

    Public Sub removeOldFilesOnStartup(ByVal a As String)
        a = a.Substring(8, a.Length - 8)
        Console.WriteLine("Removing version " + a)
        Try
            My.Computer.FileSystem.DeleteFile(fileDownloadPath + "Movie Browser " + a + ".exe")
            Console.WriteLine("success!")
        Catch
            Console.WriteLine("couldn't find file " + fileDownloadPath + "Movie Browser " + a + ".exe")
        End Try
    End Sub
End Class