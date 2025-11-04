Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text

Public Class InventoryControl
    ' === SORTING FLAGS ===
    Private sortAscending As Boolean = False ' ✅ Start with highest → lowest
    Private currentSortColumn As String = "Quantity"

    ' Declare scrollable panel that holds the product rows
    Private pnlScroll As Panel

    ' Timer for smoother searching
    Private searchTimer As New Timer() With {.Interval = 400} ' 0.4 second delay

    Private Sub InventoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize layout only once
        SetupScrollablePanel()
        EnableDoubleBuffer(tlpProduct)
        LoadCategories()

        ' ✅ Set initial sort flag display
        lblQuantity.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblQuantity.Text = "Quantity "
        lblQuantity.ForeColor = Color.ForestGreen

        ' Load products (initial load: Quantity DESC)
        LoadProducts()
    End Sub

    ' === CREATE SCROLLABLE CONTAINER ===
    Private Sub SetupScrollablePanel()
        pnlScroll = New Panel With {
            .Dock = DockStyle.Fill,
            .AutoScroll = True,
            .Padding = New Padding(0),
            .Margin = New Padding(0),
            .BackColor = Color.White
        }

        tlpProduct.Dock = DockStyle.Top
        tlpProduct.AutoSize = True
        tlpProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpProduct.GrowStyle = TableLayoutPanelGrowStyle.AddRows
        tlpProduct.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tlpProduct.Margin = New Padding(0)
        tlpProduct.Padding = New Padding(0)

        tlpProduct.ColumnCount = 5
        tlpProduct.ColumnStyles.Clear()
        For i As Integer = 0 To 4
            tlpProduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F / 5.0F))
        Next

        pnlScroll.Controls.Add(tlpProduct)
        Me.Controls.Add(pnlScroll)
        pnlScroll.BringToFront()
    End Sub

    ' === ENABLE DOUBLE BUFFERING FOR SMOOTH RENDER ===
    Private Sub EnableDoubleBuffer(ctrl As Control)
        Dim t As Type = ctrl.GetType()
        Dim pi = t.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        pi?.SetValue(ctrl, True, Nothing)
    End Sub

    ' === LOAD PRODUCTS (supports search + category filter + sorting) ===
    Private Sub LoadProducts(Optional searchKeyword As String = "", Optional categoryFilter As String = "All")
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' Build query efficiently
                Dim sb As New StringBuilder("SELECT ProductID, Name, Category, Quantity, Price FROM products WHERE 1=1")

                If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                    sb.Append(" AND (ProductID LIKE @keyword OR Name LIKE @keyword)")
                End If

                If categoryFilter <> "All" Then
                    sb.Append(" AND Category = @category")
                End If

                ' === Sorting ===
                If currentSortColumn = "Quantity" Then
                    sb.Append(If(sortAscending, " ORDER BY Quantity ASC", " ORDER BY Quantity DESC"))
                Else
                    sb.Append(" ORDER BY ProductID ASC")
                End If

                ' ✅ Suspend layout for faster rendering
                tlpProduct.SuspendLayout()

                Using cmd As New MySqlCommand(sb.ToString(), con)
                    If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                        cmd.Parameters.AddWithValue("@keyword", "%" & searchKeyword & "%")
                    End If
                    If categoryFilter <> "All" Then
                        cmd.Parameters.AddWithValue("@category", categoryFilter)
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Reset table layout
                        tlpProduct.Controls.Clear()
                        tlpProduct.RowStyles.Clear()
                        tlpProduct.RowCount = 0

                        Dim rowIndex As Integer = 0
                        Dim rowHeight As Integer = 35

                        ' Cache font for better performance
                        Dim baseFont As New Font("Segoe UI", 15, FontStyle.Regular)

                        While reader.Read()
                            tlpProduct.RowStyles.Add(New RowStyle(SizeType.Absolute, rowHeight))
                            tlpProduct.RowCount += 1

                            ' === Add Product Info Cells ===
                            AddProductCell(rowIndex, 0, reader("Name").ToString(), baseFont)
                            AddProductCell(rowIndex, 1, reader("Category").ToString(), baseFont)

                            ' === Quantity with color ===
                            Dim qty As Integer = Convert.ToInt32(reader("Quantity"))
                            Dim lblQty As New Label With {
                                .Text = qty.ToString(),
                                .Dock = DockStyle.Fill,
                                .TextAlign = ContentAlignment.MiddleCenter,
                                .AutoSize = False,
                                .Margin = New Padding(0),
                                .Font = baseFont,
                                .Height = 35,
                                .ForeColor = If(qty < 16, Color.IndianRed, Color.Black)
                            }
                            tlpProduct.Controls.Add(lblQty, 2, rowIndex)

                            ' === Price ===
                            AddProductCell(rowIndex, 3, "₱" & Convert.ToDecimal(reader("Price")).ToString("N2"), baseFont)

                            ' === Actions (edit/delete) ===
                            Dim pnlActions As New FlowLayoutPanel With {
                                .FlowDirection = FlowDirection.LeftToRight,
                                .Dock = DockStyle.Fill,
                                .AutoSize = False,
                                .Margin = New Padding(0),
                                .Padding = New Padding(0),
                                .WrapContents = False,
                                .Anchor = AnchorStyles.None
                            }

                            Dim btnEdit As New Button With {
                                .Text = "✏️",
                                .Width = 35,
                                .Height = 30,
                                .FlatStyle = FlatStyle.Flat,
                                .BackColor = Color.LightYellow,
                                .Tag = reader("ProductID"),
                                .Margin = New Padding(2, 2, 1, 2)
                            }
                            AddHandler btnEdit.Click, AddressOf Me.EditProduct
                            Dim btnDelete As New Button With {
                                .Text = "🗑️",
                                .Width = 35,
                                .Height = 30,
                                .FlatStyle = FlatStyle.Flat,
                                .BackColor = Color.MistyRose,
                                .Tag = reader("ProductID"),
                                .Margin = New Padding(1, 2, 2, 2)
                            }
                            AddHandler btnDelete.Click, AddressOf Me.DeleteProduct

                            pnlActions.Controls.Add(btnEdit)
                            pnlActions.Controls.Add(btnDelete)
                            tlpProduct.Controls.Add(pnlActions, 4, rowIndex)

                            rowIndex += 1
                        End While
                    End Using
                End Using

                ' ✅ Resume layout (repaint after batch update)
                tlpProduct.ResumeLayout(True)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' === LOAD CATEGORIES ===
    Private Sub LoadCategories()
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT DISTINCT Category FROM products ORDER BY Category ASC"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbCategory.Items.Clear()
                        cmbCategory.Items.Add("All")
                        While reader.Read()
                            cmbCategory.Items.Add(reader("Category").ToString())
                        End While
                        cmbCategory.SelectedIndex = 0
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    ' === ADD PRODUCT CELL ===
    Private Sub AddProductCell(row As Integer, col As Integer, text As String, baseFont As Font)
        Dim lbl As New Label With {
            .Text = text,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .AutoSize = False,
            .Margin = New Padding(0),
            .Font = baseFont,
            .Height = 35
        }
        tlpProduct.Controls.Add(lbl, col, row)
    End Sub

    ' === EDIT PRODUCT ===
    Private Sub EditProduct(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim productId As Integer = Convert.ToInt32(btn.Tag)

        Dim frm As New AddEditForm()
        frm.Text = "Edit Product"
        frm.Mode = "Edit"
        frm.ProductID = productId
        frm.ShowDialog()

        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    ' === DELETE PRODUCT ===
    Private Sub DeleteProduct(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim productId As Integer = Convert.ToInt32(btn.Tag)

        If MessageBox.Show("Are you sure you want to delete this record?",
                           "Confirm Delete", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
                Using con As New MySqlConnection(connectionString)
                    con.Open()
                    Dim query As String = "DELETE FROM products WHERE ProductID = @ProductID"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@ProductID", productId)
                        If cmd.ExecuteNonQuery() > 0 Then
                            LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
            End Try
        End If
    End Sub

    ' === COMBOBOX FILTER ===
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    ' === ADD PRODUCT ===
    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim frm As New AddEditForm()
        frm.Text = "Add Product"
        frm.Mode = "Add"
        frm.ShowDialog()

        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    ' === SORTING BY QUANTITY CLICK ===
    Private Sub lblQuantity_Click(sender As Object, e As EventArgs) Handles lblQuantity.Click
        sortAscending = Not sortAscending

        If sortAscending Then
            lblQuantity.Text = "Quantity ▼"
            lblQuantity.ForeColor = Color.IndianRed
        Else
            lblQuantity.Text = "Quantity ▲"
            lblQuantity.ForeColor = Color.ForestGreen
        End If

        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    ' === SEARCH AS YOU TYPE (No Enter Needed) ===
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchTimer.Stop()
        AddHandler searchTimer.Tick, AddressOf PerformSearch
        searchTimer.Start()
    End Sub

    Private Sub PerformSearch(sender As Object, e As EventArgs)
        searchTimer.Stop()
        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub


End Class