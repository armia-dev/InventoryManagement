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
        Me.EmojiLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.InventoryBtn = New System.Windows.Forms.Button()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SalesReportBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TitleLabel.Location = New System.Drawing.Point(92, 21)
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
        Me.SubtitleLabel.Location = New System.Drawing.Point(93, 54)
        Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(154, 19)
        Me.SubtitleLabel.TabIndex = 4
        Me.SubtitleLabel.Text = "Inventory Management"
        '
        'InventoryBtn
        '
        Me.InventoryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.InventoryBtn.FlatAppearance.BorderSize = 0
        Me.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InventoryBtn.ForeColor = System.Drawing.Color.Black
        Me.InventoryBtn.Location = New System.Drawing.Point(2, 2)
        Me.InventoryBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.InventoryBtn.Name = "InventoryBtn"
        Me.InventoryBtn.Size = New System.Drawing.Size(244, 120)
        Me.InventoryBtn.TabIndex = 3
        Me.InventoryBtn.Text = "📦 Inventory"
        Me.InventoryBtn.UseVisualStyleBackColor = False
        '
        'SalesBtn
        '
        Me.SalesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SalesBtn.FlatAppearance.BorderSize = 0
        Me.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesBtn.ForeColor = System.Drawing.Color.Black
        Me.SalesBtn.Location = New System.Drawing.Point(2, 126)
        Me.SalesBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(244, 120)
        Me.SalesBtn.TabIndex = 2
        Me.SalesBtn.Text = "🛒 Checkout"
        Me.SalesBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 519)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 374)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SalesReportBtn, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.InventoryBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SalesBtn, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(248, 374)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LogoutBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 463)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 56)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogoutBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.LogoutBtn.Location = New System.Drawing.Point(2, 2)
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(244, 51)
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
        Me.Panel3.Size = New System.Drawing.Size(248, 89)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(248, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1032, 59)
        Me.Panel4.TabIndex = 9
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(3, 3)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1026, 454)
        Me.panelMain.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelMain, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(248, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1032, 460)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'SalesReportBtn
        '
        Me.SalesReportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SalesReportBtn.FlatAppearance.BorderSize = 0
        Me.SalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesReportBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesReportBtn.ForeColor = System.Drawing.Color.Black
        Me.SalesReportBtn.Location = New System.Drawing.Point(2, 250)
        Me.SalesReportBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SalesReportBtn.Name = "SalesReportBtn"
        Me.SalesReportBtn.Size = New System.Drawing.Size(244, 122)
        Me.SalesReportBtn.TabIndex = 1
        Me.SalesReportBtn.Text = "📜 Transanction History"
        Me.SalesReportBtn.UseVisualStyleBackColor = False
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 519)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmojiLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SalesReportBtn As Button
End Class
