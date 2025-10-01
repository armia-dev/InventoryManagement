Public Class MainMenuForm
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim log As New LoginForm
        log.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryBtn_Click(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        Dim inv As New InventoryForm
        inv.Show()
        Me.Hide()
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        Dim sal As New SalesForm
        sal.Show()
        Me.Hide()
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        Dim Rep As New SalesReportForm
        Rep.Show()
        Me.Hide()
    End Sub
End Class