Public Class SalesForm
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddCartBtn.Click
        Dim sel As New SelectQuantityForm
        sel.Show()

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim bak As New MainMenuForm
        bak.Show()
        Me.Hide()
    End Sub
End Class