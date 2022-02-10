<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelGeneral))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StartupGroupBox = New System.Windows.Forms.GroupBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.HomepageGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.StartupImage = New System.Windows.Forms.PictureBox()
        Me.HomepageImage = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StartupGroupBox.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.HomepageGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.StartupImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomepageImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.StartupGroupBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Servers"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'StartupGroupBox
        '
        Me.StartupGroupBox.Controls.Add(Me.PortTextBox)
        Me.StartupGroupBox.Controls.Add(Me.IPTextBox)
        Me.StartupGroupBox.Controls.Add(Me.Button1)
        Me.StartupGroupBox.Controls.Add(Me.Label1)
        Me.StartupGroupBox.Controls.Add(Me.StartupImage)
        Me.StartupGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.StartupGroupBox.Name = "StartupGroupBox"
        Me.StartupGroupBox.Size = New System.Drawing.Size(397, 79)
        Me.StartupGroupBox.TabIndex = 3
        Me.StartupGroupBox.TabStop = False
        Me.StartupGroupBox.Text = "Servers"
        '
        'PortTextBox
        '
        Me.PortTextBox.Location = New System.Drawing.Point(225, 50)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(85, 22)
        Me.PortTextBox.TabIndex = 10
        Me.PortTextBox.Text = "1985"
        '
        'IPTextBox
        '
        Me.IPTextBox.Location = New System.Drawing.Point(44, 50)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(175, 22)
        Me.IPTextBox.TabIndex = 9
        Me.IPTextBox.Text = "127.0.0.1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Connect to a server of your choosing. Servers use Internet Protocol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "addresses on" & _
            "ly."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.HomepageGroupBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Name"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'HomepageGroupBox
        '
        Me.HomepageGroupBox.Controls.Add(Me.Label2)
        Me.HomepageGroupBox.Controls.Add(Me.HomepageImage)
        Me.HomepageGroupBox.Controls.Add(Me.UserNameTextBox)
        Me.HomepageGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.HomepageGroupBox.Name = "HomepageGroupBox"
        Me.HomepageGroupBox.Size = New System.Drawing.Size(397, 62)
        Me.HomepageGroupBox.TabIndex = 1
        Me.HomepageGroupBox.TabStop = False
        Me.HomepageGroupBox.Text = "Homepage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Set what your user name will be when joining a server."
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(44, 34)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(347, 22)
        Me.UserNameTextBox.TabIndex = 0
        Me.UserNameTextBox.Text = "Default"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 11
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(254, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change General settings..."
        '
        'StartupImage
        '
        Me.StartupImage.Image = Global.HARMONY.My.Resources.Resources.ssInternet
        Me.StartupImage.Location = New System.Drawing.Point(6, 21)
        Me.StartupImage.Name = "StartupImage"
        Me.StartupImage.Size = New System.Drawing.Size(32, 32)
        Me.StartupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StartupImage.TabIndex = 3
        Me.StartupImage.TabStop = False
        '
        'HomepageImage
        '
        Me.HomepageImage.Image = Global.HARMONY.My.Resources.Resources.ssScammer
        Me.HomepageImage.Location = New System.Drawing.Point(6, 21)
        Me.HomepageImage.Name = "HomepageImage"
        Me.HomepageImage.Size = New System.Drawing.Size(32, 32)
        Me.HomepageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.HomepageImage.TabIndex = 1
        Me.HomepageImage.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.HARMONY.My.Resources.Resources.ssNavigateBack
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SettingsPanelGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsPanelGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > General"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.StartupGroupBox.ResumeLayout(False)
        Me.StartupGroupBox.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.HomepageGroupBox.ResumeLayout(False)
        Me.HomepageGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StartupImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomepageImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents StartupGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartupImage As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents HomepageGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HomepageImage As System.Windows.Forms.PictureBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
