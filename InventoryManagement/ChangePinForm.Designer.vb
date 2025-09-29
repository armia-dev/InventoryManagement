<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePinForm
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
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Oldpin = New System.Windows.Forms.TextBox()
        Me.Newpin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.FlatAppearance.BorderSize = 0
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackBtn.Location = New System.Drawing.Point(147, 164)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(57, 25)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.Text = "Cancel"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CHANGE YOUR PIN CODE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 40)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Old Pin"
        '
        'Oldpin
        '
        Me.Oldpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Oldpin.Location = New System.Drawing.Point(106, 74)
        Me.Oldpin.Multiline = True
        Me.Oldpin.Name = "Oldpin"
        Me.Oldpin.Size = New System.Drawing.Size(141, 19)
        Me.Oldpin.TabIndex = 6
        Me.Oldpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Newpin
        '
        Me.Newpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Newpin.Location = New System.Drawing.Point(106, 109)
        Me.Newpin.Multiline = True
        Me.Newpin.Name = "Newpin"
        Me.Newpin.Size = New System.Drawing.Size(141, 19)
        Me.Newpin.TabIndex = 7
        Me.Newpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "New Pin"
        '
        'SetBtn
        '
        Me.SetBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetBtn.Location = New System.Drawing.Point(132, 134)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(93, 24)
        Me.SetBtn.TabIndex = 9
        Me.SetBtn.Text = "Set New Pin"
        Me.SetBtn.UseVisualStyleBackColor = True
        '
        'ChangePinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(356, 193)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Newpin)
        Me.Controls.Add(Me.Oldpin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Oldpin As TextBox
    Friend WithEvents Newpin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SetBtn As Button
End Class
