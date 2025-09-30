<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        Me.ReportsBtn = New System.Windows.Forms.Button()
        Me.InventoryBtn = New System.Windows.Forms.Button()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportsBtn
        '
        Me.ReportsBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.ReportsBtn.FlatAppearance.BorderSize = 2
        Me.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportsBtn.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportsBtn.Image = CType(resources.GetObject("ReportsBtn.Image"), System.Drawing.Image)
        Me.ReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportsBtn.Location = New System.Drawing.Point(243, 191)
        Me.ReportsBtn.Name = "ReportsBtn"
        Me.ReportsBtn.Size = New System.Drawing.Size(209, 48)
        Me.ReportsBtn.TabIndex = 9
        Me.ReportsBtn.Text = "     Sales Report"
        Me.ReportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportsBtn.UseVisualStyleBackColor = True
        '
        'InventoryBtn
        '
        Me.InventoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.InventoryBtn.FlatAppearance.BorderSize = 2
        Me.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryBtn.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InventoryBtn.Image = CType(resources.GetObject("InventoryBtn.Image"), System.Drawing.Image)
        Me.InventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InventoryBtn.Location = New System.Drawing.Point(134, 137)
        Me.InventoryBtn.Name = "InventoryBtn"
        Me.InventoryBtn.Size = New System.Drawing.Size(209, 48)
        Me.InventoryBtn.TabIndex = 8
        Me.InventoryBtn.Text = "        Inventory"
        Me.InventoryBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.InventoryBtn.UseVisualStyleBackColor = True
        '
        'SalesBtn
        '
        Me.SalesBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.SalesBtn.FlatAppearance.BorderSize = 2
        Me.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesBtn.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SalesBtn.Image = CType(resources.GetObject("SalesBtn.Image"), System.Drawing.Image)
        Me.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalesBtn.Location = New System.Drawing.Point(23, 191)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(214, 48)
        Me.SalesBtn.TabIndex = 7
        Me.SalesBtn.Text = "               Sales"
        Me.SalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalesBtn.UseVisualStyleBackColor = True
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), System.Drawing.Image)
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LogoutBtn.Location = New System.Drawing.Point(302, 0)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(163, 44)
        Me.LogoutBtn.TabIndex = 10
        Me.LogoutBtn.Text = "    Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inventory Management"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mini Grocery "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(434, -4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 108)
        Me.Panel2.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.LogoutBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 44)
        Me.Panel1.TabIndex = 11
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(464, 324)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportsBtn)
        Me.Controls.Add(Me.SalesBtn)
        Me.Controls.Add(Me.InventoryBtn)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalesBtn As Button
    Friend WithEvents ReportsBtn As Button
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
