Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class HistoryCtrl
    Private SelectedTransactionID As Integer = -1
    Private isSyncingDates As Boolean = False

    Private Sub HistoryCtrlForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default 2-month range
        dtpTo.Value = DateTime.Today
        dtpFrom.Value = DateTime.Today.AddMonths(-2)
        SetupViewButton()
        LoadTransactions()
    End Sub

    ' === STYLE THE VIEW BUTTON ===
    Private Sub SetupViewButton()
        btnView.Text = "View Receipt"
        btnView.BackColor = Color.FromArgb(60, 120, 210)
        btnView.ForeColor = Color.White
        btnView.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnView.FlatStyle = FlatStyle.Flat
        btnView.FlatAppearance.BorderSize = 0
        btnView.Cursor = Cursors.Hand
    End Sub

    ' === LOAD TRANSACTIONS BETWEEN DATE RANGE ===
    Private Sub LoadTransactions()
        TableLayoutPanel1.SuspendLayout()

        ' Reset table
        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.RowStyles.Clear()
        TableLayoutPanel1.RowCount = 0
        TableLayoutPanel1.AutoScroll = True
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.Padding = New Padding(0)
        TableLayoutPanel1.Margin = New Padding(0)

        ' Define 4 equal columns
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Clear()
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' Transaction ID
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' Date/Time
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' Total
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25)) ' Cashier

        Try
            Dim connStr As String = "server=localhost;user=root;password=;database=inventorymanagement"
            Using con As New MySqlConnection(connStr)
                con.Open()

                Dim query As String = "
                    SELECT 
                        TransactionID, 
                        MAX(`Date&Time`) AS DateTime,
                        SUM(Subtotal) AS Total,
                        user AS Cashier
                    FROM transactions
                    WHERE `Date&Time` BETWEEN @from AND @to
                    GROUP BY TransactionID, user
                    ORDER BY DateTime DESC;
                "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1))

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Header Row
                        AddRow("Transaction ID", "Date/Time", "Total", "Cashier",
                               New Font("Segoe UI Semibold", 10, FontStyle.Bold),
                               Color.FromArgb(225, 230, 240), True)

                        ' Data Rows
                        Dim rowIndex As Integer = 0
                        While reader.Read()
                            Dim id As Integer = reader("TransactionID")
                            Dim dt As String = Convert.ToDateTime(reader("DateTime")).ToString("yyyy-MM-dd HH:mm:ss")
                            Dim total As Decimal = Convert.ToDecimal(reader("Total"))
                            Dim cashier As String = reader("Cashier").ToString()

                            Dim bgColor As Color = If(rowIndex Mod 2 = 0, Color.White, Color.FromArgb(245, 247, 250))

                            AddRow(id.ToString(), dt, "₱" & total.ToString("N2"), cashier,
                                   New Font("Segoe UI", 10, FontStyle.Regular), bgColor, False, id)
                            rowIndex += 1
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TableLayoutPanel1.ResumeLayout()
    End Sub

    ' === ADD ROW TO TABLE ===
    Private Sub AddRow(c1 As String, c2 As String, c3 As String, c4 As String,
                       font As Font, bg As Color, Optional isHeader As Boolean = False, Optional transId As Integer = -1)

        Dim rowIndex As Integer = TableLayoutPanel1.RowCount
        TableLayoutPanel1.RowCount += 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 38)) ' uniform height

        Dim labels = {
            CreateCell(c1, ContentAlignment.MiddleCenter, font, bg, transId, isHeader),
            CreateCell(c2, ContentAlignment.MiddleCenter, font, bg, transId, isHeader),
            CreateCell(c3, ContentAlignment.MiddleRight, font, bg, transId, isHeader),
            CreateCell(c4, ContentAlignment.MiddleCenter, font, bg, transId, isHeader)
        }

        For i As Integer = 0 To 3
            labels(i).Margin = New Padding(0)
            labels(i).Dock = DockStyle.Top
            TableLayoutPanel1.Controls.Add(labels(i), i, rowIndex)
        Next
    End Sub

    ' === CREATE INDIVIDUAL CELL ===
    Private Function CreateCell(text As String, align As ContentAlignment, font As Font, bg As Color,
                                transId As Integer, isHeader As Boolean) As Label
        Dim lbl As New Label With {
            .Text = text,
            .Font = font,
            .BackColor = bg,
            .TextAlign = align,
            .Dock = DockStyle.Fill,
            .AutoSize = False,
            .Margin = New Padding(0),
            .Padding = New Padding(5, 0, 5, 0),
            .ForeColor = If(isHeader, Color.Black, Color.FromArgb(40, 40, 40))
        }

        If Not isHeader AndAlso transId > 0 Then
            lbl.Cursor = Cursors.Hand
            lbl.Tag = transId
            AddHandler lbl.Click, AddressOf Row_Click
        End If

        Return lbl
    End Function

    ' === HANDLE ROW CLICK ===
    Private Sub Row_Click(sender As Object, e As EventArgs)
        Dim lbl As Label = CType(sender, Label)
        Dim id As Integer = CInt(lbl.Tag)

        If SelectedTransactionID = id Then
            SelectedTransactionID = -1
            ResetRowColors()
        Else
            SelectedTransactionID = id
            HighlightSelectedRow(id)
        End If
    End Sub

    Private Sub ResetRowColors()
        Dim evenColor As Color = Color.White
        Dim oddColor As Color = Color.FromArgb(245, 247, 250)
        Dim rowIndex As Integer = 0
        Dim currentTransId As Integer = -1

        ' recolor rows neatly after deselection
        For Each ctrl As Control In TableLayoutPanel1.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Tag IsNot Nothing AndAlso ctrl.Tag <> -1 Then
                Dim transId As Integer = CInt(ctrl.Tag)
                If transId <> currentTransId Then
                    rowIndex += 1
                    currentTransId = transId
                End If
                ctrl.BackColor = If(rowIndex Mod 2 = 0, evenColor, oddColor)
            End If
        Next
    End Sub

    Private Sub HighlightSelectedRow(id As Integer)
        ResetRowColors()
        For Each ctrl As Control In TableLayoutPanel1.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Tag IsNot Nothing AndAlso ctrl.Tag = id Then
                ctrl.BackColor = Color.FromArgb(173, 216, 230)
            End If
        Next
    End Sub

    ' === VIEW BUTTON CLICK ===
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If SelectedTransactionID = -1 Then
            MessageBox.Show("Please select a transaction to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        TransID = SelectedTransactionID
        ReceiptForm.Show()
    End Sub

    ' === DATE PICKER SYNC & FILTER ===
    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        If isSyncingDates Then Exit Sub
        isSyncingDates = True

        dtpTo.Value = dtpFrom.Value.AddMonths(2)
        If dtpTo.Value > DateTime.Today Then dtpTo.Value = DateTime.Today

        isSyncingDates = False
        LoadTransactions()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        If isSyncingDates Then Exit Sub
        isSyncingDates = True

        dtpFrom.Value = dtpTo.Value.AddMonths(-2)
        isSyncingDates = False
        LoadTransactions()
    End Sub
End Class
