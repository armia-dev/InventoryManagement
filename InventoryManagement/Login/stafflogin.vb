Imports MySql.Data.MySqlClient
Public Class StaffLogin
    ' MySQL Connection
    Private conn As New MySqlConnection("server=localhost;user id=root;password=;database=InventoryManagement;")
    ' 🔹 LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim pinCode As String = txtPassword.Text.Trim()
        If username = "" OrElse pinCode = "" Then
            MessageBox.Show("Please enter both Username and Password (PIN).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            conn.Open()
            ' Check user and role
            Dim query As String = "SELECT role FROM users WHERE username=@username AND pin_code=@pin"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@pin", pinCode)
            Dim role As Object = cmd.ExecuteScalar()
            conn.Close()
            If role IsNot Nothing Then
                Select Case role.ToString().ToLower()
                    Case "staff"
                        ' ✅ Store username and role globally
                        LoggedInUsername = username
                        LoggedInRole = "Staff"

                        MessageBox.Show("Welcome, " & username & " (Staff)!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim staffMenu As New MainMenuForm
                        staffMenu.StartPosition = FormStartPosition.CenterScreen ' ✅ Centered form
                        staffMenu.Show()
                        Me.Hide()

                    Case "admin"
                        MessageBox.Show("Access Denied! Admins cannot log in using the Staff portal.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Case Else
                        MessageBox.Show("Unknown role detected. Contact system administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                MessageBox.Show("Invalid Username or Password (PIN). Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    ' 🔹 EXIT BUTTON
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    ' 🔹 PASSWORD FIELD
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        txtPassword.MaxLength = 4
    End Sub
    ' 🔹 FORM LOAD (Center on Screen)
    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        txtUsername.UseSystemPasswordChar = False
        txtPassword.PasswordChar = "●"c
    End Sub
    ' 🔹 SWITCH BACK TO ADMIN LOGIN
    Private Sub lnkSwitchAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSwitchAdmin.LinkClicked
        Dim adminForm As New LoginForm
        adminForm.StartPosition = FormStartPosition.CenterScreen
        adminForm.Show()
        Me.Hide()
    End Sub
End Class