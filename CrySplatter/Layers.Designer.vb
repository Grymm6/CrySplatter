﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Layers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Layers))
        Me.TextBoxFileContent = New System.Windows.Forms.TextBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxFileContent
        '
        Me.TextBoxFileContent.Location = New System.Drawing.Point(13, 12)
        Me.TextBoxFileContent.Multiline = True
        Me.TextBoxFileContent.Name = "TextBoxFileContent"
        Me.TextBoxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxFileContent.Size = New System.Drawing.Size(661, 238)
        Me.TextBoxFileContent.TabIndex = 0
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Location = New System.Drawing.Point(12, 279)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(102, 29)
        Me.ButtonBack.TabIndex = 7
        Me.ButtonBack.Text = "<< Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.CrySplatter.My.Resources.Resources.round_logo300
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(684, 320)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Layers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(684, 320)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.TextBoxFileContent)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Layers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrySplatter - Layers"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxFileContent As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
