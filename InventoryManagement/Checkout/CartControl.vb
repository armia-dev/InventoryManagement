Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class CartControl
    Public TotalAmount As Decimal = 0
    Private SelectedRow As Integer = -1 ' Track selected row
    Private SelectedProductId As Integer = -1 ' Track selected product ID

    Private Sub CartControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblCart.AutoScroll = False
        UpdateTotalDisplay()
        tableload()
    End Sub

    ' === LOAD TABLE ===
    Private Sub tableload()
        tblCart.Controls.Clear()
        tblCart.RowStyles.Clear()
        tblCart.RowCount = 0
        TotalAmount = 0
        SelectedRow = -1
        SelectedProductId = -1

        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT ProductId, Name, Category, Quantity, Price FROM cart"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim rowIndex As Integer = 0
                        While reader.Read()
                            tblCart.RowCount += 1
                            tblCart.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))

                            Dim productId As Integer = reader("ProductId")
                            Dim name As String = reader("Name").ToString()
                            Dim qty As Integer = reader("Quantity")
                            Dim price As Decimal = reader("Price")
                            Dim subtotal As Decimal = qty * price
                            TotalAmount += subtotal

                            Dim dataFont As New Font("Segoe UI", 10, FontStyle.Regular)

                            ' Alternate row colors
                            Dim bgColor As Color = If(rowIndex Mod 2 = 0, Color.White, Color.FromArgb(245, 247, 250))

                            ' Better label style with click handler
                            Dim createLabel = Function(text As String, align As ContentAlignment, bg As Color, prodId As Integer, row As Integer) As Label
                                                  Dim lbl As New Label With {
                                                      .Text = text,
                                                      .Dock = DockStyle.Top,
                                                      .Font = dataFont,
                                                      .TextAlign = ContentAlignment.MiddleCenter,
                                                      .BackColor = bg,
                                                      .BorderStyle = BorderStyle.FixedSingle,
                                                      .AutoSize = False,
                                                      .Margin = New Padding(0),
                                                      .Padding = New Padding(5, 0, 5, 0),
                                                      .Cursor = Cursors.Hand,
                                                      .Tag = New With {.ProductId = prodId, .Row = row}
                                                  }
                                                  AddHandler lbl.Click, AddressOf Label_Click
                                                  Return lbl
                                              End Function

                            ' Add columns
                            tblCart.Controls.Add(createLabel(productId.ToString(), ContentAlignment.MiddleCenter, bgColor, productId, rowIndex), 0, rowIndex)
                            tblCart.Controls.Add(createLabel(name, ContentAlignment.MiddleLeft, bgColor, productId, rowIndex), 1, rowIndex)
                            tblCart.Controls.Add(createLabel(qty.ToString(), ContentAlignment.MiddleCenter, bgColor, productId, rowIndex), 2, rowIndex)
                            tblCart.Controls.Add(createLabel("₱" & price.ToString("N2"), ContentAlignment.MiddleRight, bgColor, productId, rowIndex), 3, rowIndex)
                            tblCart.Controls.Add(createLabel("₱" & subtotal.ToString("N2"), ContentAlignment.MiddleRight, bgColor, productId, rowIndex), 4, rowIndex)

                            rowIndex += 1
                        End While
                    End Using
                End Using
            End Using
            UpdateTotalDisplay()

        Catch ex As Exception
            MessageBox.Show("Error loading table: " & ex.Message)
        End Try
    End Sub

    ' === HANDLE ROW SELECTION ===
    Private Sub Label_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = CType(sender, Label)
        Dim tagData = clickedLabel.Tag
        Dim productId As Integer = tagData.ProductId
        Dim row As Integer = tagData.Row

        ' Toggle selection
        If SelectedRow = row Then
            ' Deselect
            DeselectRow()
        Else
            ' Select new row
            SelectRow(row, productId)
        End If
    End Sub

    ' === SELECT ROW ===
    Private Sub SelectRow(row As Integer, productId As Integer)
        ' Deselect previous row first
        If SelectedRow >= 0 Then
            DeselectRow()
        End If

        SelectedRow = row
        SelectedProductId = productId

        ' Highlight the selected row
        For col As Integer = 0 To tblCart.ColumnCount - 1
            Dim ctrl = tblCart.GetControlFromPosition(col, row)
            If TypeOf ctrl Is Label Then
                CType(ctrl, Label).BackColor = Color.FromArgb(173, 216, 230) ' Light blue
                CType(ctrl, Label).Font = New Font("Segoe UI", 10, FontStyle.Bold)
            End If
        Next
    End Sub

    ' === DESELECT ROW ===
    Private Sub DeselectRow()
        If SelectedRow >= 0 Then
            ' Restore original color
            Dim originalColor As Color = If(SelectedRow Mod 2 = 0, Color.White, Color.FromArgb(245, 247, 250))

            For col As Integer = 0 To tblCart.ColumnCount - 1
                Dim ctrl = tblCart.GetControlFromPosition(col, SelectedRow)
                If TypeOf ctrl Is Label Then
                    CType(ctrl, Label).BackColor = originalColor
                    CType(ctrl, Label).Font = New Font("Segoe UI", 10, FontStyle.Regular)
                End If
            Next

            SelectedRow = -1
            SelectedProductId = -1
        End If
    End Sub

    ' === REMOVE SELECTED ITEM ===
    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If SelectedProductId = -1 Then
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this item from the cart?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
                Using con As New MySqlConnection(connectionString)
                    con.Open()

                    ' Delete from cart table
                    Dim deleteQuery As String = "DELETE FROM cart WHERE ProductId = @ProductId"
                    Using deleteCmd As New MySqlCommand(deleteQuery, con)
                        deleteCmd.Parameters.AddWithValue("@ProductId", SelectedProductId)
                        Dim rowsAffected As Integer = deleteCmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Item removed from cart successfully!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Reload the table
                            tableload()
                        Else
                            MessageBox.Show("Item not found in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error removing item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' === ADD ITEM TO CART ===
    Public Sub AddToCart(productID As Integer, name As String, qty As Integer, price As Decimal)
        tblCart.SuspendLayout()

        Dim subtotal As Decimal = qty * price
        Dim rowIndex As Integer = tblCart.RowCount
        tblCart.RowCount += 1
        tblCart.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))

        Dim dataFont As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim bgColor As Color = If(rowIndex Mod 2 = 0, Color.White, Color.FromArgb(245, 247, 250))

        Dim createLabel = Function(text As String, align As ContentAlignment) As Label
                              Dim lbl As New Label With {
                                  .Text = text,
                                  .Dock = DockStyle.None,
                                  .Anchor = AnchorStyles.None,
                                  .Font = dataFont,
                                  .TextAlign = align,
                                  .BackColor = bgColor,
                                  .BorderStyle = BorderStyle.FixedSingle,
                                  .AutoSize = True,
                                  .Margin = New Padding(5),
                                  .Padding = New Padding(10, 5, 10, 5),
                                  .Cursor = Cursors.Hand,
                                  .Tag = New With {.ProductId = productID, .Row = rowIndex}
                              }
                              AddHandler lbl.Click, AddressOf Label_Click
                              Return lbl
                          End Function

        tblCart.Controls.Add(createLabel(productID.ToString(), ContentAlignment.MiddleCenter), 0, rowIndex)
        tblCart.Controls.Add(createLabel(name, ContentAlignment.MiddleLeft), 1, rowIndex)
        tblCart.Controls.Add(createLabel(qty.ToString(), ContentAlignment.MiddleCenter), 2, rowIndex)
        tblCart.Controls.Add(createLabel("₱" & price.ToString("N2"), ContentAlignment.MiddleRight), 3, rowIndex)
        tblCart.Controls.Add(createLabel("₱" & subtotal.ToString("N2"), ContentAlignment.MiddleRight), 4, rowIndex)

        TotalAmount += subtotal
        UpdateTotalDisplay()
        tblCart.ResumeLayout(True)
        tblCart.Refresh()
    End Sub

    ' === UPDATE TOTAL DISPLAY ===
    Private Sub UpdateTotalDisplay()
        If lblTotal IsNot Nothing Then
            lblTotal.Text = "TOTAL: ₱" & TotalAmount.ToString("N2")
        End If
    End Sub

    ' === UPDATE INVENTORY (Subtract cart qty from products) ===
    Private Sub UpdateInventory(productID As Integer, qtySold As Integer)
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "UPDATE products SET Quantity = Quantity - @qty WHERE ProductID = @id"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@qty", qtySold)
                    cmd.Parameters.AddWithValue("@id", productID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating inventory: " & ex.Message)
        End Try
    End Sub

    ' === CONFIRM SALE ===
    Private Sub btnConfirmSale_Click(sender As Object, e As EventArgs) Handles btnConfirmSale.Click
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"

            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' ✅ Step 1: Check if cart table has items
                Dim cartCount As Integer
                Using countCmd As New MySqlCommand("SELECT COUNT(*) FROM cart", con)
                    cartCount = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using

                If cartCount = 0 Then
                    MessageBox.Show("Cart is empty! Please add items first.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' ✅ Step 2: Get total from cart table
                Dim total As Decimal = 0
                Using totalCmd As New MySqlCommand("SELECT SUM(Quantity * Price) FROM cart", con)
                    Dim result = totalCmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        total = Convert.ToDecimal(result)
                    End If
                End Using

                ' ✅ Step 3: Validate cash
                Dim cashReceived As Decimal
                If Not Decimal.TryParse(txtCashReceived.Text, cashReceived) Then
                    MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                If cashReceived < total Then
                    MessageBox.Show("Insufficient cash!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' ✅ Step 4: Create a new TransactionID manually
                Dim newTransID As Integer
                Using getNextIdCmd As New MySqlCommand("SELECT IFNULL(MAX(TransactionID), 0) + 1 FROM transactions", con)
                    newTransID = Convert.ToInt32(getNextIdCmd.ExecuteScalar())
                End Using

                ' ✅ Step 5: Insert all cart items using same TransactionID
                Dim change As Decimal = cashReceived - total
                Using insertCmd As New MySqlCommand("
                INSERT INTO transactions 
                (TransactionID, ProductID, ProductName, Quantity, Price, Subtotal, `Date&Time`, user, Cash_Received, Total_Amount, Change_Amount)
                SELECT @transID, ProductID, Name, Quantity, Price, (Quantity * Price), NOW(), @user, @cash, @total, @change
                FROM cart", con)

                    insertCmd.Parameters.AddWithValue("@transID", newTransID)
                    insertCmd.Parameters.AddWithValue("@user", LoggedInUsername)
                    insertCmd.Parameters.AddWithValue("@cash", cashReceived)
                    insertCmd.Parameters.AddWithValue("@total", total)
                    insertCmd.Parameters.AddWithValue("@change", change)
                    insertCmd.ExecuteNonQuery()
                End Using

                ' ✅ Step 6: Update products (subtract stock)
                Using cartCmd As New MySqlCommand("SELECT ProductID, Quantity FROM cart", con)
                    Using reader As MySqlDataReader = cartCmd.ExecuteReader()
                        Dim updates As New List(Of Tuple(Of Integer, Integer))
                        While reader.Read()
                            updates.Add(New Tuple(Of Integer, Integer)(reader("ProductID"), reader("Quantity")))
                        End While
                        reader.Close()

                        For Each item In updates
                            Using updateCmd As New MySqlCommand("UPDATE products SET Quantity = Quantity - @qty WHERE ProductID = @id", con)
                                updateCmd.Parameters.AddWithValue("@qty", item.Item2)
                                updateCmd.Parameters.AddWithValue("@id", item.Item1)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        Next
                    End Using
                End Using

                ' ✅ Step 7: Clear cart
                Using clearCmd As New MySqlCommand("DELETE FROM cart", con)
                    clearCmd.ExecuteNonQuery()
                End Using

                ' ✅ Step 8: Store transaction ID in Module1
                TransID = newTransID

                ' ✅ Step 9: Refresh UI and show receipt
                tableload()
                txtCashReceived.Text = ""
                lblTotal.Text = "TOTAL: ₱0.00"

                ReceiptForm.Show()

            End Using

        Catch ex As Exception
            MessageBox.Show("Error during sale confirmation: " & ex.Message)
        End Try
    End Sub


    ' === CANCEL TRANSACTION ===
    Public Sub CancelTransaction()
        tblCart.Controls.Clear()
        tblCart.RowStyles.Clear()
        tblCart.RowCount = 0
        TotalAmount = 0
        SelectedRow = -1
        SelectedProductId = -1
        UpdateTotalDisplay()
        If txtCashReceived IsNot Nothing Then txtCashReceived.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class