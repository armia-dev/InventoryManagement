Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=InventoryManagement;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ChngPin.LinkClicked
        Dim cng As New ChangePinForm
        cng.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Entr.Click
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM pincode WHERE pin_code=@pin"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@pin", PinCode.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()

            If count > 0 AndAlso PinCode.Text.Length = 4 Then
                Dim dash As New MainMenuForm
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid PIN. Try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PinCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PinCode.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        PinCode.MaxLength = 4
        PinCode.PasswordChar = "*"c
    End Sub
End Class