Public NotInheritable Class CuentaCorriente
    Inherits Cuenta

    Sub New(Numero As Integer, saldo As Decimal, MontoSobregiro As Decimal)
        ' invocaciòn a otro constructor tiene que ser la primer linea
        MyBase.New(Numero)
        Me.MontoSobregiro = MontoSobregiro
    End Sub

    Public Property MontoSobregiro As Decimal
End Class
