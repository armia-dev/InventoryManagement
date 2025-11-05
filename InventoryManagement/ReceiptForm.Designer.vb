<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblTransacID = New System.Windows.Forms.Label()
        Me.tblReceipt = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Receipt"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(223, 10)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(223, 56)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(47, 13)
        Me.lblChange.TabIndex = 1
        Me.lblChange.Text = "Change:"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Location = New System.Drawing.Point(223, 33)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(77, 13)
        Me.lblCash.TabIndex = 2
        Me.lblCash.Text = "Receive Cash:"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(3, 33)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(80, 13)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "Date and Time:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCashier)
        Me.Panel2.Controls.Add(Me.lblTransacID)
        Me.Panel2.Controls.Add(Me.lblDateTime)
        Me.Panel2.Controls.Add(Me.lblCash)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 344)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 87)
        Me.Panel2.TabIndex = 4
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.Location = New System.Drawing.Point(5, 56)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(45, 13)
        Me.lblCashier.TabIndex = 5
        Me.lblCashier.Text = "Cashier:"
        '
        'lblTransacID
        '
        Me.lblTransacID.AutoSize = True
        Me.lblTransacID.Location = New System.Drawing.Point(3, 10)
        Me.lblTransacID.Name = "lblTransacID"
        Me.lblTransacID.Size = New System.Drawing.Size(80, 13)
        Me.lblTransacID.TabIndex = 4
        Me.lblTransacID.Text = "Transaction ID:"
        '
        'tblReceipt
        '
        Me.tblReceipt.ColumnCount = 4
        Me.tblReceipt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82759!))
        Me.tblReceipt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82759!))
        Me.tblReceipt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82759!))
        Me.tblReceipt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.28736!))
        Me.tblReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblReceipt.Location = New System.Drawing.Point(0, 52)
        Me.tblReceipt.Name = "tblReceipt"
        Me.tblReceipt.RowCount = 1
        Me.tblReceipt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblReceipt.Size = New System.Drawing.Size(435, 379)
        Me.tblReceipt.TabIndex = 3
        '
        'ReceiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 431)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tblReceipt)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReceiptForm"
        Me.Text = "ReceiptForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tblReceipt As TableLayoutPanel
    Friend WithEvents lblCashier As Label
    Friend WithEvents lblTransacID As Label
End Class
