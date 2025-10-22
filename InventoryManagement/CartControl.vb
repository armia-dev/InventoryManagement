Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class CartControl
    Public TotalAmount As Decimal = 0

    Private Sub CartControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Don't setup table since headers already exist in designer
        ' Just ensure proper configuration
        tblCart.AutoScroll = False
        UpdateTotalDisplay()
    End Sub

    ' === ADD ITEM TO CART ===
    Public Sub AddToCart(productID As Integer, name As String, qty As Integer, price As Decimal)
        tblCart.SuspendLayout()

        Dim subtotal As Decimal = qty * price
        Dim rowIndex As Integer = tblCart.RowCount

        ' Add new row
        tblCart.RowCount += 1
        tblCart.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))

        ' Create font for data rows
        Dim dataFont As New Font("Segoe UI", 9, FontStyle.Regular)

        ' Add ProductID
        Dim lblID As New Label With {
            .Text = productID.ToString(),
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = dataFont,
            .AutoSize = False,
            .BackColor = Color.White
        }
        tblCart.Controls.Add(lblID, 0, rowIndex)

        ' Add ProductName
        Dim lblName As New Label With {
            .Text = name,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleLeft,
            .Font = dataFont,
            .AutoSize = False,
            .Padding = New Padding(5, 0, 0, 0),
            .BackColor = Color.White
        }
        tblCart.Controls.Add(lblName, 1, rowIndex)

        ' Add Quantity
        Dim lblQty As New Label With {
            .Text = qty.ToString(),
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = dataFont,
            .AutoSize = False,
            .BackColor = Color.White
        }
        tblCart.Controls.Add(lblQty, 2, rowIndex)

        ' Add Price
        Dim lblPrice As New Label With {
            .Text = "₱" & price.ToString("N2"),
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleRight,
            .Font = dataFont,
            .AutoSize = False,
            .Padding = New Padding(0, 0, 5, 0),
            .BackColor = Color.White
        }
        tblCart.Controls.Add(lblPrice, 3, rowIndex)

        ' Add SubTotal
        Dim lblSubtotal As New Label With {
            .Text = "₱" & subtotal.ToString("N2"),
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleRight,
            .Font = dataFont,
            .AutoSize = False,
            .Padding = New Padding(0, 0, 5, 0),
            .BackColor = Color.White
        }
        tblCart.Controls.Add(lblSubtotal, 4, rowIndex)

        ' Update total
        TotalAmount += subtotal
        UpdateTotalDisplay()

        tblCart.ResumeLayout(True)

        ' Force refresh
        tblCart.Refresh()
    End Sub

    ' === UPDATE TOTAL DISPLAY ===
    Private Sub UpdateTotalDisplay()
        If lblTotal IsNot Nothing Then
            lblTotal.Text = "TOTAL: ₱" & TotalAmount.ToString("N2")
        End If
    End Sub

    ' === REMOVE ITEM ===
    Public Sub RemoveItem(rowIndex As Integer)
        ' Find the first row that has data (skip header rows)
        Dim firstDataRow As Integer = -1
        For r As Integer = 0 To tblCart.RowCount - 1
            Dim ctrl = tblCart.GetControlFromPosition(0, r)
            If ctrl IsNot Nothing AndAlso TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                ' If it's not a header (headers say "ProductID")
                If lbl.Text <> "ProductID" AndAlso IsNumeric(lbl.Text) Then
                    firstDataRow = r
                    Exit For
                End If
            End If
        Next

        If firstDataRow = -1 Then
            MessageBox.Show("No items to remove!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If rowIndex >= firstDataRow AndAlso rowIndex < tblCart.RowCount Then
            tblCart.SuspendLayout()

            ' Get subtotal from the row before removing
            Dim lblSubtotal As Label = CType(tblCart.GetControlFromPosition(4, rowIndex), Label)
            If lblSubtotal IsNot Nothing Then
                Dim subtotal As Decimal = Decimal.Parse(lblSubtotal.Text.Replace("₱", "").Replace(",", ""))
                TotalAmount -= subtotal
            End If

            ' Remove all controls in the row
            For c As Integer = 0 To 4
                Dim ctrl = tblCart.GetControlFromPosition(c, rowIndex)
                If ctrl IsNot Nothing Then
                    tblCart.Controls.Remove(ctrl)
                    ctrl.Dispose()
                End If
            Next

            ' Shift rows up
            For r As Integer = rowIndex + 1 To tblCart.RowCount - 1
                For c As Integer = 0 To 4
                    Dim ctrl = tblCart.GetControlFromPosition(c, r)
                    If ctrl IsNot Nothing Then
                        tblCart.SetRow(ctrl, r - 1)
                    End If
                Next
            Next

            ' Remove the row style and decrease count
            If tblCart.RowStyles.Count > 0 Then
                tblCart.RowStyles.RemoveAt(tblCart.RowCount - 1)
            End If
            tblCart.RowCount -= 1

            UpdateTotalDisplay()
            tblCart.ResumeLayout(True)
        End If
    End Sub

    ' === CANCEL TRANSACTION ===
    Public Sub CancelTransaction()
        tblCart.SuspendLayout()

        ' Find where data rows start (after headers)
        Dim firstDataRow As Integer = -1
        For r As Integer = 0 To tblCart.RowCount - 1
            Dim ctrl = tblCart.GetControlFromPosition(0, r)
            If ctrl IsNot Nothing AndAlso TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                If lbl.Text <> "ProductID" AndAlso IsNumeric(lbl.Text) Then
                    firstDataRow = r
                    Exit For
                End If
            End If
        Next

        ' Clear all data rows (keep headers)
        If firstDataRow >= 0 Then
            For r As Integer = tblCart.RowCount - 1 To firstDataRow Step -1
                For c As Integer = 0 To 4
                    Dim ctrl = tblCart.GetControlFromPosition(c, r)
                    If ctrl IsNot Nothing Then
                        tblCart.Controls.Remove(ctrl)
                        ctrl.Dispose()
                    End If
                Next
            Next

            ' Reset row count to just headers
            tblCart.RowCount = firstDataRow
            While tblCart.RowStyles.Count > firstDataRow
                tblCart.RowStyles.RemoveAt(tblCart.RowStyles.Count - 1)
            End While
        End If

        TotalAmount = 0
        UpdateTotalDisplay()

        If txtCashReceived IsNot Nothing Then
            txtCashReceived.Text = ""
        End If

        tblCart.ResumeLayout(True)
    End Sub

    ' === CONFIRM SALE ===
    Private Sub btnConfirmSale_Click(sender As Object, e As EventArgs) Handles btnConfirmSale.Click
        ' Count actual data rows (not header rows)
        Dim dataRowCount As Integer = 0
        For r As Integer = 0 To tblCart.RowCount - 1
            Dim ctrl = tblCart.GetControlFromPosition(0, r)
            If ctrl IsNot Nothing AndAlso TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                If lbl.Text <> "ProductID" AndAlso IsNumeric(lbl.Text) Then
                    dataRowCount += 1
                End If
            End If
        Next

        ' Check if cart is empty
        If dataRowCount = 0 Then
            MessageBox.Show("Cart is empty! Please add items first.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cashReceived As Decimal
        If Decimal.TryParse(txtCashReceived.Text, cashReceived) Then
            If cashReceived >= TotalAmount Then
                Dim change As Decimal = cashReceived - TotalAmount

                ' Update inventory and save transaction history
                For r As Integer = 0 To tblCart.RowCount - 1
                    Dim lblID As Label = CType(tblCart.GetControlFromPosition(0, r), Label)

                    ' Skip header rows
                    If lblID IsNot Nothing AndAlso lblID.Text <> "ProductID" AndAlso IsNumeric(lblID.Text) Then
                        Dim lblName As Label = CType(tblCart.GetControlFromPosition(1, r), Label)
                        Dim lblQty As Label = CType(tblCart.GetControlFromPosition(2, r), Label)
                        Dim lblPrice As Label = CType(tblCart.GetControlFromPosition(3, r), Label)
                        Dim lblSubtotal As Label = CType(tblCart.GetControlFromPosition(4, r), Label)

                        If lblName IsNot Nothing AndAlso lblQty IsNot Nothing AndAlso lblPrice IsNot Nothing AndAlso lblSubtotal IsNot Nothing Then
                            Dim productID As Integer = Integer.Parse(lblID.Text)
                            Dim qtySold As Integer = Integer.Parse(lblQty.Text)
                            Dim price As Decimal = Decimal.Parse(lblPrice.Text.Replace("₱", "").Replace(",", ""))
                            Dim subtotal As Decimal = Decimal.Parse(lblSubtotal.Text.Replace("₱", "").Replace(",", ""))

                            UpdateInventory(productID, qtySold)
                            SaveTransactionHistory(productID, lblName.Text, qtySold, price, subtotal)
                        End If
                    End If
                Next

                ' Show receipt
                Dim receiptForm As New ReceiptForm()
                receiptForm.LoadReceipt(tblCart, TotalAmount, cashReceived, change)
                receiptForm.ShowDialog()

                ' Clear cart
                CancelTransaction()
            Else
                MessageBox.Show("Insufficient cash!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter valid cash amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' === REMOVE ITEM BUTTON ===
    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        ' Find first data row
        For r As Integer = 0 To tblCart.RowCount - 1
            Dim ctrl = tblCart.GetControlFromPosition(0, r)
            If ctrl IsNot Nothing AndAlso TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                If lbl.Text <> "ProductID" AndAlso IsNumeric(lbl.Text) Then
                    RemoveItem(r)
                    Return
                End If
            End If
        Next
        MessageBox.Show("No items to remove!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' === CANCEL BUTTON ===
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Hide()

    End Sub

    ' === UPDATE INVENTORY ===
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

    ' === SAVE TRANSACTION HISTORY ===
    Private Sub SaveTransactionHistory(productID As Integer, name As String, qty As Integer, price As Decimal, subtotal As Decimal)
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                ' Assuming you have a transactions table
                Dim query As String = "INSERT INTO transactions (ProductID, ProductName, Quantity, Price, Subtotal, TransactionDate) VALUES (@id, @name, @qty, @price, @subtotal, @date)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", productID)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@qty", qty)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@subtotal", subtotal)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message)
        End Try
    End Sub
End Class