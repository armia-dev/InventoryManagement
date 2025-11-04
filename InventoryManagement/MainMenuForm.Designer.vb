<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
    Inherits System.Windows.Forms.Form

    'Dispose
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        Me.EmojiLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.InventoryBtn = New System.Windows.Forms.Button()
        Me.Dashboard = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelDescription = New System.Windows.Forms.Panel()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.btnTransac = New System.Windows.Forms.Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel3.SuspendLayout()
        Me.panelDescription.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmojiLabel
        '
        Me.EmojiLabel.AutoSize = True
        Me.EmojiLabel.Font = New System.Drawing.Font("Segoe UI Emoji", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmojiLabel.Location = New System.Drawing.Point(-16, 11)
        Me.EmojiLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmojiLabel.Name = "EmojiLabel"
        Me.EmojiLabel.Size = New System.Drawing.Size(104, 72)
        Me.EmojiLabel.TabIndex = 6
        Me.EmojiLabel.Text = "📦"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(62, 20)
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
        Me.SubtitleLabel.Location = New System.Drawing.Point(63, 53)
        Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(154, 19)
        Me.SubtitleLabel.TabIndex = 4
        Me.SubtitleLabel.Text = "Inventory Management"
        '
        'InventoryBtn
        '
        Me.InventoryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.InventoryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.InventoryBtn.FlatAppearance.BorderSize = 0
        Me.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InventoryBtn.ForeColor = System.Drawing.Color.Black
        Me.InventoryBtn.Location = New System.Drawing.Point(2, 74)
        Me.InventoryBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.InventoryBtn.Name = "InventoryBtn"
        Me.InventoryBtn.Size = New System.Drawing.Size(250, 68)
        Me.InventoryBtn.TabIndex = 3
        Me.InventoryBtn.Text = "📦 Inventory"
        Me.InventoryBtn.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.Dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard.FlatAppearance.BorderSize = 0
        Me.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Dashboard.ForeColor = System.Drawing.Color.Black
        Me.Dashboard.Location = New System.Drawing.Point(2, 2)
        Me.Dashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(250, 68)
        Me.Dashboard.TabIndex = 4
        Me.Dashboard.Text = "📜 Dashboard"
        Me.Dashboard.UseVisualStyleBackColor = False
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogoutBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.LogoutBtn.Location = New System.Drawing.Point(0, 375)
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(233, 55)
        Me.LogoutBtn.TabIndex = 0
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TitleLabel)
        Me.Panel3.Controls.Add(Me.SubtitleLabel)
        Me.Panel3.Controls.Add(Me.EmojiLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 89)
        Me.Panel3.TabIndex = 0
        '
        'panelDescription
        '
        Me.panelDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.panelDescription.Controls.Add(Me.btnMax)
        Me.panelDescription.Controls.Add(Me.btnMin)
        Me.panelDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelDescription.Location = New System.Drawing.Point(233, 0)
        Me.panelDescription.Name = "panelDescription"
        Me.panelDescription.Size = New System.Drawing.Size(1047, 72)
        Me.panelDescription.TabIndex = 9
        '
        'btnMax
        '
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Image = CType(resources.GetObject("btnMax.Image"), System.Drawing.Image)
        Me.btnMax.Location = New System.Drawing.Point(986, 0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(40, 33)
        Me.btnMax.TabIndex = 2
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(940, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(40, 33)
        Me.btnMin.TabIndex = 1
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(3, 3)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1041, 441)
        Me.panelMain.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelMain, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(233, 72)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1047, 447)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 519)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LogoutBtn)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 430)
        Me.Panel1.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Dashboard)
        Me.FlowLayoutPanel1.Controls.Add(Me.InventoryBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.SalesBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTransac)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(233, 430)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'SalesBtn
        '
        Me.SalesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.SalesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SalesBtn.FlatAppearance.BorderSize = 0
        Me.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesBtn.ForeColor = System.Drawing.Color.Black
        Me.SalesBtn.Location = New System.Drawing.Point(2, 146)
        Me.SalesBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(250, 68)
        Me.SalesBtn.TabIndex = 2
        Me.SalesBtn.Text = "🛒 Checkout"
        Me.SalesBtn.UseVisualStyleBackColor = False
        '
        'btnTransac
        '
        Me.btnTransac.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnTransac.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransac.FlatAppearance.BorderSize = 0
        Me.btnTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransac.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransac.ForeColor = System.Drawing.Color.Black
        Me.btnTransac.Location = New System.Drawing.Point(2, 218)
        Me.btnTransac.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransac.Name = "btnTransac"
        Me.btnTransac.Size = New System.Drawing.Size(250, 68)
        Me.btnTransac.TabIndex = 1
        Me.btnTransac.Text = "📜 Transanction History"
        Me.btnTransac.UseVisualStyleBackColor = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.UseTransparentDrag = True
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 519)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panelDescription)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelDescription.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmojiLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelDescription As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents Dashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents SalesBtn As Button
    Friend WithEvents btnTransac As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnMax As Button
    Friend WithEvents btnMin As Button
End Class
