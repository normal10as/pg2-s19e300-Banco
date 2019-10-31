Imports Entidades

Public MustInherit Class Cuenta
    Implements IOperable
    Sub New(Numero As Integer)
        Me.Numero = Numero
    End Sub
    Sub New(Numero As Integer, cliente As Cliente, saldo As Decimal)
        Me.Numero = Numero
        Me.Cliente = cliente
        _saldo = saldo ' ojojoooooooo
    End Sub
    Public Property Numero As Integer
    Private _saldo As Decimal
    Public ReadOnly Property Saldo As Decimal Implements IOperable.Saldo
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

    Public Overrides Function ToString() As String
        Return Numero
    End Function

    Public MustOverride Function UltimosMovimientos() As String
    Private _cliente As Cliente
    'Public Property Cliente As Cliente
    '    ' atributo unicamente accesible en el proyecto
    '    Friend Set(value As Cliente)
    '        _cliente = value
    '    End Set
    '    Get
    '        Return _cliente
    '    End Get
    'End Property
    Public Property Cliente As Cliente
        Set(value As Cliente)
            'If _cliente IsNot Nothing Then
            '    _cliente.RemoveCuenta(Me)
            'End If
            If _cliente Is Nothing Then
                value.AddCuenta(Me)
                _cliente = value
            End If
        End Set
        Get
            Return _cliente
        End Get
    End Property
End Class
