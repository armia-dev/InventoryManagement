Imports MySql.Data.MySqlClient

Public Class EditForm

    Public Property ProductID As Integer


    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=inventorymanagement")

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

        If String.IsNullOrWhiteSpace(NameTxt.Text) OrElse
           String.IsNullOrWhiteSpace(CategoryTxt.Text) OrElse
           String.IsNullOrWhiteSpace(QuantityTxt.Text) OrElse
           String.IsNullOrWhiteSpace(PriceTxt.Text) Then

            MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE product 
                                   SET Name=@name, Category=@category, Quantity=@quantity, Price=@price 
                                   WHERE Product_ID=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", NameTxt.Text)
                cmd.Parameters.AddWithValue("@category", CategoryTxt.Text)
                cmd.Parameters.AddWithValue("@quantity", QuantityTxt.Text)
                cmd.Parameters.AddWithValue("@price", PriceTxt.Text)
                cmd.Parameters.AddWithValue("@id", ProductID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub


    Private Sub QuantityTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityTxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub PriceTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If


        If e.KeyChar = "."c AndAlso PriceTxt.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class