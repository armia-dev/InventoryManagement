Public Class InventoryForm
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim bak As New MainMenuForm
        bak.Show()
        Me.Hide()
    End Sub

    Private Sub AddBtns_Click(sender As Object, e As EventArgs) Handles AddBtns.Click
        Dim add As New AddForm
        add.Show()

    End Sub

    Private Sub EditBtns_Click(sender As Object, e As EventArgs) Handles EditBtns.Click
        Dim edit As New EditForm
        edit.Show()

    End Sub


End Class

