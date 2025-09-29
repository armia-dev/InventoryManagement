Imports MySql.Data.MySqlClient
Public Class AddForm
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=inventorymanagement")
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If String.IsNullOrWhiteSpace(NameTxt.Text) OrElse
           String.IsNullOrWhiteSpace(CategoryTxt.Text) OrElse
           String.IsNullOrWhiteSpace(QuantityTxt.Text) OrElse
           String.IsNullOrWhiteSpace(PriceTxt.Text) Then

            MessageBox.Show("Please fill all the blanks before adding a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' stop execution
        End If

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to insert product
            Dim query As String = "INSERT INTO Product (Name, Category, Quantity, Price) VALUES (@Name, @Category, @Quantity, @Price)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Pass values from textboxes
            cmd.Parameters.AddWithValue("@Name", NameTxt.Text)
            cmd.Parameters.AddWithValue("@Category", CategoryTxt.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(QuantityTxt.Text))
            cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(PriceTxt.Text))

            ' Execute query
            cmd.ExecuteNonQuery()

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields after adding
            NameTxt.Clear()
            CategoryTxt.Clear()
            QuantityTxt.Clear()
            PriceTxt.Clear()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
    Private Sub QuantityTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityTxt.KeyPress
        ' Allow only digits and control keys (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PriceTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTxt.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub


End Class