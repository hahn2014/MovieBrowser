<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoPlayer))
        Me.eliteMoviePlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.VolumeAdjuster = New System.Windows.Forms.TrackBar()
        Me.SkipButton = New System.Windows.Forms.Button()
        Me.SkipBackButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.FSButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.moviePosition = New System.Windows.Forms.TrackBar()
        CType(Me.eliteMoviePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeAdjuster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.moviePosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eliteMoviePlayer
        '
        Me.eliteMoviePlayer.Enabled = True
        Me.eliteMoviePlayer.Location = New System.Drawing.Point(0, 0)
        Me.eliteMoviePlayer.Name = "eliteMoviePlayer"
        Me.eliteMoviePlayer.OcxState = CType(resources.GetObject("eliteMoviePlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.eliteMoviePlayer.Size = New System.Drawing.Size(1961, 1229)
        Me.eliteMoviePlayer.TabIndex = 4
        '
        'VolumeAdjuster
        '
        Me.VolumeAdjuster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VolumeAdjuster.LargeChange = 10
        Me.VolumeAdjuster.Location = New System.Drawing.Point(352, 1222)
        Me.VolumeAdjuster.Maximum = 100
        Me.VolumeAdjuster.MaximumSize = New System.Drawing.Size(340, 69)
        Me.VolumeAdjuster.MinimumSize = New System.Drawing.Size(200, 69)
        Me.VolumeAdjuster.Name = "VolumeAdjuster"
        Me.VolumeAdjuster.Size = New System.Drawing.Size(340, 69)
        Me.VolumeAdjuster.SmallChange = 5
        Me.VolumeAdjuster.TabIndex = 5
        Me.VolumeAdjuster.Value = 50
        '
        'SkipButton
        '
        Me.SkipButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkipButton.Location = New System.Drawing.Point(224, 1233)
        Me.SkipButton.Name = "SkipButton"
        Me.SkipButton.Size = New System.Drawing.Size(122, 31)
        Me.SkipButton.TabIndex = 6
        Me.SkipButton.Text = "Skip Forwards"
        Me.SkipButton.UseVisualStyleBackColor = True
        '
        'SkipBackButton
        '
        Me.SkipBackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkipBackButton.Location = New System.Drawing.Point(12, 1233)
        Me.SkipBackButton.Name = "SkipBackButton"
        Me.SkipBackButton.Size = New System.Drawing.Size(131, 31)
        Me.SkipBackButton.TabIndex = 7
        Me.SkipBackButton.Text = "Skip Backwards"
        Me.SkipBackButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlayButton.Location = New System.Drawing.Point(149, 1233)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(69, 31)
        Me.PlayButton.TabIndex = 8
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'FSButton
        '
        Me.FSButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSButton.Location = New System.Drawing.Point(698, 1232)
        Me.FSButton.Name = "FSButton"
        Me.FSButton.Size = New System.Drawing.Size(103, 31)
        Me.FSButton.TabIndex = 9
        Me.FSButton.Text = "Fullscreen"
        Me.FSButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1722, 1237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "0:00:00 of 0:00:00"
        '
        'Timer1
        '
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(1865, 1233)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(84, 31)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'moviePosition
        '
        Me.moviePosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.moviePosition.Location = New System.Drawing.Point(807, 1222)
        Me.moviePosition.Maximum = 10000
        Me.moviePosition.MinimumSize = New System.Drawing.Size(600, 69)
        Me.moviePosition.Name = "moviePosition"
        Me.moviePosition.Size = New System.Drawing.Size(909, 69)
        Me.moviePosition.TabIndex = 12
        '
        'VideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1961, 1267)
        Me.ControlBox = False
        Me.Controls.Add(Me.moviePosition)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FSButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.SkipBackButton)
        Me.Controls.Add(Me.SkipButton)
        Me.Controls.Add(Me.VolumeAdjuster)
        Me.Controls.Add(Me.eliteMoviePlayer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "VideoPlayer"
        Me.Text = "Video Player - unknown movie"
        CType(Me.eliteMoviePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeAdjuster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.moviePosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents eliteMoviePlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents VolumeAdjuster As System.Windows.Forms.TrackBar
    Friend WithEvents SkipButton As System.Windows.Forms.Button
    Friend WithEvents SkipBackButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents FSButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents moviePosition As System.Windows.Forms.TrackBar
End Class
