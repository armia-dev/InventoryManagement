<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.PinPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PinCode = New System.Windows.Forms.TextBox()
        Me.Entr = New System.Windows.Forms.Button()
        Me.ChngPin = New System.Windows.Forms.LinkLabel()
        Me.HeaderPanel.SuspendLayout()
        Me.PinPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.HeaderPanel.Controls.Add(Me.ExitBtn)
        Me.HeaderPanel.Controls.Add(Me.lblTitle)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(434, 43)
        Me.HeaderPanel.TabIndex = 0
        '
        'ExitBtn
        '
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.Location = New System.Drawing.Point(389, 5)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(34, 32)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(11, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(154, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "🔐 Admin Login"
        '
        'LabelInfo
        '
        Me.LabelInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelInfo.Location = New System.Drawing.Point(69, 59)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(297, 25)
        Me.LabelInfo.TabIndex = 1
        Me.LabelInfo.Text = "Enter your administrator pin code"
        Me.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PinPanel
        '
        Me.PinPanel.BackColor = System.Drawing.Color.White
        Me.PinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PinPanel.Controls.Add(Me.PictureBox1)
        Me.PinPanel.Controls.Add(Me.PinCode)
        Me.PinPanel.Location = New System.Drawing.Point(91, 96)
        Me.PinPanel.Name = "PinPanel"
        Me.PinPanel.Size = New System.Drawing.Size(251, 43)
        Me.PinPanel.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PinCode
        '
        Me.PinCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PinCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PinCode.Location = New System.Drawing.Point(62, 10)
        Me.PinCode.Name = "PinCode"
        Me.PinCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PinCode.Size = New System.Drawing.Size(137, 27)
        Me.PinCode.TabIndex = 1
        Me.PinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Entr
        '
        Me.Entr.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Entr.FlatAppearance.BorderSize = 0
        Me.Entr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Entr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Entr.ForeColor = System.Drawing.Color.White
        Me.Entr.Location = New System.Drawing.Point(154, 155)
        Me.Entr.Name = "Entr"
        Me.Entr.Size = New System.Drawing.Size(126, 37)
        Me.Entr.TabIndex = 3
        Me.Entr.Text = "Login"
        Me.Entr.UseVisualStyleBackColor = False
        '
        'ChngPin
        '
        Me.ChngPin.AutoSize = True
        Me.ChngPin.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChngPin.LinkColor = System.Drawing.Color.SteelBlue
        Me.ChngPin.Location = New System.Drawing.Point(163, 207)
        Me.ChngPin.Name = "ChngPin"
        Me.ChngPin.Size = New System.Drawing.Size(103, 17)
        Me.ChngPin.TabIndex = 4
        Me.ChngPin.TabStop = True
        Me.ChngPin.Text = "Change Pin Code"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(434, 245)
        Me.Controls.Add(Me.ChngPin)
        Me.Controls.Add(Me.Entr)
        Me.Controls.Add(Me.PinPanel)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.PinPanel.ResumeLayout(False)
        Me.PinPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ExitBtn As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents PinPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PinCode As TextBox
    Friend WithEvents Entr As Button
    Friend WithEvents ChngPin As LinkLabel
End Class
