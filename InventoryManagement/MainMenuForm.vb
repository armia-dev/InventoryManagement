Public Class MainMenuForm
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim log As New LoginForm
        log.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryBtn_Click(sender As Object, e As EventArgs) Handles InventoryBtn.Click

        panelMain.Controls.Clear() ' Clear whatever is currently inside
        Dim inventory As New InventoryControl() ' Create instance of your UserControl
        inventory.Dock = DockStyle.Fill ' Make it fill the panel area
        panelMain.Controls.Add(inventory) ' Add it to the panel

    End Sub

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint

    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        panelMain.Controls.Clear() ' Clear whatever is currently inside
        Dim checkout As New CheckControl()
        checkout.Dock = DockStyle.Fill ' Make it fill the panel area
        panelMain.Controls.Add(checkout)
    End Sub

    Private Sub CheckProPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class