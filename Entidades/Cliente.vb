Public Class Cliente
    Public Sub New()
        Me.New("", 0, Date.MinValue)
    End Sub
    Public Sub New(Nombre As String, Documento As Integer)
        Me.New(Nombre, Documento, Date.MinValue)
    End Sub
    Public Sub New(Nombre As String, Documento As Integer, FechaNacimiento As Date)
        Me.Nombre = Nombre
        Me.Documento = Documento
        Me.FechaNacimiento = FechaNacimiento
        _cuentas = New List(Of Cuenta)
    End Sub
    'Private _nombre As String
    'Public Sub New()
    '    Nombre = ""
    '    Documento = 0
    '    FechaNacimiento = Date.MinValue
    '    Cuentas = New List(Of Cuenta)
    'End Sub
    'Public Sub New(Nombre As String, Documento As Integer)
    '    Me.New()
    '    Me.Nombre = Nombre
    '    Me.Documento = Documento
    'End Sub
    'Public Sub New(Nombre As String, Documento As Integer, FechaNacimiento As Date)
    '    Me.New(Nombre, Documento)
    '    Me.FechaNacimiento = FechaNacimiento
    'End Sub
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Private _documento As Integer
    Public Property Documento As Integer
        Get
            Return _documento
        End Get
        Set(value As Integer)
            _documento = value
        End Set
    End Property
    Private _fechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre & " " & Documento
    End Function
    Private _cuentas As List(Of Cuenta)
    'Public Sub AddCuenta(cuenta As Cuenta)
    '    If _cuentas.Count < 2 Then
    '        ' primero asociar en la clase colaboradora
    '        cuenta.Cliente = Me
    '        ' en clase responsable
    '        _cuentas.Add(cuenta)
    '    End If
    'End Sub
    Friend Sub AddCuenta(cuenta As Cuenta)
        If _cuentas.Count < 2 Then
            _cuentas.Add(cuenta)
        End If
    End Sub
    Public Function GetAllCuentas() As List(Of Cuenta)
        Return _cuentas
    End Function
    Friend Sub RemoveCuenta(cuenta As Cuenta)
        _cuentas.Remove(cuenta)
    End Sub
End Class