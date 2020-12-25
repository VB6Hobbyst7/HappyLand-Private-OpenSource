<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FileReplace_btn = New System.Windows.Forms.Button()
        Me.log = New System.Windows.Forms.ListBox()
        Me.StartRO_btn = New System.Windows.Forms.Button()
        Me.Verify_btn = New System.Windows.Forms.Button()
        Me.Clear_btn = New System.Windows.Forms.Button()
        Me.Reset_btn = New System.Windows.Forms.Button()
        Me.Hydra_picture = New System.Windows.Forms.PictureBox()
        Me.name_lbl = New System.Windows.Forms.Label()
        Me.progbar = New System.Windows.Forms.ProgressBar()
        CType(Me.Hydra_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileReplace_btn
        '
        Me.FileReplace_btn.Image = CType(resources.GetObject("FileReplace_btn.Image"), System.Drawing.Image)
        Me.FileReplace_btn.Location = New System.Drawing.Point(12, 17)
        Me.FileReplace_btn.Name = "FileReplace_btn"
        Me.FileReplace_btn.Size = New System.Drawing.Size(163, 60)
        Me.FileReplace_btn.TabIndex = 0
        Me.FileReplace_btn.Text = "   File Replace"
        Me.FileReplace_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FileReplace_btn.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.FormattingEnabled = True
        Me.log.Location = New System.Drawing.Point(12, 167)
        Me.log.Name = "log"
        Me.log.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.log.Size = New System.Drawing.Size(328, 160)
        Me.log.TabIndex = 2
        '
        'StartRO_btn
        '
        Me.StartRO_btn.Image = CType(resources.GetObject("StartRO_btn.Image"), System.Drawing.Image)
        Me.StartRO_btn.Location = New System.Drawing.Point(12, 83)
        Me.StartRO_btn.Name = "StartRO_btn"
        Me.StartRO_btn.Size = New System.Drawing.Size(163, 60)
        Me.StartRO_btn.TabIndex = 3
        Me.StartRO_btn.Text = "    Start RO"
        Me.StartRO_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.StartRO_btn.UseVisualStyleBackColor = True
        '
        'Verify_btn
        '
        Me.Verify_btn.Image = CType(resources.GetObject("Verify_btn.Image"), System.Drawing.Image)
        Me.Verify_btn.Location = New System.Drawing.Point(177, 17)
        Me.Verify_btn.Name = "Verify_btn"
        Me.Verify_btn.Size = New System.Drawing.Size(163, 60)
        Me.Verify_btn.TabIndex = 4
        Me.Verify_btn.Text = "  Verify File"
        Me.Verify_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Verify_btn.UseVisualStyleBackColor = True
        '
        'Clear_btn
        '
        Me.Clear_btn.Location = New System.Drawing.Point(265, 337)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.Clear_btn.TabIndex = 7
        Me.Clear_btn.Text = "Clear"
        Me.Clear_btn.UseVisualStyleBackColor = True
        '
        'Reset_btn
        '
        Me.Reset_btn.Image = CType(resources.GetObject("Reset_btn.Image"), System.Drawing.Image)
        Me.Reset_btn.Location = New System.Drawing.Point(177, 83)
        Me.Reset_btn.Name = "Reset_btn"
        Me.Reset_btn.Size = New System.Drawing.Size(163, 60)
        Me.Reset_btn.TabIndex = 8
        Me.Reset_btn.Text = "  Reset"
        Me.Reset_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Reset_btn.UseVisualStyleBackColor = True
        '
        'Hydra_picture
        '
        Me.Hydra_picture.Image = CType(resources.GetObject("Hydra_picture.Image"), System.Drawing.Image)
        Me.Hydra_picture.Location = New System.Drawing.Point(12, 333)
        Me.Hydra_picture.Name = "Hydra_picture"
        Me.Hydra_picture.Size = New System.Drawing.Size(30, 30)
        Me.Hydra_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hydra_picture.TabIndex = 9
        Me.Hydra_picture.TabStop = False
        '
        'name_lbl
        '
        Me.name_lbl.AutoSize = True
        Me.name_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.name_lbl.Location = New System.Drawing.Point(48, 337)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(99, 20)
        Me.name_lbl.TabIndex = 11
        Me.name_lbl.Text = "OpenSource"
        '
        'progbar
        '
        Me.progbar.Location = New System.Drawing.Point(12, 149)
        Me.progbar.Name = "progbar"
        Me.progbar.Size = New System.Drawing.Size(328, 12)
        Me.progbar.TabIndex = 12
        Me.progbar.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 372)
        Me.Controls.Add(Me.progbar)
        Me.Controls.Add(Me.name_lbl)
        Me.Controls.Add(Me.Hydra_picture)
        Me.Controls.Add(Me.Reset_btn)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.Verify_btn)
        Me.Controls.Add(Me.StartRO_btn)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.FileReplace_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แฮปปี้แลนด์ [Private]"
        CType(Me.Hydra_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileReplace_btn As Button
    Friend WithEvents log As ListBox
    Friend WithEvents StartRO_btn As Button
    Friend WithEvents Verify_btn As Button
    Friend WithEvents Clear_btn As Button
    Friend WithEvents Reset_btn As Button
    Friend WithEvents Hydra_picture As PictureBox
    Friend WithEvents name_lbl As Label
    Friend WithEvents progbar As ProgressBar
End Class
