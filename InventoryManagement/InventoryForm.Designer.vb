<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductTable = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DeleteBtns = New System.Windows.Forms.Button()
        Me.AddBtns = New System.Windows.Forms.Button()
        Me.EditBtns = New System.Windows.Forms.Button()
        Me.CategoryBox = New System.Windows.Forms.ComboBox()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.BackBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 74)
        Me.Panel1.TabIndex = 4
        '
        'BackBtn
        '
        Me.BackBtn.FlatAppearance.BorderSize = 0
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.Location = New System.Drawing.Point(503, -1)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(38, 37)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     Inventory"
        '
        'ProductTable
        '
        Me.ProductTable.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.ProductTable.Location = New System.Drawing.Point(15, 107)
        Me.ProductTable.Name = "ProductTable"
        Me.ProductTable.Size = New System.Drawing.Size(514, 212)
        Me.ProductTable.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Controls.Add(Me.DeleteBtns)
        Me.Panel2.Controls.Add(Me.AddBtns)
        Me.Panel2.Controls.Add(Me.EditBtns)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 37)
        Me.Panel2.TabIndex = 11
        '
        'DeleteBtns
        '
        Me.DeleteBtns.BackColor = System.Drawing.Color.Tomato
        Me.DeleteBtns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteBtns.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtns.Image = CType(resources.GetObject("DeleteBtns.Image"), System.Drawing.Image)
        Me.DeleteBtns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBtns.Location = New System.Drawing.Point(336, 3)
        Me.DeleteBtns.Name = "DeleteBtns"
        Me.DeleteBtns.Size = New System.Drawing.Size(101, 33)
        Me.DeleteBtns.TabIndex = 7
        Me.DeleteBtns.Text = "Delete"
        Me.DeleteBtns.UseVisualStyleBackColor = False
        '
        'AddBtns
        '
        Me.AddBtns.BackColor = System.Drawing.Color.Chartreuse
        Me.AddBtns.FlatAppearance.BorderSize = 0
        Me.AddBtns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddBtns.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtns.Image = CType(resources.GetObject("AddBtns.Image"), System.Drawing.Image)
        Me.AddBtns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBtns.Location = New System.Drawing.Point(122, 2)
        Me.AddBtns.Name = "AddBtns"
        Me.AddBtns.Size = New System.Drawing.Size(101, 33)
        Me.AddBtns.TabIndex = 8
        Me.AddBtns.Text = "   Add New"
        Me.AddBtns.UseVisualStyleBackColor = False
        '
        'EditBtns
        '
        Me.EditBtns.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.EditBtns.FlatAppearance.BorderSize = 0
        Me.EditBtns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditBtns.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtns.Image = CType(resources.GetObject("EditBtns.Image"), System.Drawing.Image)
        Me.EditBtns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditBtns.Location = New System.Drawing.Point(229, 2)
        Me.EditBtns.Name = "EditBtns"
        Me.EditBtns.Size = New System.Drawing.Size(101, 33)
        Me.EditBtns.TabIndex = 9
        Me.EditBtns.Text = "Edit"
        Me.EditBtns.UseVisualStyleBackColor = False
        '
        'CategoryBox
        '
        Me.CategoryBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(423, 80)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(106, 21)
        Me.CategoryBox.TabIndex = 12
        '
        'SearchTxt
        '
        Me.SearchTxt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SearchTxt.Location = New System.Drawing.Point(207, 80)
        Me.SearchTxt.Multiline = True
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(210, 23)
        Me.SearchTxt.TabIndex = 13
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(541, 367)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.CategoryBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ProductTable)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ProductTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductTable As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddBtns As Button
    Friend WithEvents EditBtns As Button
    Friend WithEvents CategoryBox As ComboBox
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents DeleteBtns As Button
End Class
