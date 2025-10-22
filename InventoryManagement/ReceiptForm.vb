Imports System.Data.SqlTypes

Public Class ReceiptForm
    Public Sub LoadReceipt(cart As TableLayoutPanel, total As Decimal, cash As Decimal, change As Decimal)
        tblReceipt.Controls.Clear()
        tblReceipt.RowCount = cart.RowCount
        For r As Integer = 0 To cart.RowCount - 1
            tblReceipt.RowStyles.Add(New RowStyle(SizeType.Absolute, 25))
            For c As Integer = 0 To 4
                Dim lbl As New Label() With {
                    .Text = cart.GetControlFromPosition(c, r).Text,
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleRight
                }
                If c = 1 Then lbl.TextAlign = ContentAlignment.MiddleLeft
                If c = 2 Then lbl.TextAlign = ContentAlignment.MiddleCenter
                tblReceipt.Controls.Add(lbl, c, r)
            Next
        Next
        lblTotal.Text = "TOTAL: ₱" & total.ToString("N2")
        lblCash.Text = "CASH: ₱" & cash.ToString("N2")
        lblChange.Text = "CHANGE: ₱" & change.ToString("N2")
        lblDateTime.Text = "DATE/TIME: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub


End Class