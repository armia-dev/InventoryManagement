<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddForm
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
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriceTxt = New System.Windows.Forms.TextBox()
        Me.CategoryTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(77, 121)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(76, 25)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(15, 38)
        Me.NameTxt.Multiline = True
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(127, 22)
        Me.NameTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Name"
        '
        'PriceTxt
        '
        Me.PriceTxt.Location = New System.Drawing.Point(15, 93)
        Me.PriceTxt.Multiline = True
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.Size = New System.Drawing.Size(127, 22)
        Me.PriceTxt.TabIndex = 6
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(174, 38)
        Me.CategoryTxt.Multiline = True
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.Size = New System.Drawing.Size(130, 22)
        Me.CategoryTxt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Quantity"
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Location = New System.Drawing.Point(174, 93)
        Me.QuantityTxt.Multiline = True
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.Size = New System.Drawing.Size(130, 22)
        Me.QuantityTxt.TabIndex = 9
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(159, 121)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(76, 25)
        Me.CancelBtn.TabIndex = 10
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(316, 165)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.QuantityTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.PriceTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.AddBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddBtn As Button
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PriceTxt As TextBox
    Friend WithEvents CategoryTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QuantityTxt As TextBox
    Friend WithEvents CancelBtn As Button
End Class
