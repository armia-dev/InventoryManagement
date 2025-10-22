Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text

Public Class CheckControl
    ' Use different variable names to avoid conflicts with designer controls
    Private Shared mySharedCart As CartControl = Nothing
    Private sortAscending As Boolean = False
    Private mySortColumn As String = "Quantity"
    Private myScrollPanel As Panel

    Private Sub CheckControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupScrollablePanel()
        EnableDoubleBuffer(tlpProduct)
        LoadCategories()

        lblQuantity.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblQuantity.Text = "Quantity ▼"
        lblQuantity.ForeColor = Color.ForestGreen

        LoadProducts()
    End Sub

    Private Sub SetupScrollablePanel()
        myScrollPanel = New Panel With {
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

        tlpProduct.ColumnCount = 6
        tlpProduct.ColumnStyles.Clear()
        For i As Integer = 0 To 5
            tlpProduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F / 6.0F))
        Next

        myScrollPanel.Controls.Add(tlpProduct)
        Me.Controls.Add(myScrollPanel)
        myScrollPanel.BringToFront()
    End Sub

    Private Sub EnableDoubleBuffer(ctrl As Control)
        Dim t As Type = ctrl.GetType()
        Dim pi = t.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        pi?.SetValue(ctrl, True, Nothing)
    End Sub

    Private Sub LoadProducts(Optional searchKeyword As String = "", Optional categoryFilter As String = "All")
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim sb As New StringBuilder("SELECT ProductID, Name, Category, Quantity, Price FROM products WHERE 1=1")

                If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                    sb.Append(" AND (ProductID LIKE @keyword OR Name LIKE @keyword)")
                End If
                If categoryFilter <> "All" Then
                    sb.Append(" AND Category = @category")
                End If

                If mySortColumn = "Quantity" Then
                    sb.Append(If(sortAscending, " ORDER BY Quantity ASC", " ORDER BY Quantity DESC"))
                Else
                    sb.Append(" ORDER BY ProductID ASC")
                End If

                tlpProduct.SuspendLayout()

                Using cmd As New MySqlCommand(sb.ToString(), con)
                    If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                        cmd.Parameters.AddWithValue("@keyword", "%" & searchKeyword & "%")
                    End If
                    If categoryFilter <> "All" Then
                        cmd.Parameters.AddWithValue("@category", categoryFilter)
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        tlpProduct.Controls.Clear()
                        tlpProduct.RowStyles.Clear()
                        tlpProduct.RowCount = 0

                        Dim rowIndex As Integer = 0
                        Dim rowHeight As Integer = 35
                        Dim baseFont As New Font("Segoe UI", 15, FontStyle.Regular)

                        While reader.Read()
                            tlpProduct.RowStyles.Add(New RowStyle(SizeType.Absolute, rowHeight))
                            tlpProduct.RowCount += 1

                            AddProductCell(rowIndex, 0, reader("ProductID").ToString(), baseFont)
                            AddProductCell(rowIndex, 1, reader("Name").ToString(), baseFont)
                            AddProductCell(rowIndex, 2, reader("Category").ToString(), baseFont)

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
                            tlpProduct.Controls.Add(lblQty, 3, rowIndex)

                            AddProductCell(rowIndex, 4, "₱" & Convert.ToDecimal(reader("Price")).ToString("N2"), baseFont)

                            Dim btnAddToCart As New Button With {
                                .Text = "Add to Cart",
                                .AutoSize = False,
                                .Width = 110,
                                .Height = 30,
                                .FlatStyle = FlatStyle.Flat,
                                .BackColor = Color.PaleGreen,
                                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                                .Tag = New With {
                                    .ProductID = reader("ProductID"),
                                    .Name = reader("Name"),
                                    .Category = reader("Category"),
                                    .Price = reader("Price")
                                }
                            }
                            AddHandler btnAddToCart.Click, AddressOf AddToCart_Click
                            tlpProduct.Controls.Add(btnAddToCart, 5, rowIndex)

                            rowIndex += 1
                        End While
                    End Using
                End Using

                tlpProduct.ResumeLayout(True)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

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

    Private Sub AddToCart_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim data = btn.Tag

        Dim stockQty As Integer = 0
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT Quantity FROM products WHERE ProductID = @id"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", data.ProductID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then stockQty = Convert.ToInt32(result)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving stock: " & ex.Message)
            Return
        End Try

        Dim frm As New AddToCartControl()
        frm.ProductID = data.ProductID
        frm.ProductName = data.Name
        frm.Category = data.Category
        frm.Price = data.Price
        frm.MaxStock = stockQty

        frm.ShowDialog()

        If frm.IsConfirmed Then
            AddProductToCart(data.ProductID, data.Name, data.Category, data.Price, frm.EnteredQty)
        End If
    End Sub

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

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    Private Sub lblQuantity_Click(sender As Object, e As EventArgs) Handles lblQuantity.Click
        sortAscending = Not sortAscending
        If sortAscending Then
            lblQuantity.Text = "Quantity ▲"
            lblQuantity.ForeColor = Color.IndianRed
        Else
            lblQuantity.Text = "Quantity ▼"
            lblQuantity.ForeColor = Color.ForestGreen
        End If
        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts(txtSearch.Text.Trim(), cmbCategory.Text)
    End Sub

    Private Sub viewProd_Click(sender As Object, e As EventArgs) Handles viewProd.Click
        If mySharedCart Is Nothing OrElse mySharedCart.IsDisposed Then
            mySharedCart = New CartControl()
            AddHandler mySharedCart.FormClosed, Sub() mySharedCart = Nothing
        End If

        mySharedCart.Show()
        mySharedCart.BringToFront()
    End Sub

    Private Sub AddProductToCart(ProductID As Integer, Name As String, Category As String, Price As Decimal, Quantity As Integer)
        If mySharedCart Is Nothing OrElse mySharedCart.IsDisposed Then
            mySharedCart = New CartControl()
            AddHandler mySharedCart.FormClosed, Sub() mySharedCart = Nothing
        End If

        mySharedCart.AddToCart(ProductID, Name, Quantity, Price)

        MessageBox.Show($"Added {Quantity} x {Name} to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If Not mySharedCart.Visible Then
            mySharedCart.Show()
        End If

        mySharedCart.BringToFront()
    End Sub

End Class