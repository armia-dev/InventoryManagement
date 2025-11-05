Imports MySql.Data.MySqlClient

Public Class AddEditForm
    Public Property Mode As String ' "Add" or "Edit"
    Public Property ProductID As Integer

    Private Sub AddEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        If Mode = "Edit" Then
            LoadProductData()
        End If
    End Sub

    ' === LOAD CATEGORIES INTO COMBOBOX ===
    Private Sub LoadCategories()
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT DISTINCT Category FROM products ORDER BY Category ASC"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbCategory.Items.Clear()
                        While reader.Read()
                            cmbCategory.Items.Add(reader("Category").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    ' === LOAD EXISTING PRODUCT DATA WHEN EDITING ===
    Private Sub LoadProductData()
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT Name, Category, Quantity, Price FROM products WHERE ProductID = @id"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", ProductID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtName.Text = reader("Name").ToString()
                            cmbCategory.Text = reader("Category").ToString()
                            txtQuantity.Text = reader("Quantity").ToString()
                            txtPrice.Text = reader("Price").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading product: " & ex.Message)
        End Try
    End Sub

    ' === SAVE BUTTON CLICK ===
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Mode = "Add" Then
            AddProduct()
        ElseIf Mode = "Edit" Then
            UpdateProduct()
        End If
    End Sub

    ' === ADD NEW PRODUCT ===
    Private Sub AddProduct()
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' 🔍 Check for duplicate product name
                Dim checkQuery As String = "SELECT COUNT(*) FROM products WHERE Name = @name"
                Using checkCmd As New MySqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        MessageBox.Show("A product with this name already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' ✅ If no duplicate found, continue to insert
                Dim query As String = "INSERT INTO products (Name, Category, Quantity, Price) VALUES (@name, @category, @quantity, @price)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub

    ' === UPDATE EXISTING PRODUCT ===
    Private Sub UpdateProduct()
        Try
            Dim connectionString As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connectionString)
                con.Open()

                ' 🔍 Check for duplicate name (excluding current product)
                Dim checkQuery As String = "SELECT COUNT(*) FROM products WHERE Name = @name AND ProductID <> @id"
                Using checkCmd As New MySqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@id", ProductID)
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        MessageBox.Show("A product with this name already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' ✅ If unique, update product
                Dim query As String = "UPDATE products SET Name=@name, Category=@category, Quantity=@quantity, Price=@price WHERE ProductID=@id"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
                    cmd.Parameters.AddWithValue("@id", ProductID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
        End Try
    End Sub

    ' === CANCEL BUTTON ===
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class