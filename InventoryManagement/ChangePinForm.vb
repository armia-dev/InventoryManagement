Imports MySql.Data.MySqlClient

Public Class ChangePinForm
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=InventoryManagement;")

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click

        If OldPinTxt.Text.Length <> 4 OrElse Not IsNumeric(OldPinTxt.Text) Then
            MessageBox.Show("Old PIN must be 4 digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If OldPinTxt.Text = NewPinTxt.Text Then
            MessageBox.Show("New PIN cannot be the same as the Old PIN.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM pincode WHERE pin_code=@oldPin"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@oldPin", OldPinTxt.Text)

            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count = 0 Then
                MessageBox.Show("Old PIN is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Return
            End If

            Dim query As String = "UPDATE pincode SET pin_code=@newPin WHERE pin_code=@oldPin"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@newPin", NewPinTxt.Text)
            cmd.Parameters.AddWithValue("@oldPin", OldPinTxt.Text)

            Dim rows As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If rows > 0 Then
                MessageBox.Show("PIN changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim log As New LoginForm
                log.Show()
                Me.Hide()
            Else
                MessageBox.Show("Failed to change PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Oldpin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OldPinTxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        OldPinTxt.MaxLength = 4
        OldPinTxt.PasswordChar = "*"c
    End Sub

    Private Sub NewPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPinTxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        NewPinTxt.MaxLength = 4
        NewPinTxt.PasswordChar = "*"c
    End Sub

End Class