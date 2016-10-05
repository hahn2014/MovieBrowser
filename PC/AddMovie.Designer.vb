<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMovie))
        Me.LoadFileBTN = New System.Windows.Forms.Button()
        Me.dirTextField = New System.Windows.Forms.TextBox()
        Me.addMovieBTN = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.directoryUpdater = New System.Windows.Forms.OpenFileDialog()
        Me.detailsPanel = New System.Windows.Forms.Panel()
        Me.imdbIDBox = New System.Windows.Forms.TextBox()
        Me.imdbBTN = New System.Windows.Forms.Button()
        Me.GenreBox = New System.Windows.Forms.ComboBox()
        Me.seriesTitleTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yearTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addBTN = New System.Windows.Forms.Button()
        Me.subtractBTN = New System.Windows.Forms.Button()
        Me.seriesIterationTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titleTB = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FileOnComputerCB = New System.Windows.Forms.CheckBox()
        Me.urlTextFieldLB = New System.Windows.Forms.Label()
        Me.detailsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadFileBTN
        '
        Me.LoadFileBTN.Location = New System.Drawing.Point(125, 12)
        Me.LoadFileBTN.Name = "LoadFileBTN"
        Me.LoadFileBTN.Size = New System.Drawing.Size(105, 23)
        Me.LoadFileBTN.TabIndex = 0
        Me.LoadFileBTN.Text = "Load File"
        Me.LoadFileBTN.UseVisualStyleBackColor = True
        '
        'dirTextField
        '
        Me.dirTextField.Location = New System.Drawing.Point(236, 13)
        Me.dirTextField.Name = "dirTextField"
        Me.dirTextField.Size = New System.Drawing.Size(475, 20)
        Me.dirTextField.TabIndex = 1
        '
        'addMovieBTN
        '
        Me.addMovieBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addMovieBTN.Enabled = False
        Me.addMovieBTN.Location = New System.Drawing.Point(555, 155)
        Me.addMovieBTN.Name = "addMovieBTN"
        Me.addMovieBTN.Size = New System.Drawing.Size(75, 23)
        Me.addMovieBTN.TabIndex = 2
        Me.addMovieBTN.Text = "Add Movie"
        Me.addMovieBTN.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(636, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'directoryUpdater
        '
        Me.directoryUpdater.Filter = "MP4 Files|*.mp4|MKV Files|*.mkv|MOV Files|*.mov"
        Me.directoryUpdater.InitialDirectory = "Environment.SpecialFolder.Desktop"
        '
        'detailsPanel
        '
        Me.detailsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detailsPanel.Controls.Add(Me.imdbIDBox)
        Me.detailsPanel.Controls.Add(Me.imdbBTN)
        Me.detailsPanel.Controls.Add(Me.GenreBox)
        Me.detailsPanel.Controls.Add(Me.seriesTitleTB)
        Me.detailsPanel.Controls.Add(Me.Label5)
        Me.detailsPanel.Controls.Add(Me.yearTB)
        Me.detailsPanel.Controls.Add(Me.Label4)
        Me.detailsPanel.Controls.Add(Me.Label3)
        Me.detailsPanel.Controls.Add(Me.addBTN)
        Me.detailsPanel.Controls.Add(Me.subtractBTN)
        Me.detailsPanel.Controls.Add(Me.seriesIterationTB)
        Me.detailsPanel.Controls.Add(Me.Label2)
        Me.detailsPanel.Controls.Add(Me.Label1)
        Me.detailsPanel.Controls.Add(Me.titleTB)
        Me.detailsPanel.Enabled = False
        Me.detailsPanel.Location = New System.Drawing.Point(13, 43)
        Me.detailsPanel.Name = "detailsPanel"
        Me.detailsPanel.Size = New System.Drawing.Size(698, 106)
        Me.detailsPanel.TabIndex = 4
        '
        'imdbIDBox
        '
        Me.imdbIDBox.Location = New System.Drawing.Point(440, 77)
        Me.imdbIDBox.Name = "imdbIDBox"
        Me.imdbIDBox.ReadOnly = True
        Me.imdbIDBox.Size = New System.Drawing.Size(157, 20)
        Me.imdbIDBox.TabIndex = 14
        '
        'imdbBTN
        '
        Me.imdbBTN.Location = New System.Drawing.Point(349, 75)
        Me.imdbBTN.Name = "imdbBTN"
        Me.imdbBTN.Size = New System.Drawing.Size(85, 23)
        Me.imdbBTN.TabIndex = 13
        Me.imdbBTN.Text = "Get IMDB ID"
        Me.imdbBTN.UseVisualStyleBackColor = True
        '
        'GenreBox
        '
        Me.GenreBox.FormattingEnabled = True
        Me.GenreBox.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "Film-Noir", "Historic", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western"})
        Me.GenreBox.Location = New System.Drawing.Point(430, 26)
        Me.GenreBox.Name = "GenreBox"
        Me.GenreBox.Size = New System.Drawing.Size(183, 21)
        Me.GenreBox.TabIndex = 12
        '
        'seriesTitleTB
        '
        Me.seriesTitleTB.Location = New System.Drawing.Point(3, 78)
        Me.seriesTitleTB.Name = "seriesTitleTB"
        Me.seriesTitleTB.Size = New System.Drawing.Size(191, 20)
        Me.seriesTitleTB.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Series Title"
        '
        'yearTB
        '
        Me.yearTB.Location = New System.Drawing.Point(619, 28)
        Me.yearTB.MaxLength = 4
        Me.yearTB.Name = "yearTB"
        Me.yearTB.Size = New System.Drawing.Size(68, 20)
        Me.yearTB.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(616, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Release Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genre"
        '
        'addBTN
        '
        Me.addBTN.Enabled = False
        Me.addBTN.Location = New System.Drawing.Point(297, 76)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(23, 21)
        Me.addBTN.TabIndex = 5
        Me.addBTN.Text = "+"
        Me.addBTN.UseVisualStyleBackColor = True
        '
        'subtractBTN
        '
        Me.subtractBTN.Enabled = False
        Me.subtractBTN.Location = New System.Drawing.Point(267, 77)
        Me.subtractBTN.Name = "subtractBTN"
        Me.subtractBTN.Size = New System.Drawing.Size(24, 20)
        Me.subtractBTN.TabIndex = 4
        Me.subtractBTN.Text = "-"
        Me.subtractBTN.UseVisualStyleBackColor = True
        '
        'seriesIterationTB
        '
        Me.seriesIterationTB.Enabled = False
        Me.seriesIterationTB.Location = New System.Drawing.Point(203, 77)
        Me.seriesIterationTB.MaxLength = 2
        Me.seriesIterationTB.Name = "seriesIterationTB"
        Me.seriesIterationTB.ReadOnly = True
        Me.seriesIterationTB.Size = New System.Drawing.Size(58, 20)
        Me.seriesIterationTB.TabIndex = 3
        Me.seriesIterationTB.Text = "1"
        Me.seriesIterationTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie Series Iteration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie Title"
        '
        'titleTB
        '
        Me.titleTB.Location = New System.Drawing.Point(4, 28)
        Me.titleTB.Name = "titleTB"
        Me.titleTB.Size = New System.Drawing.Size(420, 20)
        Me.titleTB.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'FileOnComputerCB
        '
        Me.FileOnComputerCB.AutoSize = True
        Me.FileOnComputerCB.BackColor = System.Drawing.Color.Transparent
        Me.FileOnComputerCB.Checked = True
        Me.FileOnComputerCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileOnComputerCB.Location = New System.Drawing.Point(12, 16)
        Me.FileOnComputerCB.Name = "FileOnComputerCB"
        Me.FileOnComputerCB.Size = New System.Drawing.Size(107, 17)
        Me.FileOnComputerCB.TabIndex = 5
        Me.FileOnComputerCB.Text = "File On Computer"
        Me.FileOnComputerCB.UseVisualStyleBackColor = False
        '
        'urlTextFieldLB
        '
        Me.urlTextFieldLB.AutoSize = True
        Me.urlTextFieldLB.Location = New System.Drawing.Point(233, 0)
        Me.urlTextFieldLB.Margin = New System.Windows.Forms.Padding(0)
        Me.urlTextFieldLB.Name = "urlTextFieldLB"
        Me.urlTextFieldLB.Size = New System.Drawing.Size(175, 13)
        Me.urlTextFieldLB.TabIndex = 6
        Me.urlTextFieldLB.Text = "Directory On Local Drive (Required)"
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.urlTextFieldLB)
        Me.Controls.Add(Me.FileOnComputerCB)
        Me.Controls.Add(Me.detailsPanel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.addMovieBTN)
        Me.Controls.Add(Me.dirTextField)
        Me.Controls.Add(Me.LoadFileBTN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(739, 229)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(739, 229)
        Me.Name = "AddMovie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Movie To List"
        Me.TopMost = True
        Me.detailsPanel.ResumeLayout(False)
        Me.detailsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadFileBTN As System.Windows.Forms.Button
    Friend WithEvents dirTextField As System.Windows.Forms.TextBox
    Friend WithEvents addMovieBTN As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents directoryUpdater As System.Windows.Forms.OpenFileDialog
    Friend WithEvents detailsPanel As System.Windows.Forms.Panel
    Friend WithEvents addBTN As System.Windows.Forms.Button
    Friend WithEvents subtractBTN As System.Windows.Forms.Button
    Friend WithEvents seriesIterationTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents titleTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents seriesTitleTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GenreBox As System.Windows.Forms.ComboBox
    Friend WithEvents imdbBTN As System.Windows.Forms.Button
    Friend WithEvents imdbIDBox As System.Windows.Forms.TextBox
    Friend WithEvents FileOnComputerCB As System.Windows.Forms.CheckBox
    Friend WithEvents urlTextFieldLB As System.Windows.Forms.Label
    Friend WithEvents yearTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
