<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoUpdate))
        Me.Later = New System.Windows.Forms.Button()
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.UpdateText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Later
        '
        Me.Later.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Later.Location = New System.Drawing.Point(12, 265)
        Me.Later.Name = "Later"
        Me.Later.Size = New System.Drawing.Size(154, 34)
        Me.Later.TabIndex = 0
        Me.Later.Text = "Remind Me Later"
        Me.Later.UseVisualStyleBackColor = True
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateBTN.Location = New System.Drawing.Point(482, 265)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(176, 34)
        Me.UpdateBTN.TabIndex = 1
        Me.UpdateBTN.Text = "Update Now!"
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'UpdateText
        '
        Me.UpdateText.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UpdateText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UpdateText.Location = New System.Drawing.Point(13, 13)
        Me.UpdateText.Name = "UpdateText"
        Me.UpdateText.Size = New System.Drawing.Size(645, 240)
        Me.UpdateText.TabIndex = 2
        Me.UpdateText.Text = "Label1"
        '
        'AutoUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.UpdateText)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.Later)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AutoUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "There is an update available"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Later As System.Windows.Forms.Button
    Friend WithEvents UpdateBTN As System.Windows.Forms.Button
    Friend WithEvents UpdateText As System.Windows.Forms.Label
End Class
