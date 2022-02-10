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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ChatSender = New System.Windows.Forms.TextBox()
        Me.ChatHistory = New System.Windows.Forms.RichTextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.UserListBox = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StopButton
        '
        Me.StopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StopButton.Location = New System.Drawing.Point(92, 58)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 27)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ChatSender
        '
        Me.ChatSender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatSender.Location = New System.Drawing.Point(12, 371)
        Me.ChatSender.Name = "ChatSender"
        Me.ChatSender.Size = New System.Drawing.Size(406, 22)
        Me.ChatSender.TabIndex = 5
        '
        'ChatHistory
        '
        Me.ChatHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatHistory.Location = New System.Drawing.Point(12, 131)
        Me.ChatHistory.Name = "ChatHistory"
        Me.ChatHistory.Size = New System.Drawing.Size(406, 234)
        Me.ChatHistory.TabIndex = 3
        Me.ChatHistory.TabStop = False
        Me.ChatHistory.Text = ""
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StartButton.Location = New System.Drawing.Point(11, 58)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 27)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'PortTextBox
        '
        Me.PortTextBox.Location = New System.Drawing.Point(379, 69)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(44, 22)
        Me.PortTextBox.TabIndex = 4
        Me.PortTextBox.Text = "1989"
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.ForeColor = System.Drawing.Color.White
        Me.PortLabel.Location = New System.Drawing.Point(344, 72)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(31, 13)
        Me.PortLabel.TabIndex = 3
        Me.PortLabel.Text = "Port:"
        Me.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserListBox
        '
        Me.UserListBox.FormattingEnabled = True
        Me.UserListBox.Location = New System.Drawing.Point(436, 77)
        Me.UserListBox.Name = "UserListBox"
        Me.UserListBox.Size = New System.Drawing.Size(136, 316)
        Me.UserListBox.TabIndex = 4
        Me.UserListBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(1040, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 342)
        Me.ListBox2.TabIndex = 3
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AboutButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(254, 58)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 27)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SettingsButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SettingsButton.Location = New System.Drawing.Point(173, 58)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(75, 27)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(580, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartServerToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'StartServerToolStripMenuItem
        '
        Me.StartServerToolStripMenuItem.Name = "StartServerToolStripMenuItem"
        Me.StartServerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartServerToolStripMenuItem.Text = "Start server"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(580, 399)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.ChatSender)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ChatHistory)
        Me.Controls.Add(Me.UserListBox)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "BT360 - Chat Server"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortLabel As System.Windows.Forms.Label
    Friend WithEvents ChatSender As System.Windows.Forms.TextBox
    Friend WithEvents ChatHistory As System.Windows.Forms.RichTextBox
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents UserListBox As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
