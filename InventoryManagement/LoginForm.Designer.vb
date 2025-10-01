<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PinCode = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Entr = New System.Windows.Forms.Button()
        Me.ChngPin = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ExitBtn.Location = New System.Drawing.Point(343, -4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(31, 34)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mini Grocery Inventory Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter The Admin Pin Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PinCode
        '
        Me.PinCode.BackColor = System.Drawing.SystemColors.Info
        Me.PinCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PinCode.Location = New System.Drawing.Point(101, 99)
        Me.PinCode.Multiline = True
        Me.PinCode.Name = "PinCode"
        Me.PinCode.Size = New System.Drawing.Size(188, 42)
        Me.PinCode.TabIndex = 3
        Me.PinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Entr
        '
        Me.Entr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entr.Location = New System.Drawing.Point(148, 147)
        Me.Entr.Name = "Entr"
        Me.Entr.Size = New System.Drawing.Size(89, 33)
        Me.Entr.TabIndex = 5
        Me.Entr.Text = "Enter Code"
        Me.Entr.UseVisualStyleBackColor = True
        '
        'ChngPin
        '
        Me.ChngPin.AutoSize = True
        Me.ChngPin.Location = New System.Drawing.Point(147, 183)
        Me.ChngPin.Name = "ChngPin"
        Me.ChngPin.Size = New System.Drawing.Size(90, 13)
        Me.ChngPin.TabIndex = 6
        Me.ChngPin.TabStop = True
        Me.ChngPin.Text = "Change Pin Code"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(374, 205)
        Me.Controls.Add(Me.ChngPin)
        Me.Controls.Add(Me.Entr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PinCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PinCode As TextBox
    Friend WithEvents Entr As Button
    Friend WithEvents ChngPin As LinkLabel
End Class
