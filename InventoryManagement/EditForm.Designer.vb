<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.PriceTxt = New System.Windows.Forms.TextBox()
        Me.CategoryTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PriceTxt
        '
        Me.PriceTxt.Location = New System.Drawing.Point(177, 94)
        Me.PriceTxt.Multiline = True
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.Size = New System.Drawing.Size(127, 22)
        Me.PriceTxt.TabIndex = 2
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(177, 40)
        Me.CategoryTxt.Multiline = True
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.Size = New System.Drawing.Size(127, 22)
        Me.CategoryTxt.TabIndex = 3
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(12, 40)
        Me.NameTxt.Multiline = True
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(127, 22)
        Me.NameTxt.TabIndex = 4
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Location = New System.Drawing.Point(15, 94)
        Me.QuantityTxt.Multiline = True
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.Size = New System.Drawing.Size(127, 22)
        Me.QuantityTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Quantity"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(79, 122)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(76, 25)
        Me.EditBtn.TabIndex = 10
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(161, 122)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(76, 25)
        Me.CancelBtn.TabIndex = 11
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(316, 165)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.QuantityTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.PriceTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PriceTxt As TextBox
    Friend WithEvents CategoryTxt As TextBox
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents QuantityTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
