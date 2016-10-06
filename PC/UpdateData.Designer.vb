<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateData
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateData))
        Me.CancleBTN = New System.Windows.Forms.Button()
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.titleLB = New System.Windows.Forms.Label()
        Me.titleTB = New System.Windows.Forms.TextBox()
        Me.yearTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GenreBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imdbIDBox = New System.Windows.Forms.TextBox()
        Me.imdbBTN = New System.Windows.Forms.Button()
        Me.seriesTitleTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addBTN = New System.Windows.Forms.Button()
        Me.subtractBTN = New System.Windows.Forms.Button()
        Me.seriesIterationTB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IMDBinfo = New System.Windows.Forms.Label()
        Me.IMDBTitle = New System.Windows.Forms.Label()
        Me.IMDBpic = New System.Windows.Forms.PictureBox()
        Me.addBTN2 = New System.Windows.Forms.Button()
        Me.subtractBTN2 = New System.Windows.Forms.Button()
        Me.PlayCountBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hourBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.minBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.secBox = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ChangeFile = New System.Windows.Forms.Button()
        Me.directoryUpdater = New System.Windows.Forms.OpenFileDialog()
        Me.IMDBPlot = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.IMDBpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancleBTN
        '
        Me.CancleBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancleBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancleBTN.Location = New System.Drawing.Point(873, 540)
        Me.CancleBTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancleBTN.Name = "CancleBTN"
        Me.CancleBTN.Size = New System.Drawing.Size(77, 35)
        Me.CancleBTN.TabIndex = 0
        Me.CancleBTN.Text = "Cancle"
        Me.CancleBTN.UseVisualStyleBackColor = True
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateBTN.Location = New System.Drawing.Point(749, 541)
        Me.UpdateBTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(116, 35)
        Me.UpdateBTN.TabIndex = 1
        Me.UpdateBTN.Text = "Update Data"
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'titleLB
        '
        Me.titleLB.AutoSize = True
        Me.titleLB.Location = New System.Drawing.Point(18, 14)
        Me.titleLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.titleLB.Name = "titleLB"
        Me.titleLB.Size = New System.Drawing.Size(83, 20)
        Me.titleLB.TabIndex = 2
        Me.titleLB.Text = "Movie Title"
        '
        'titleTB
        '
        Me.titleTB.Location = New System.Drawing.Point(22, 38)
        Me.titleTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.titleTB.Name = "titleTB"
        Me.titleTB.Size = New System.Drawing.Size(540, 26)
        Me.titleTB.TabIndex = 3
        '
        'yearTB
        '
        Me.yearTB.Location = New System.Drawing.Point(856, 38)
        Me.yearTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.yearTB.MaxLength = 4
        Me.yearTB.Name = "yearTB"
        Me.yearTB.Size = New System.Drawing.Size(100, 26)
        Me.yearTB.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(852, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Release Year"
        '
        'GenreBox
        '
        Me.GenreBox.FormattingEnabled = True
        Me.GenreBox.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "Film-Noir", "Historic", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western"})
        Me.GenreBox.Location = New System.Drawing.Point(573, 38)
        Me.GenreBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenreBox.Name = "GenreBox"
        Me.GenreBox.Size = New System.Drawing.Size(272, 28)
        Me.GenreBox.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(568, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Genre"
        '
        'imdbIDBox
        '
        Me.imdbIDBox.Location = New System.Drawing.Point(735, 100)
        Me.imdbIDBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imdbIDBox.Name = "imdbIDBox"
        Me.imdbIDBox.ReadOnly = True
        Me.imdbIDBox.Size = New System.Drawing.Size(222, 26)
        Me.imdbIDBox.TabIndex = 21
        '
        'imdbBTN
        '
        Me.imdbBTN.Location = New System.Drawing.Point(598, 97)
        Me.imdbBTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imdbBTN.Name = "imdbBTN"
        Me.imdbBTN.Size = New System.Drawing.Size(128, 35)
        Me.imdbBTN.TabIndex = 20
        Me.imdbBTN.Text = "Get IMDB ID"
        Me.imdbBTN.UseVisualStyleBackColor = True
        '
        'seriesTitleTB
        '
        Me.seriesTitleTB.Location = New System.Drawing.Point(22, 103)
        Me.seriesTitleTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.seriesTitleTB.Name = "seriesTitleTB"
        Me.seriesTitleTB.Size = New System.Drawing.Size(284, 26)
        Me.seriesTitleTB.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Series Title"
        '
        'addBTN
        '
        Me.addBTN.Location = New System.Drawing.Point(464, 100)
        Me.addBTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(34, 32)
        Me.addBTN.TabIndex = 17
        Me.addBTN.Text = "+"
        Me.addBTN.UseVisualStyleBackColor = True
        '
        'subtractBTN
        '
        Me.subtractBTN.Location = New System.Drawing.Point(418, 102)
        Me.subtractBTN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subtractBTN.Name = "subtractBTN"
        Me.subtractBTN.Size = New System.Drawing.Size(36, 31)
        Me.subtractBTN.TabIndex = 16
        Me.subtractBTN.Text = "-"
        Me.subtractBTN.UseVisualStyleBackColor = True
        '
        'seriesIterationTB
        '
        Me.seriesIterationTB.Location = New System.Drawing.Point(322, 102)
        Me.seriesIterationTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.seriesIterationTB.MaxLength = 2
        Me.seriesIterationTB.Name = "seriesIterationTB"
        Me.seriesIterationTB.ReadOnly = True
        Me.seriesIterationTB.Size = New System.Drawing.Size(85, 26)
        Me.seriesIterationTB.TabIndex = 15
        Me.seriesIterationTB.Text = "1"
        Me.seriesIterationTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.IMDBPlot)
        Me.Panel1.Controls.Add(Me.IMDBinfo)
        Me.Panel1.Controls.Add(Me.IMDBTitle)
        Me.Panel1.Controls.Add(Me.IMDBpic)
        Me.Panel1.Location = New System.Drawing.Point(20, 214)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 317)
        Me.Panel1.TabIndex = 22
        '
        'IMDBinfo
        '
        Me.IMDBinfo.AutoSize = True
        Me.IMDBinfo.Location = New System.Drawing.Point(282, 43)
        Me.IMDBinfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IMDBinfo.Name = "IMDBinfo"
        Me.IMDBinfo.Size = New System.Drawing.Size(57, 20)
        Me.IMDBinfo.TabIndex = 2
        Me.IMDBinfo.Text = "Label2"
        '
        'IMDBTitle
        '
        Me.IMDBTitle.AutoSize = True
        Me.IMDBTitle.Location = New System.Drawing.Point(282, 23)
        Me.IMDBTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IMDBTitle.Name = "IMDBTitle"
        Me.IMDBTitle.Size = New System.Drawing.Size(57, 20)
        Me.IMDBTitle.TabIndex = 1
        Me.IMDBTitle.Text = "Label1"
        '
        'IMDBpic
        '
        Me.IMDBpic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IMDBpic.Location = New System.Drawing.Point(20, 18)
        Me.IMDBpic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IMDBpic.Name = "IMDBpic"
        Me.IMDBpic.Size = New System.Drawing.Size(254, 275)
        Me.IMDBpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMDBpic.TabIndex = 0
        Me.IMDBpic.TabStop = False
        '
        'addBTN2
        '
        Me.addBTN2.Location = New System.Drawing.Point(162, 172)
        Me.addBTN2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addBTN2.Name = "addBTN2"
        Me.addBTN2.Size = New System.Drawing.Size(34, 32)
        Me.addBTN2.TabIndex = 25
        Me.addBTN2.Text = "+"
        Me.addBTN2.UseVisualStyleBackColor = True
        '
        'subtractBTN2
        '
        Me.subtractBTN2.Location = New System.Drawing.Point(117, 174)
        Me.subtractBTN2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subtractBTN2.Name = "subtractBTN2"
        Me.subtractBTN2.Size = New System.Drawing.Size(36, 31)
        Me.subtractBTN2.TabIndex = 24
        Me.subtractBTN2.Text = "-"
        Me.subtractBTN2.UseVisualStyleBackColor = True
        '
        'PlayCountBox
        '
        Me.PlayCountBox.Location = New System.Drawing.Point(21, 174)
        Me.PlayCountBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PlayCountBox.MaxLength = 3
        Me.PlayCountBox.Name = "PlayCountBox"
        Me.PlayCountBox.ReadOnly = True
        Me.PlayCountBox.Size = New System.Drawing.Size(85, 26)
        Me.PlayCountBox.TabIndex = 23
        Me.PlayCountBox.Text = "0"
        Me.PlayCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Series Iteration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Number Of Plays"
        '
        'hourBox
        '
        Me.hourBox.FormattingEnabled = True
        Me.hourBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.hourBox.Location = New System.Drawing.Point(416, 172)
        Me.hourBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hourBox.Name = "hourBox"
        Me.hourBox.Size = New System.Drawing.Size(42, 28)
        Me.hourBox.TabIndex = 28
        Me.hourBox.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Current Play Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(414, 148)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Hour"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Minute"
        '
        'minBox
        '
        Me.minBox.FormattingEnabled = True
        Me.minBox.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.minBox.Location = New System.Drawing.Point(470, 172)
        Me.minBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.minBox.Name = "minBox"
        Me.minBox.Size = New System.Drawing.Size(55, 28)
        Me.minBox.TabIndex = 31
        Me.minBox.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(536, 149)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Second"
        '
        'secBox
        '
        Me.secBox.FormattingEnabled = True
        Me.secBox.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.secBox.Location = New System.Drawing.Point(536, 172)
        Me.secBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.secBox.Name = "secBox"
        Me.secBox.Size = New System.Drawing.Size(55, 28)
        Me.secBox.TabIndex = 33
        Me.secBox.Text = "00"
        '
        'Timer1
        '
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoEllipsis = True
        Me.LocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LocationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LocationLabel.Location = New System.Drawing.Point(180, 540)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(562, 45)
        Me.LocationLabel.TabIndex = 35
        Me.LocationLabel.Text = "null"
        '
        'ChangeFile
        '
        Me.ChangeFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeFile.Location = New System.Drawing.Point(20, 545)
        Me.ChangeFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChangeFile.Name = "ChangeFile"
        Me.ChangeFile.Size = New System.Drawing.Size(153, 35)
        Me.ChangeFile.TabIndex = 36
        Me.ChangeFile.Text = "Update Location"
        Me.ChangeFile.UseVisualStyleBackColor = True
        '
        'directoryUpdater
        '
        Me.directoryUpdater.Filter = "MP4 Files|*.mp4|MKV Files|*.mkv|MOV Files|*.mov"
        Me.directoryUpdater.InitialDirectory = "Environment.SpecialFolder.Desktop"
        '
        'IMDBPlot
        '
        Me.IMDBPlot.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IMDBPlot.Location = New System.Drawing.Point(285, 66)
        Me.IMDBPlot.Multiline = True
        Me.IMDBPlot.Name = "IMDBPlot"
        Me.IMDBPlot.ReadOnly = True
        Me.IMDBPlot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.IMDBPlot.ShortcutsEnabled = False
        Me.IMDBPlot.Size = New System.Drawing.Size(645, 227)
        Me.IMDBPlot.TabIndex = 4
        '
        'UpdateData
        '
        Me.AcceptButton = Me.UpdateBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancleBTN
        Me.ClientSize = New System.Drawing.Size(969, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.ChangeFile)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.secBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.minBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.hourBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addBTN2)
        Me.Controls.Add(Me.subtractBTN2)
        Me.Controls.Add(Me.PlayCountBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imdbIDBox)
        Me.Controls.Add(Me.imdbBTN)
        Me.Controls.Add(Me.seriesTitleTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.addBTN)
        Me.Controls.Add(Me.subtractBTN)
        Me.Controls.Add(Me.seriesIterationTB)
        Me.Controls.Add(Me.GenreBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.yearTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.titleTB)
        Me.Controls.Add(Me.titleLB)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.CancleBTN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "UpdateData"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateData"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IMDBpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancleBTN As System.Windows.Forms.Button
    Friend WithEvents UpdateBTN As System.Windows.Forms.Button
    Friend WithEvents titleLB As System.Windows.Forms.Label
    Friend WithEvents titleTB As System.Windows.Forms.TextBox
    Friend WithEvents yearTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GenreBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents imdbIDBox As System.Windows.Forms.TextBox
    Friend WithEvents imdbBTN As System.Windows.Forms.Button
    Friend WithEvents seriesTitleTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents addBTN As System.Windows.Forms.Button
    Friend WithEvents subtractBTN As System.Windows.Forms.Button
    Friend WithEvents seriesIterationTB As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IMDBinfo As System.Windows.Forms.Label
    Friend WithEvents IMDBTitle As System.Windows.Forms.Label
    Friend WithEvents IMDBpic As System.Windows.Forms.PictureBox
    Friend WithEvents addBTN2 As System.Windows.Forms.Button
    Friend WithEvents subtractBTN2 As System.Windows.Forms.Button
    Friend WithEvents PlayCountBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hourBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents minBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents secBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeFile As System.Windows.Forms.Button
    Friend WithEvents directoryUpdater As System.Windows.Forms.OpenFileDialog
    Friend WithEvents IMDBPlot As System.Windows.Forms.TextBox
End Class
