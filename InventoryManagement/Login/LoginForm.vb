Imports MySql.Data.MySqlClient
Public Class LoginForm
    ' MySQL Connection
    Private conn As New MySqlConnection("server=localhost;user id=root;password=;database=InventoryManagement;")
    ' 🔹 LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim pinCode As String = txtPassword.Text.Trim()
        ' Validate input
        If username = "" OrElse pinCode = "" Then
            MessageBox.Show("Please enter both Username and Password (PIN).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            conn.Open()
            ' Query user and role
            Dim query As String = "SELECT role FROM users WHERE username=@username AND pin_code=@pin"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@pin", pinCode)
            Dim role As Object = cmd.ExecuteScalar()
            conn.Close()
            ' Role-based access validation
            If role IsNot Nothing Then
                Select Case role.ToString().ToLower()
                    Case "admin"
                        ' ✅ Store username and role globally
                        LoggedInUsername = username
                        LoggedInRole = "Admin"

                        MessageBox.Show("Welcome, " & username & " (Admin)!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim adminMenu As New MainMenuForm
                        adminMenu.Show()
                        Me.Hide()

                    Case "staff"
                        MessageBox.Show("Access Denied! Staff accounts cannot log in under Admin Access.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Case Else
                        MessageBox.Show("Unknown role detected.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ' 🔹 PASSWORD FIELD (4-digit PIN)
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        txtPassword.MaxLength = 4
    End Sub
    ' 🔹 FORM LOAD
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Username visible, password hidden
        txtUsername.UseSystemPasswordChar = False
        txtPassword.PasswordChar = "●"c
        Me.StartPosition = FormStartPosition.CenterScreen ' ✅ Center form on screen
    End Sub
    ' 🔹 CHANGE PIN LINK
    Private Sub lnkChangePin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkChangePin.LinkClicked
        Dim changePin As New ChangePinForm
        changePin.Show()
        Me.Hide()
    End Sub
    ' 🔹 SWITCH TO STAFF LOGIN LINK
    Private Sub lnkSwitchStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSwitchStaff.LinkClicked
        Dim staffForm As New StaffLogin
        staffForm.StartPosition = FormStartPosition.CenterScreen ' ✅ Make staff login centered
        staffForm.Show()
        Me.Hide()
    End Sub
End Class