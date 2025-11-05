Public Class MainMenuForm

    ' Store the last clicked navigation button
    Private lastClickedButton As Button = Nothing

    ' 🔹 LOGOUT BUTTON
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim log As New LoginForm
        log.Show()
        Me.Hide()
    End Sub

    ' 🔹 INVENTORY BUTTON
    Private Sub InventoryBtn_Click(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        panelMain.Controls.Clear() ' Clear the current content
        Dim inventory As New InventoryControl()
        inventory.Dock = DockStyle.Fill
        panelMain.Controls.Add(inventory)

        panelDescription.Controls.Clear()
        Dim Invent As New InventoryTabs()
        Invent.Dock = DockStyle.Left
        panelDescription.Controls.Add(Invent)

    End Sub

    ' 🔹 SALES / CHECKOUT BUTTON
    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        panelMain.Controls.Clear()
        Dim checkout As New CheckControl()
        checkout.Dock = DockStyle.Fill
        panelMain.Controls.Add(checkout)

        panelDescription.Controls.Clear()
        Dim check As New CheckoutTabs()
        check.Dock = DockStyle.Left
        panelDescription.Controls.Add(check)

    End Sub

    ' 🔹 DASHBOARD BUTTON
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        panelMain.Controls.Clear()
        Dim dashboard As New Dashboard()
        dashboard.Dock = DockStyle.Fill
        panelMain.Controls.Add(dashboard)

        panelDescription.Controls.Clear()
        Dim Dash As New DashboardTabs()
        Dash.Dock = DockStyle.Left
        panelDescription.Controls.Add(Dash)


    End Sub


    ' 🔹 TRANSACTION HISTORY BUTTON
    Private Sub btnTransac_Click(sender As Object, e As EventArgs) Handles btnTransac.Click
        panelMain.Controls.Clear()
        Dim dashboard As New HistoryCtrl()
        dashboard.Dock = DockStyle.Fill
        panelMain.Controls.Add(dashboard)

        panelDescription.Controls.Clear()
        Dim Transac As New TransactionTabs()
        Transac.Dock = DockStyle.Left
        panelDescription.Controls.Add(Transac)
    End Sub

    ' 🔹 Highlight the last clicked button
    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles SalesBtn.Click, InventoryBtn.Click, Dashboard.Click, btnTransac.Click

        Dim clickedButton As Button = CType(sender, Button)

        ' Reset the color of the last clicked button
        If lastClickedButton IsNot Nothing Then
            lastClickedButton.BackColor = Color.FromArgb(109, 148, 197)
            lastClickedButton.ForeColor = Color.Black
        End If

        ' Highlight the clicked button
        clickedButton.BackColor = Color.FromArgb(203, 220, 235)
        clickedButton.ForeColor = Color.Black

        lastClickedButton = clickedButton
    End Sub

    ' 🔹 MAXIMIZE BUTTON
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    ' 🔹 MINIMIZE BUTTON
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' 🔹 IGNORE (you can remove if unused)
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint
    End Sub

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        panelMain.Controls.Clear()
        Dim dashboard As New Dashboard()
        dashboard.Dock = DockStyle.Fill
        panelMain.Controls.Add(dashboard)

        If LoggedInRole = "Admin" Then
            InventoryBtn.Visible = True
            btnTransac.Visible = True
        Else
            InventoryBtn.Visible = False
            btnTransac.Visible = False
        End If


    End Sub
End Class
