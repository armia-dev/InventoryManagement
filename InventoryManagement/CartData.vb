Module CartData
    Public CartItems As New List(Of CartItem)
End Module

Public Class CartItem
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal
End Class
