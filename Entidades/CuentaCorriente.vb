Public NotInheritable Class CuentaCorriente
    Inherits Cuenta

    Sub New(Numero As Integer, saldo As Decimal, MontoSobregiro As Decimal)
        ' invocaciòn a otro constructor tiene que ser la primer linea
        MyBase.New(Numero)
        Me.MontoSobregiro = MontoSobregiro
    End Sub
    Sub New(Numero As Integer, saldo As Decimal, MontoSobregiro As Decimal, cliente As Cliente)
        ' invocaciòn a otro constructor tiene que ser la primer linea
        MyBase.New(Numero, cliente)
        Me.MontoSobregiro = MontoSobregiro
    End Sub
    Public Property MontoSobregiro As Decimal

    Public Overrides Function Extraer(value As Decimal) As Boolean
        If value <= Saldo + MontoSobregiro Then
            DescontarSaldo(value)
            Return True
        Else
            Return False
        End If
        '        Return MyBase.Extraer(value)
    End Function

    Public Overrides Function ToString() As String
        Return "C.C. Nª " & MyBase.ToString()
    End Function

    Public Overrides Function UltimosMovimientos() As String
        Throw New NotImplementedException()
    End Function
End Class
