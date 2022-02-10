<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.MoreButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VerInfo = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppPic = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoreButton
        '
        Me.MoreButton.BackColor = System.Drawing.Color.DarkMagenta
        Me.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MoreButton.ForeColor = System.Drawing.Color.White
        Me.MoreButton.Location = New System.Drawing.Point(249, 337)
        Me.MoreButton.Name = "MoreButton"
        Me.MoreButton.Size = New System.Drawing.Size(75, 23)
        Me.MoreButton.TabIndex = 1
        Me.MoreButton.Text = "More..."
        Me.MoreButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AppPic)
        Me.GroupBox1.Controls.Add(Me.VerInfo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 272)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legal Information"
        '
        'VerInfo
        '
        Me.VerInfo.AutoSize = True
        Me.VerInfo.BackColor = System.Drawing.Color.Transparent
        Me.VerInfo.ForeColor = System.Drawing.Color.White
        Me.VerInfo.Location = New System.Drawing.Point(44, 21)
        Me.VerInfo.Name = "VerInfo"
        Me.VerInfo.Size = New System.Drawing.Size(289, 234)
        Me.VerInfo.TabIndex = 1
        Me.VerInfo.Text = resources.GetString("VerInfo.Text")
        Me.VerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.DarkMagenta
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(330, 337)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 53)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Harmony"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AppPic
        '
        Me.AppPic.Image = Global.HARMONY.My.Resources.Resources.ssMessages
        Me.AppPic.Location = New System.Drawing.Point(6, 21)
        Me.AppPic.Name = "AppPic"
        Me.AppPic.Size = New System.Drawing.Size(32, 32)
        Me.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AppPic.TabIndex = 1
        Me.AppPic.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HARMONY.My.Resources.Resources.ssMessages
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'About
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(417, 372)
        Me.Controls.Add(Me.MoreButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Harmony"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MoreButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AppPic As System.Windows.Forms.PictureBox
    Friend WithEvents VerInfo As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
