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
        Me.btnClientDisconnect = New System.Windows.Forms.Button()
        Me.btnClientConnect = New System.Windows.Forms.Button()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClientIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientPort = New System.Windows.Forms.TextBox()
        Me.txtClientSend = New System.Windows.Forms.TextBox()
        Me.rtbClient = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClientDisconnect
        '
        Me.btnClientDisconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientDisconnect.Enabled = False
        Me.btnClientDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClientDisconnect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClientDisconnect.ForeColor = System.Drawing.Color.Black
        Me.btnClientDisconnect.Location = New System.Drawing.Point(86, 7)
        Me.btnClientDisconnect.Name = "btnClientDisconnect"
        Me.btnClientDisconnect.Size = New System.Drawing.Size(72, 21)
        Me.btnClientDisconnect.TabIndex = 1
        Me.btnClientDisconnect.Text = "Disconnect"
        Me.btnClientDisconnect.UseVisualStyleBackColor = True
        '
        'btnClientConnect
        '
        Me.btnClientConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClientConnect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClientConnect.ForeColor = System.Drawing.Color.Black
        Me.btnClientConnect.Location = New System.Drawing.Point(12, 7)
        Me.btnClientConnect.Name = "btnClientConnect"
        Me.btnClientConnect.Size = New System.Drawing.Size(68, 21)
        Me.btnClientConnect.TabIndex = 0
        Me.btnClientConnect.Text = "Connect"
        Me.btnClientConnect.UseVisualStyleBackColor = True
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(378, 40)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(128, 22)
        Me.txtClientName.TabIndex = 5
        Me.txtClientName.Text = "Default"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(329, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtClientIP
        '
        Me.txtClientIP.Location = New System.Drawing.Point(332, 12)
        Me.txtClientIP.Name = "txtClientIP"
        Me.txtClientIP.Size = New System.Drawing.Size(128, 22)
        Me.txtClientIP.TabIndex = 3
        Me.txtClientIP.Text = "127.0.0.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(225, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address and Port :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtClientPort
        '
        Me.txtClientPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientPort.Location = New System.Drawing.Point(466, 12)
        Me.txtClientPort.Name = "txtClientPort"
        Me.txtClientPort.Size = New System.Drawing.Size(40, 22)
        Me.txtClientPort.TabIndex = 4
        Me.txtClientPort.Text = "1989"
        '
        'txtClientSend
        '
        Me.txtClientSend.Location = New System.Drawing.Point(12, 424)
        Me.txtClientSend.Name = "txtClientSend"
        Me.txtClientSend.Size = New System.Drawing.Size(494, 22)
        Me.txtClientSend.TabIndex = 6
        '
        'rtbClient
        '
        Me.rtbClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbClient.Location = New System.Drawing.Point(12, 68)
        Me.rtbClient.Name = "rtbClient"
        Me.rtbClient.ReadOnly = True
        Me.rtbClient.Size = New System.Drawing.Size(494, 350)
        Me.rtbClient.TabIndex = 7
        Me.rtbClient.TabStop = False
        Me.rtbClient.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(528, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 407)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AboutButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.Black
        Me.AboutButton.Location = New System.Drawing.Point(86, 34)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(72, 21)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SettingsButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.Color.Black
        Me.SettingsButton.Location = New System.Drawing.Point(12, 34)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(68, 21)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(663, 453)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.btnClientDisconnect)
        Me.Controls.Add(Me.btnClientConnect)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClientIP)
        Me.Controls.Add(Me.rtbClient)
        Me.Controls.Add(Me.txtClientSend)
        Me.Controls.Add(Me.txtClientPort)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "BT360 - Chat Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClientDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnClientConnect As System.Windows.Forms.Button
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtClientIP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClientPort As System.Windows.Forms.TextBox
    Friend WithEvents txtClientSend As System.Windows.Forms.TextBox
    Friend WithEvents rtbClient As System.Windows.Forms.RichTextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents SettingsButton As System.Windows.Forms.Button

End Class
