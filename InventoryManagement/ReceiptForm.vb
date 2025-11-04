Imports MySql.Data.MySqlClient

Public Class ReceiptForm

    Private ConnectionString As String = "server=127.0.0.1;port=3306;user id=root;password=;database=inventorymanagement"

    Public Sub LoadReceiptFromDB(total As Decimal, cash As Decimal, change As Decimal)
        Try
            ' Clear previous data
            tblReceipt.Controls.Clear()
            tblReceipt.RowStyles.Clear()
            tblReceipt.RowCount = 0

            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()

                ' ✅ Fetch recent transactions
                Dim query As String = "
                    SELECT ProductID, ProductName, Quantity, Price, Subtotal
                    FROM transactions
                    ORDER BY TransactionDate DESC
                    LIMIT 20"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim row As Integer = 0

                        While reader.Read()
                            tblReceipt.RowCount += 1
                            tblReceipt.RowStyles.Add(New RowStyle(SizeType.Absolute, 25))

                            ' === ProductID ===
                            Dim lblID As New Label() With {
                                .Text = reader("ProductID").ToString(),
                                .Dock = DockStyle.Fill,
                                .TextAlign = ContentAlignment.MiddleCenter
                            }
                            tblReceipt.Controls.Add(lblID, 0, row)

                            ' === ProductName ===
                            Dim lblName As New Label() With {
                                .Text = reader("ProductName").ToString(),
                                .Dock = DockStyle.Fill,
                                .TextAlign = ContentAlignment.MiddleLeft
                            }
                            tblReceipt.Controls.Add(lblName, 1, row)

                            ' === Quantity ===
                            Dim lblQty As New Label() With {
                                .Text = reader("Quantity").ToString(),
                                .Dock = DockStyle.Fill,
                                .TextAlign = ContentAlignment.MiddleCenter
                            }
                            tblReceipt.Controls.Add(lblQty, 2, row)

                            ' === Price ===
                            Dim lblPrice As New Label() With {
                                .Text = "₱" & Convert.ToDecimal(reader("Price")).ToString("N2"),
                                .Dock = DockStyle.Fill,
                                .TextAlign = ContentAlignment.MiddleRight
                            }
                            tblReceipt.Controls.Add(lblPrice, 3, row)

                            ' === Subtotal ===
                            Dim lblSub As New Label() With {
                                .Text = "₱" & Convert.ToDecimal(reader("Subtotal")).ToString("N2"),
                                .Dock = DockStyle.Fill,
                                .TextAlign = ContentAlignment.MiddleRight
                            }
                            tblReceipt.Controls.Add(lblSub, 4, row)

                            row += 1
                        End While
                    End Using
                End Using
            End Using

            ' === Display totals and time ===
            lblTotal.Text = "Total: ₱" & total.ToString("N2")
            lblCash.Text = "Receive Cash: ₱" & cash.ToString("N2")
            lblChange.Text = "Change: ₱" & change.ToString("N2")
            lblDateTime.Text = "Date and Time: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Catch ex As Exception
            MessageBox.Show("Error loading receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
