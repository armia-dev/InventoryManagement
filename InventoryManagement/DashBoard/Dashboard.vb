Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class Dashboard
    Private connectionString As String = "Server=localhost;User ID=root;Password='';Database=inventorymanagement;"

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTopSellingProducts()
        LoadProductSummary()
    End Sub

    ' ==============================
    ' 📊 LOAD TOP SELLING PRODUCTS
    ' ==============================
    Private Sub LoadTopSellingProducts()
        ' Reset and style the table
        Topsellingproduct.Controls.Clear()
        Topsellingproduct.RowStyles.Clear()
        Topsellingproduct.RowCount = 0
        Topsellingproduct.AutoScroll = True
        Topsellingproduct.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        Topsellingproduct.BackColor = Color.White
        Topsellingproduct.Padding = New Padding(0)
        Topsellingproduct.Margin = New Padding(0)

        ' Define 4 columns
        Topsellingproduct.ColumnCount = 4
        Topsellingproduct.ColumnStyles.Clear()
        Topsellingproduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15)) ' Product ID
        Topsellingproduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45)) ' Product Name
        Topsellingproduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20)) ' Quantity Sold
        Topsellingproduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20)) ' Total ₱

        ' Add header row
        AddRow("Product ID", "Product Name", "Quantity", "Total",
               New Font("Segoe UI Semibold", 10, FontStyle.Bold),
               Color.FromArgb(225, 230, 240), True)

        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                    SELECT 
                        ProductID,
                        ProductName,
                        SUM(Quantity) AS TotalQuantity,
                        SUM(Subtotal) AS TotalSales
                    FROM transactions
                    GROUP BY ProductID, ProductName
                    ORDER BY TotalQuantity DESC;"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim rowIndex As Integer = 0

                        While reader.Read()
                            Dim pid As Integer = reader("ProductID")
                            Dim pname As String = reader("ProductName").ToString()
                            Dim qty As Integer = reader("TotalQuantity")
                            Dim totalSales As Decimal = reader("TotalSales")

                            ' Alternating row colors
                            Dim bgColor As Color = If(rowIndex Mod 2 = 0, Color.White, Color.FromArgb(245, 247, 250))

                            AddRow(pid.ToString(), pname, qty.ToString(), "₱" & totalSales.ToString("N2"),
                                   New Font("Segoe UI", 10, FontStyle.Regular), bgColor, False)
                            rowIndex += 1
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading top-selling products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ==============================
    ' 📦 LOAD PRODUCT SUMMARY LABELS
    ' ==============================
    Private Sub LoadProductSummary()
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' Query total, low stock, and out of stock
                Dim query As String = "
                    SELECT 
                        COUNT(*) AS TotalProducts,
                        SUM(CASE WHEN Quantity < 15 AND Quantity > 0 THEN 1 ELSE 0 END) AS LowStock,
                        SUM(CASE WHEN Quantity = 0 THEN 1 ELSE 0 END) AS OutOfStock
                    FROM products;"

                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblTotal.Text = reader("TotalProducts").ToString()
                            lblLow.Text = reader("LowStock").ToString()
                            lblOut.Text = reader("OutOfStock").ToString()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading product summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ==============================
    ' 🧱 TABLE HELPERS
    ' ==============================
    Private Sub AddRow(c1 As String, c2 As String, c3 As String, c4 As String,
                       font As Font, bg As Color, Optional isHeader As Boolean = False)

        Dim rowIndex As Integer = Topsellingproduct.RowCount
        Topsellingproduct.RowCount += 1
        Topsellingproduct.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))

        Dim labels = {
            CreateCell(c1, ContentAlignment.MiddleCenter, font, bg, isHeader),
            CreateCell(c2, ContentAlignment.MiddleLeft, font, bg, isHeader),
            CreateCell(c3, ContentAlignment.MiddleCenter, font, bg, isHeader),
            CreateCell(c4, ContentAlignment.MiddleRight, font, bg, isHeader)
        }

        For i As Integer = 0 To 3
            labels(i).Margin = New Padding(0)
            labels(i).Dock = DockStyle.Fill
            Topsellingproduct.Controls.Add(labels(i), i, rowIndex)
        Next
    End Sub

    Private Function CreateCell(text As String, align As ContentAlignment, font As Font, bg As Color, isHeader As Boolean) As Label
        Dim lbl As New Label With {
            .Text = text,
            .Font = font,
            .BackColor = bg,
            .ForeColor = If(isHeader, Color.Black, Color.FromArgb(50, 50, 50)),
            .TextAlign = align,
            .Dock = DockStyle.Fill,
            .AutoSize = False,
            .Margin = New Padding(0),
            .Padding = New Padding(5, 0, 5, 0)
        }
        Return lbl
    End Function
End Class
