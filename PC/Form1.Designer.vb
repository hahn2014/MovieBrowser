<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MovieDetailsPanel = New System.Windows.Forms.Panel()
        Me.deleteBTN = New System.Windows.Forms.Button()
        Me.updateMovieDataBTN = New System.Windows.Forms.Button()
        Me.SeriesItterationLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.RestartMovieButton = New System.Windows.Forms.Button()
        Me.PlayCountLabel = New System.Windows.Forms.Label()
        Me.PlayPositionLabel = New System.Windows.Forms.Label()
        Me.MovieImageBox = New System.Windows.Forms.PictureBox()
        Me.MovieTitleLabel = New System.Windows.Forms.Label()
        Me.StartMovieButton = New System.Windows.Forms.Button()
        Me.MovieTreeList = New System.Windows.Forms.TreeView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SearchBackButton = New System.Windows.Forms.Button()
        Me.AddMovieFile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MovieDetailsPanel.SuspendLayout()
        CType(Me.MovieImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(189, 7)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Location = New System.Drawing.Point(14, 10)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchBox.MaxLength = 26
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(173, 20)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.MovieDetailsPanel)
        Me.Panel1.Controls.Add(Me.SearchBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(1060, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 797)
        Me.Panel1.TabIndex = 2
        '
        'MovieDetailsPanel
        '
        Me.MovieDetailsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovieDetailsPanel.BackColor = System.Drawing.Color.Black
        Me.MovieDetailsPanel.Controls.Add(Me.deleteBTN)
        Me.MovieDetailsPanel.Controls.Add(Me.updateMovieDataBTN)
        Me.MovieDetailsPanel.Controls.Add(Me.SeriesItterationLabel)
        Me.MovieDetailsPanel.Controls.Add(Me.yearLabel)
        Me.MovieDetailsPanel.Controls.Add(Me.RestartMovieButton)
        Me.MovieDetailsPanel.Controls.Add(Me.PlayCountLabel)
        Me.MovieDetailsPanel.Controls.Add(Me.PlayPositionLabel)
        Me.MovieDetailsPanel.Controls.Add(Me.MovieImageBox)
        Me.MovieDetailsPanel.Controls.Add(Me.MovieTitleLabel)
        Me.MovieDetailsPanel.Controls.Add(Me.StartMovieButton)
        Me.MovieDetailsPanel.Location = New System.Drawing.Point(11, 38)
        Me.MovieDetailsPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MovieDetailsPanel.Name = "MovieDetailsPanel"
        Me.MovieDetailsPanel.Size = New System.Drawing.Size(229, 750)
        Me.MovieDetailsPanel.TabIndex = 2
        '
        'deleteBTN
        '
        Me.deleteBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteBTN.Location = New System.Drawing.Point(169, 720)
        Me.deleteBTN.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteBTN.Name = "deleteBTN"
        Me.deleteBTN.Size = New System.Drawing.Size(50, 22)
        Me.deleteBTN.TabIndex = 9
        Me.deleteBTN.Text = "Delete"
        Me.deleteBTN.UseVisualStyleBackColor = True
        Me.deleteBTN.Visible = False
        '
        'updateMovieDataBTN
        '
        Me.updateMovieDataBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateMovieDataBTN.Location = New System.Drawing.Point(10, 720)
        Me.updateMovieDataBTN.Margin = New System.Windows.Forms.Padding(2)
        Me.updateMovieDataBTN.Name = "updateMovieDataBTN"
        Me.updateMovieDataBTN.Size = New System.Drawing.Size(154, 22)
        Me.updateMovieDataBTN.TabIndex = 8
        Me.updateMovieDataBTN.Text = "Update Movie Data Manually"
        Me.updateMovieDataBTN.UseVisualStyleBackColor = True
        Me.updateMovieDataBTN.Visible = False
        '
        'SeriesItterationLabel
        '
        Me.SeriesItterationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeriesItterationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SeriesItterationLabel.Location = New System.Drawing.Point(7, 47)
        Me.SeriesItterationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SeriesItterationLabel.Name = "SeriesItterationLabel"
        Me.SeriesItterationLabel.Size = New System.Drawing.Size(212, 31)
        Me.SeriesItterationLabel.TabIndex = 7
        Me.SeriesItterationLabel.Text = "Series 0/0"
        Me.SeriesItterationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SeriesItterationLabel.Visible = False
        '
        'yearLabel
        '
        Me.yearLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.yearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.yearLabel.Location = New System.Drawing.Point(6, 78)
        Me.yearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(212, 21)
        Me.yearLabel.TabIndex = 6
        Me.yearLabel.Text = "Movie Year / Genre"
        Me.yearLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.yearLabel.Visible = False
        '
        'RestartMovieButton
        '
        Me.RestartMovieButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestartMovieButton.Location = New System.Drawing.Point(112, 694)
        Me.RestartMovieButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RestartMovieButton.Name = "RestartMovieButton"
        Me.RestartMovieButton.Size = New System.Drawing.Size(107, 22)
        Me.RestartMovieButton.TabIndex = 5
        Me.RestartMovieButton.Text = "Restart Movie"
        Me.RestartMovieButton.UseVisualStyleBackColor = True
        Me.RestartMovieButton.Visible = False
        '
        'PlayCountLabel
        '
        Me.PlayCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PlayCountLabel.Location = New System.Drawing.Point(6, 343)
        Me.PlayCountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PlayCountLabel.Name = "PlayCountLabel"
        Me.PlayCountLabel.Size = New System.Drawing.Size(212, 15)
        Me.PlayCountLabel.TabIndex = 4
        Me.PlayCountLabel.Text = "Play Count"
        Me.PlayCountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PlayCountLabel.Visible = False
        '
        'PlayPositionLabel
        '
        Me.PlayPositionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayPositionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PlayPositionLabel.Location = New System.Drawing.Point(6, 321)
        Me.PlayPositionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PlayPositionLabel.Name = "PlayPositionLabel"
        Me.PlayPositionLabel.Size = New System.Drawing.Size(212, 15)
        Me.PlayPositionLabel.TabIndex = 3
        Me.PlayPositionLabel.Text = "Play Position"
        Me.PlayPositionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PlayPositionLabel.Visible = False
        '
        'MovieImageBox
        '
        Me.MovieImageBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovieImageBox.Location = New System.Drawing.Point(9, 101)
        Me.MovieImageBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MovieImageBox.Name = "MovieImageBox"
        Me.MovieImageBox.Size = New System.Drawing.Size(209, 218)
        Me.MovieImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MovieImageBox.TabIndex = 2
        Me.MovieImageBox.TabStop = False
        '
        'MovieTitleLabel
        '
        Me.MovieTitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovieTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MovieTitleLabel.Location = New System.Drawing.Point(7, 10)
        Me.MovieTitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MovieTitleLabel.Name = "MovieTitleLabel"
        Me.MovieTitleLabel.Size = New System.Drawing.Size(212, 37)
        Me.MovieTitleLabel.TabIndex = 1
        Me.MovieTitleLabel.Text = "Movie Title"
        Me.MovieTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MovieTitleLabel.Visible = False
        '
        'StartMovieButton
        '
        Me.StartMovieButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartMovieButton.Location = New System.Drawing.Point(9, 694)
        Me.StartMovieButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartMovieButton.Name = "StartMovieButton"
        Me.StartMovieButton.Size = New System.Drawing.Size(99, 22)
        Me.StartMovieButton.TabIndex = 0
        Me.StartMovieButton.Text = "Start Movie"
        Me.StartMovieButton.UseVisualStyleBackColor = True
        Me.StartMovieButton.Visible = False
        '
        'MovieTreeList
        '
        Me.MovieTreeList.AllowDrop = True
        Me.MovieTreeList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovieTreeList.BackColor = System.Drawing.Color.Gainsboro
        Me.MovieTreeList.FullRowSelect = True
        Me.MovieTreeList.HotTracking = True
        Me.MovieTreeList.Indent = 20
        Me.MovieTreeList.Location = New System.Drawing.Point(1, 0)
        Me.MovieTreeList.Margin = New System.Windows.Forms.Padding(2)
        Me.MovieTreeList.Name = "MovieTreeList"
        Me.MovieTreeList.ShowNodeToolTips = True
        Me.MovieTreeList.Size = New System.Drawing.Size(1065, 824)
        Me.MovieTreeList.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1071, 794)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 22)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update Movie List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SearchBackButton
        '
        Me.SearchBackButton.Location = New System.Drawing.Point(990, 794)
        Me.SearchBackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchBackButton.Name = "SearchBackButton"
        Me.SearchBackButton.Size = New System.Drawing.Size(65, 21)
        Me.SearchBackButton.TabIndex = 7
        Me.SearchBackButton.Text = "Go Back"
        Me.SearchBackButton.UseVisualStyleBackColor = True
        Me.SearchBackButton.Visible = False
        '
        'AddMovieFile
        '
        Me.AddMovieFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddMovieFile.Location = New System.Drawing.Point(1193, 793)
        Me.AddMovieFile.Margin = New System.Windows.Forms.Padding(2)
        Me.AddMovieFile.Name = "AddMovieFile"
        Me.AddMovieFile.Size = New System.Drawing.Size(103, 22)
        Me.AddMovieFile.TabIndex = 8
        Me.AddMovieFile.Text = "Add Movie File"
        Me.AddMovieFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1307, 824)
        Me.Controls.Add(Me.AddMovieFile)
        Me.Controls.Add(Me.SearchBackButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MovieTreeList)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(859, 540)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bryce Hahn's Movie Browser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MovieDetailsPanel.ResumeLayout(False)
        CType(Me.MovieImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MovieTreeList As System.Windows.Forms.TreeView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MovieDetailsPanel As System.Windows.Forms.Panel
    Friend WithEvents SearchBackButton As System.Windows.Forms.Button
    Friend WithEvents StartMovieButton As System.Windows.Forms.Button
    Friend WithEvents MovieTitleLabel As System.Windows.Forms.Label
    Friend WithEvents MovieImageBox As System.Windows.Forms.PictureBox
    Friend WithEvents PlayPositionLabel As System.Windows.Forms.Label
    Friend WithEvents PlayCountLabel As System.Windows.Forms.Label
    Friend WithEvents RestartMovieButton As System.Windows.Forms.Button
    Friend WithEvents AddMovieFile As System.Windows.Forms.Button
    Friend WithEvents yearLabel As System.Windows.Forms.Label
    Friend WithEvents SeriesItterationLabel As System.Windows.Forms.Label
    Friend WithEvents updateMovieDataBTN As System.Windows.Forms.Button
    Friend WithEvents deleteBTN As System.Windows.Forms.Button

End Class
