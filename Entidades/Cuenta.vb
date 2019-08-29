Public Class Cuenta
    Public Property Numero As Integer
    Public Property Balance As Decimal
    Public Sub Depositar(value As Decimal)
        _Balance += value
    End Sub
    Public Function Extraer(value As Decimal) As Boolean
        If value <= _Balance Then
            _Balance -= value
            Return True
        Else
            Return False
        End If

    End Function
End Class
