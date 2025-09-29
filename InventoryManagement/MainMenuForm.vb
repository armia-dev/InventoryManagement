Public Class MainMenuForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

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


End Class