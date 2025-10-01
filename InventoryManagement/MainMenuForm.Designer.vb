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
        Me.SalesReportBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EmojiLabel
        '
        Me.EmojiLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmojiLabel.AutoSize = True
        Me.EmojiLabel.Font = New System.Drawing.Font("Segoe UI Emoji", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmojiLabel.Location = New System.Drawing.Point(3, 21)
        Me.EmojiLabel.Name = "EmojiLabel"
        Me.EmojiLabel.Size = New System.Drawing.Size(130, 89)
        Me.EmojiLabel.TabIndex = 6
        Me.EmojiLabel.Text = "📦"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(137, 37)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(184, 37)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "Mini Grocery"
        '
        'SubtitleLabel
        '
        Me.SubtitleLabel.AutoSize = True
        Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SubtitleLabel.ForeColor = System.Drawing.Color.Gray
        Me.SubtitleLabel.Location = New System.Drawing.Point(139, 75)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(189, 23)
        Me.SubtitleLabel.TabIndex = 4
        Me.SubtitleLabel.Text = "Inventory Management"
        '
        'InventoryBtn
        '
        Me.InventoryBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InventoryBtn.ForeColor = System.Drawing.Color.White
        Me.InventoryBtn.Location = New System.Drawing.Point(126, 127)
        Me.InventoryBtn.Name = "InventoryBtn"
        Me.InventoryBtn.Size = New System.Drawing.Size(286, 53)
        Me.InventoryBtn.TabIndex = 3
        Me.InventoryBtn.Text = "📦 Inventory"
        Me.InventoryBtn.UseVisualStyleBackColor = False
        '
        'SalesBtn
        '
        Me.SalesBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesBtn.ForeColor = System.Drawing.Color.White
        Me.SalesBtn.Location = New System.Drawing.Point(126, 200)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(286, 53)
        Me.SalesBtn.TabIndex = 2
        Me.SalesBtn.Text = "🛒 Sales"
        Me.SalesBtn.UseVisualStyleBackColor = False
        '
        'SalesReportBtn
        '
        Me.SalesReportBtn.BackColor = System.Drawing.Color.IndianRed
        Me.SalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesReportBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesReportBtn.ForeColor = System.Drawing.Color.White
        Me.SalesReportBtn.Location = New System.Drawing.Point(126, 276)
        Me.SalesReportBtn.Name = "SalesReportBtn"
        Me.SalesReportBtn.Size = New System.Drawing.Size(286, 53)
        Me.SalesReportBtn.TabIndex = 1
        Me.SalesReportBtn.Text = "📊 Sales Report"
        Me.SalesReportBtn.UseVisualStyleBackColor = False
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogoutBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.LogoutBtn.Location = New System.Drawing.Point(410, 45)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(86, 32)
        Me.LogoutBtn.TabIndex = 0
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(549, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.EmojiLabel)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.SalesReportBtn)
        Me.Controls.Add(Me.SalesBtn)
        Me.Controls.Add(Me.InventoryBtn)
        Me.Controls.Add(Me.SubtitleLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmojiLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents SalesReportBtn As Button
    Friend WithEvents LogoutBtn As Button
End Class
