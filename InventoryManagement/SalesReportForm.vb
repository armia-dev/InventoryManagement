Public Class SalesReportForm
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim bak As New MainMenuForm
        bak.Show()
        Me.Hide()
    End Sub
End Class