Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class AddToCartControl
    Inherits Form

    ' === Public properties ===
    Public Property Category As String
    Public Property Price As Decimal
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property MaxStock As Integer
    Public Property IsConfirmed As Boolean = False
    Public Property EnteredQty As Integer

    Private Sub AddToCartControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === Display product details ===
        lblPrompt.Text = $"Product: {ProductName}" & vbCrLf &
                         $"Price: ₱{Price.ToString("N2")}" & vbCrLf &
                         $"Stock Available: {MaxStock}"
        txtQty.Text = "1"
        txtQty.SelectAll()
        txtQty.Focus()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim qty As Integer

        ' Validate quantity input first
        If Not Integer.TryParse(txtQty.Text.Trim(), qty) OrElse qty <= 0 Then
            MessageBox.Show("Please enter a valid quantity (numbers only).", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQty.Focus()
            Return
        End If

        ' Check stock availability
        If qty > MaxStock Then
            MessageBox.Show($"Not enough stock available! Only {MaxStock} units in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQty.Focus()
            Return
        End If

        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' 🔹 Fetch product details
                Dim query As String = "SELECT ProductId, Name, Category, Price FROM products WHERE Name = @ProductName"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ProductName", ProductName)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim productId As Integer = Convert.ToInt32(reader("ProductId"))
                            Dim name As String = reader("Name").ToString()
                            Dim category As String = reader("Category").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                            reader.Close()

                            ' ✅ Check if product already exists in cart
                            Dim checkQuery As String = "SELECT Quantity FROM cart WHERE ProductId = @ProductId"
                            Using checkCmd As New MySqlCommand(checkQuery, con)
                                checkCmd.Parameters.AddWithValue("@ProductId", productId)
                                Dim existingQty As Object = checkCmd.ExecuteScalar()

                                If existingQty IsNot Nothing Then
                                    ' Product exists - check if new total exceeds stock
                                    Dim currentCartQty As Integer = Convert.ToInt32(existingQty)
                                    Dim newTotalQty As Integer = currentCartQty + qty

                                    If newTotalQty > MaxStock Then
                                        MessageBox.Show($"Cannot add {qty} more units. You already have {currentCartQty} in cart. Maximum available: {MaxStock}", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Return
                                    End If

                                    ' ✅ Update existing cart item
                                    Dim updateQuery As String = "UPDATE cart SET Quantity = Quantity + @Quantity WHERE ProductId = @ProductId"
                                    Using updateCmd As New MySqlCommand(updateQuery, con)
                                        updateCmd.Parameters.AddWithValue("@Quantity", qty)
                                        updateCmd.Parameters.AddWithValue("@ProductId", productId)
                                        updateCmd.ExecuteNonQuery()
                                    End Using

                                    MessageBox.Show($"Updated cart! Added {qty} more units. Total in cart: {newTotalQty}", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    ' ✅ Insert new cart item
                                    Dim insertQuery As String = "INSERT INTO cart (ProductId, Name, Category, Quantity, Price) VALUES (@ProductId, @Name, @Category, @Quantity, @Price)"
                                    Using insertCmd As New MySqlCommand(insertQuery, con)
                                        insertCmd.Parameters.AddWithValue("@ProductId", productId)
                                        insertCmd.Parameters.AddWithValue("@Name", name)
                                        insertCmd.Parameters.AddWithValue("@Category", category)
                                        insertCmd.Parameters.AddWithValue("@Quantity", qty)
                                        insertCmd.Parameters.AddWithValue("@Price", price)
                                        insertCmd.ExecuteNonQuery()
                                    End Using

                                    MessageBox.Show("Product added to cart successfully!")
                                End If
                            End Using
                        Else
                            MessageBox.Show("Product not found.")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        ' All validation passed - save quantity and confirm
        EnteredQty = qty
        IsConfirmed = True

        ' Close the dialog
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        IsConfirmed = False
        Me.Close()
    End Sub

    ' === Prevent letters/symbols — allow only digits and Backspace ===
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' === Press Enter to confirm, Escape to cancel ===
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            btnOK.PerformClick()
            Return True
        ElseIf keyData = Keys.Escape Then
            btnCancel.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
