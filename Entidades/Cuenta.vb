Public MustInherit Class Cuenta
    Sub New(Numero As Integer)
        Me.Numero = Numero
    End Sub
    Public Property Numero As Integer
    Private _saldo As Decimal
    Public ReadOnly Property Saldo As Decimal
        Get
            Return _saldo
        End Get
    End Property

    Public Sub Depositar(value As Decimal)
        _saldo += value
    End Sub
    Public Overridable Function Extraer(value As Decimal) As Boolean
        If value <= _saldo Then
            DescontarSaldo(value)
            Return True
        Else
            Return False
        End If
    End Function

    Protected Sub DescontarSaldo(value As Decimal)
        _saldo -= value
    End Sub
End Class
