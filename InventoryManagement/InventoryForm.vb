Imports MySql.Data.MySqlClient
Public Class InventoryForm
    Dim con As New MySqlConnection("server=localhost;user id=root;password=;database=inventorymanagement;")

    Private Sub InvenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Using con As New MySqlConnection("server=localhost;user id=root;password=;database=inventorymanagement")
            Dim query As String = "select category from Product group by category"
            Using cmd As New MySqlCommand(query, con)
                con.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                CategoryBox.Items.Clear()
                CategoryBox.Items.Add("All")
                While reader.Read()
                    CategoryBox.Items.Add(reader("Category").ToString())
                End While
                con.Close()
            End Using
        End Using
        CategoryBox.SelectedIndex = 0
    End Sub

    Private Sub CategoryCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryBox.SelectedIndexChanged
        Dim query As String
        If CategoryBox.SelectedItem.ToString() = "All" Then
            query = "SELECT * FROM Product"
        Else
            query = "SELECT * FROM Product WHERE Category = @category"
        End If

        Using con As New MySqlConnection("server=localhost;user id=root;password=;database=inventorymanagement")
            Using cmd As New MySqlCommand(query, con)
                If CategoryBox.SelectedItem.ToString() <> "All" Then
                    cmd.Parameters.AddWithValue("@category", CategoryBox.SelectedItem.ToString())
                End If
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                ProductTable.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub LoadProducts()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM product"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            ProductTable.DataSource = table
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub
    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        Dim query As String = "SELECT * FROM Product WHERE Name LIKE @search OR Category LIKE @search"
        Using con As New MySqlConnection("server=localhost;user id=root;password=;database=inventorymanagement")
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@search", "%" & SearchTxt.Text & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                ProductTable.DataSource = dt
            End Using
        End Using
    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtns.Click
        Dim add As New AddForm
        add.Show()

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtns.Click
        If ProductTable.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = ProductTable.SelectedRows(0)

            Dim editForm As New EditForm()
            editForm.ProductID = Convert.ToInt32(row.Cells("Product_ID").Value)
            editForm.NameTxt.Text = row.Cells("Name").Value.ToString()
            editForm.CategoryTxt.Text = row.Cells("Category").Value.ToString()
            editForm.QuantityTxt.Text = row.Cells("Quantity").Value.ToString()
            editForm.PriceTxt.Text = row.Cells("Price").Value.ToString()

            editForm.ShowDialog()

            LoadProducts()
        Else
            MessageBox.Show("Please select a product to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtns.Click
        If ProductTable.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = ProductTable.SelectedRows(0)
            Dim productID As Integer = Convert.ToInt32(row.Cells("Product_ID").Value)

            If MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=inventorymanagement")
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM product WHERE Product_ID=@Product_ID"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Product_ID", productID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                    LoadProducts()
                End Try
            End If
        Else
            MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim bak As New MainMenuForm
        bak.Show()
        Me.Hide()
    End Sub
End Class