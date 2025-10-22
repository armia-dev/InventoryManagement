Imports System.Windows.Forms

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

        ' Validate quantity input
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