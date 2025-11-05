Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class ReceiptForm
    Private ScrollPanel As Panel

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTableScrollable()
        SetupTable()
        LoadReceiptData()
    End Sub

    ' === Wrap only tblReceipt inside a scrollable panel ===
    Private Sub MakeTableScrollable()
        ' Create a panel to hold the table
        ScrollPanel = New Panel With {
            .AutoScroll = True,
            .Dock = DockStyle.Top,
            .Height = 250, ' Adjust the visible height for your table
            .BorderStyle = BorderStyle.FixedSingle
        }

        ' Remove the table from its current parent (Designer container)
        If tblReceipt.Parent IsNot Nothing Then
            tblReceipt.Parent.Controls.Remove(tblReceipt)
        End If

        ' Configure tblReceipt appearance
        tblReceipt.Dock = DockStyle.Top
        tblReceipt.AutoSize = True
        tblReceipt.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tblReceipt.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tblReceipt.BackColor = Color.White
        tblReceipt.ColumnCount = 4
        tblReceipt.ColumnStyles.Clear()
        tblReceipt.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' ProductName
        tblReceipt.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' Quantity
        tblReceipt.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' Price
        tblReceipt.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' SubTotal

        ' Add the table inside the scroll panel
        ScrollPanel.Controls.Add(tblReceipt)

        ' Add the panel above the labels
        Me.Controls.Add(ScrollPanel)
        ScrollPanel.BringToFront()
    End Sub

    ' === Create table header ===
    Private Sub SetupTable()
        tblReceipt.Controls.Clear()
        tblReceipt.RowStyles.Clear()
        tblReceipt.RowCount = 0

        Dim headerFont As New Font("Segoe UI Semibold", 10, FontStyle.Bold)
        Dim headers() As String = {"Product Name", "Quantity", "Price", "Subtotal"}

        For i As Integer = 0 To headers.Length - 1
            Dim lblHeader As New Label With {
                .Text = headers(i),
                .Dock = DockStyle.Fill,
                .Font = headerFont,
                .TextAlign = ContentAlignment.MiddleCenter,
                .BackColor = Color.FromArgb(48, 128, 185),
                .ForeColor = Color.White,
                .Padding = New Padding(3)
            }
            tblReceipt.Controls.Add(lblHeader, i, 0)
        Next

        tblReceipt.RowCount = 1
    End Sub

    ' === Load data from transactions table ===
    Private Sub LoadReceiptData()
        Dim connStr As String = "server=localhost;user=root;password=;database=inventorymanagement"

        Try
            Using con As New MySqlConnection(connStr)
                con.Open()

                ' Load transaction details for labels
                Dim transQuery As String = "
                    SELECT `Date&Time`, user, Total_Amount, Cash_Received, Change_Amount
                    FROM transactions
                    WHERE TransactionID = @id
                    LIMIT 1"
                Using transCmd As New MySqlCommand(transQuery, con)
                    transCmd.Parameters.AddWithValue("@id", TransID)
                    Using reader As MySqlDataReader = transCmd.ExecuteReader()
                        If reader.Read() Then
                            lblTransacID.Text = "Transaction ID: " & TransID.ToString()
                            lblDateTime.Text = "Date & Time: " & Convert.ToDateTime(reader("Date&Time")).ToString("yyyy-MM-dd HH:mm:ss")
                            lblCashier.Text = "Cashier: " & reader("user").ToString()
                            lblTotal.Text = "Total: ₱" & Convert.ToDecimal(reader("Total_Amount")).ToString("N2")
                            lblCash.Text = "Cash: ₱" & Convert.ToDecimal(reader("Cash_Received")).ToString("N2")
                            lblChange.Text = "Change: ₱" & Convert.ToDecimal(reader("Change_Amount")).ToString("N2")
                        End If
                    End Using
                End Using

                ' Load only the items with the same TransactionID
                Dim itemsQuery As String = "
                    SELECT ProductName, Quantity, Price, SubTotal
                    FROM transactions
                    WHERE TransactionID = @id"
                Using itemsCmd As New MySqlCommand(itemsQuery, con)
                    itemsCmd.Parameters.AddWithValue("@id", TransID)
                    Using reader As MySqlDataReader = itemsCmd.ExecuteReader()
                        Dim rowIndex As Integer = 1
                        Dim dataFont As New Font("Segoe UI", 10, FontStyle.Regular)

                        While reader.Read()
                            tblReceipt.RowCount += 1
                            tblReceipt.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                            Dim bgColor As Color = If(rowIndex Mod 2 = 0, Color.White, Color.FromArgb(245, 247, 250))

                            Dim createLabel = Function(text As String, align As ContentAlignment) As Label
                                                  Return New Label With {
                                                      .Text = text,
                                                      .Dock = DockStyle.Fill,
                                                      .Font = dataFont,
                                                      .TextAlign = align,
                                                      .BackColor = bgColor,
                                                      .AutoSize = False,
                                                      .Margin = New Padding(0),
                                                      .Padding = New Padding(3)
                                                  }
                                              End Function

                            tblReceipt.Controls.Add(createLabel(reader("ProductName").ToString(), ContentAlignment.MiddleLeft), 0, rowIndex)
                            tblReceipt.Controls.Add(createLabel(reader("Quantity").ToString(), ContentAlignment.MiddleCenter), 1, rowIndex)
                            tblReceipt.Controls.Add(createLabel("₱" & Convert.ToDecimal(reader("Price")).ToString("N2"), ContentAlignment.MiddleRight), 2, rowIndex)
                            tblReceipt.Controls.Add(createLabel("₱" & Convert.ToDecimal(reader("SubTotal")).ToString("N2"), ContentAlignment.MiddleRight), 3, rowIndex)

                            rowIndex += 1
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
