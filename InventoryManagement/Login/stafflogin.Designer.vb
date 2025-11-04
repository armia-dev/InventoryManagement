<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffLogin))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.EmojiLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StaffMenuForm = New System.Windows.Forms.Label()
        Me.PinPanel = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PinCode = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lnkChangePin = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkSwitchAdmin = New System.Windows.Forms.LinkLabel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PinPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TitleLabel)
        Me.Panel3.Controls.Add(Me.SubtitleLabel)
        Me.Panel3.Controls.Add(Me.EmojiLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 372)
        Me.Panel3.TabIndex = 6
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(101, 141)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(148, 30)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "Mini Grocery"
        '
        'SubtitleLabel
        '
        Me.SubtitleLabel.AutoSize = True
        Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SubtitleLabel.ForeColor = System.Drawing.Color.Gray
        Me.SubtitleLabel.Location = New System.Drawing.Point(102, 174)
        Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(154, 19)
        Me.SubtitleLabel.TabIndex = 4
        Me.SubtitleLabel.Text = "Inventory Management"
        '
        'EmojiLabel
        '
        Me.EmojiLabel.AutoSize = True
        Me.EmojiLabel.Font = New System.Drawing.Font("Segoe UI Emoji", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmojiLabel.Location = New System.Drawing.Point(-7, 131)
        Me.EmojiLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmojiLabel.Name = "EmojiLabel"
        Me.EmojiLabel.Size = New System.Drawing.Size(104, 72)
        Me.EmojiLabel.TabIndex = 6
        Me.EmojiLabel.Text = "📦"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(267, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 46)
        Me.Panel1.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, -3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(54, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StaffMenuForm
        '
        Me.StaffMenuForm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StaffMenuForm.Location = New System.Drawing.Point(338, 115)
        Me.StaffMenuForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StaffMenuForm.Name = "StaffMenuForm"
        Me.StaffMenuForm.Size = New System.Drawing.Size(223, 20)
        Me.StaffMenuForm.TabIndex = 9
        Me.StaffMenuForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PinPanel
        '
        Me.PinPanel.BackColor = System.Drawing.Color.White
        Me.PinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PinPanel.Controls.Add(Me.txtPassword)
        Me.PinPanel.Controls.Add(Me.PictureBox1)
        Me.PinPanel.Controls.Add(Me.PinCode)
        Me.PinPanel.Location = New System.Drawing.Point(354, 211)
        Me.PinPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.PinPanel.Name = "PinPanel"
        Me.PinPanel.Size = New System.Drawing.Size(189, 35)
        Me.PinPanel.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(46, 8)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(103, 22)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PinCode
        '
        Me.PinCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PinCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PinCode.Location = New System.Drawing.Point(46, 8)
        Me.PinCode.Margin = New System.Windows.Forms.Padding(2)
        Me.PinCode.Name = "PinCode"
        Me.PinCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PinCode.Size = New System.Drawing.Size(103, 22)
        Me.PinCode.TabIndex = 1
        Me.PinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(402, 261)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(94, 30)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lnkChangePin
        '
        Me.lnkChangePin.AutoSize = True
        Me.lnkChangePin.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkChangePin.LinkColor = System.Drawing.Color.SteelBlue
        Me.lnkChangePin.Location = New System.Drawing.Point(405, 293)
        Me.lnkChangePin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkChangePin.Name = "lnkChangePin"
        Me.lnkChangePin.Size = New System.Drawing.Size(88, 13)
        Me.lnkChangePin.TabIndex = 12
        Me.lnkChangePin.TabStop = True
        Me.lnkChangePin.Text = "Change Pin Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(383, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Staff Access"
        '
        'LabelInfo
        '
        Me.LabelInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.Location = New System.Drawing.Point(335, 123)
        Me.LabelInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(121, 20)
        Me.LabelInfo.TabIndex = 14
        Me.LabelInfo.Text = "Username: "
        Me.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Location = New System.Drawing.Point(354, 145)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(189, 35)
        Me.Panel2.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.Location = New System.Drawing.Point(38, 8)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(147, 22)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 189)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Password: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkSwitchAdmin
        '
        Me.lnkSwitchAdmin.AutoSize = True
        Me.lnkSwitchAdmin.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSwitchAdmin.LinkColor = System.Drawing.Color.SteelBlue
        Me.lnkSwitchAdmin.Location = New System.Drawing.Point(552, 350)
        Me.lnkSwitchAdmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkSwitchAdmin.Name = "lnkSwitchAdmin"
        Me.lnkSwitchAdmin.Size = New System.Drawing.Size(85, 13)
        Me.lnkSwitchAdmin.TabIndex = 8
        Me.lnkSwitchAdmin.TabStop = True
        Me.lnkSwitchAdmin.Text = "Switch to Admin"
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 372)
        Me.Controls.Add(Me.lnkSwitchAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lnkChangePin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PinPanel)
        Me.Controls.Add(Me.StaffMenuForm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(354, 145)
        Me.Name = "StaffLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stafflogin"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PinPanel.ResumeLayout(False)
        Me.PinPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents EmojiLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StaffMenuForm As Label
    Friend WithEvents PinPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PinCode As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnkChangePin As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkSwitchAdmin As LinkLabel
    Friend WithEvents btnExit As Button
End Class
