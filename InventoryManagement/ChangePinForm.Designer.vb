<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePinForm
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.LabelOldPin = New System.Windows.Forms.Label()
        Me.LabelNewPin = New System.Windows.Forms.Label()
        Me.OldPinTxt = New System.Windows.Forms.TextBox()
        Me.NewPinTxt = New System.Windows.Forms.TextBox()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelHeader.Controls.Add(Me.HeaderLabel)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(300, 41)
        Me.PanelHeader.TabIndex = 0
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.HeaderLabel.ForeColor = System.Drawing.Color.White
        Me.HeaderLabel.Location = New System.Drawing.Point(75, 8)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(144, 25)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "🔑 Change PIN"
        '
        'LabelOldPin
        '
        Me.LabelOldPin.AutoSize = True
        Me.LabelOldPin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelOldPin.Location = New System.Drawing.Point(38, 65)
        Me.LabelOldPin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelOldPin.Name = "LabelOldPin"
        Me.LabelOldPin.Size = New System.Drawing.Size(60, 20)
        Me.LabelOldPin.TabIndex = 1
        Me.LabelOldPin.Text = "Old PIN"
        '
        'LabelNewPin
        '
        Me.LabelNewPin.AutoSize = True
        Me.LabelNewPin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelNewPin.Location = New System.Drawing.Point(38, 106)
        Me.LabelNewPin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNewPin.Name = "LabelNewPin"
        Me.LabelNewPin.Size = New System.Drawing.Size(66, 20)
        Me.LabelNewPin.TabIndex = 2
        Me.LabelNewPin.Text = "New PIN"
        '
        'OldPinTxt
        '
        Me.OldPinTxt.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OldPinTxt.Location = New System.Drawing.Point(120, 63)
        Me.OldPinTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OldPinTxt.MaxLength = 6
        Me.OldPinTxt.Name = "OldPinTxt"
        Me.OldPinTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPinTxt.Size = New System.Drawing.Size(136, 27)
        Me.OldPinTxt.TabIndex = 3
        Me.OldPinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewPinTxt
        '
        Me.NewPinTxt.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.NewPinTxt.Location = New System.Drawing.Point(120, 103)
        Me.NewPinTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NewPinTxt.MaxLength = 6
        Me.NewPinTxt.Name = "NewPinTxt"
        Me.NewPinTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPinTxt.Size = New System.Drawing.Size(136, 27)
        Me.NewPinTxt.TabIndex = 4
        Me.NewPinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetBtn
        '
        Me.SetBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SetBtn.ForeColor = System.Drawing.Color.White
        Me.SetBtn.Location = New System.Drawing.Point(68, 154)
        Me.SetBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(75, 32)
        Me.SetBtn.TabIndex = 5
        Me.SetBtn.Text = "✔ Set"
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.IndianRed
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(165, 154)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 32)
        Me.BackBtn.TabIndex = 6
        Me.BackBtn.Text = "✖ Cancel"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'ChangePinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.NewPinTxt)
        Me.Controls.Add(Me.OldPinTxt)
        Me.Controls.Add(Me.LabelNewPin)
        Me.Controls.Add(Me.LabelOldPin)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents LabelOldPin As Label
    Friend WithEvents LabelNewPin As Label
    Friend WithEvents OldPinTxt As TextBox
    Friend WithEvents NewPinTxt As TextBox
    Friend WithEvents SetBtn As Button
    Friend WithEvents BackBtn As Button
End Class
