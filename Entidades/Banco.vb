Public Class Banco
    Public Property Nombre As String
    Private _clientes As List(Of Cliente)
    Public Sub New(Nombre As String)
        _clientes = New List(Of Cliente)
        Me.Nombre = Nombre
    End Sub

    Public Sub AddCliente(Cliente As Cliente)
        _clientes.Add(Cliente)
    End Sub
    Public Sub RemoveCliente(cliente As Cliente)
        _clientes.Remove(cliente)
    End Sub
    Public Function GetAllClientes() As List(Of Cliente)
        Return _clientes
    End Function
End Class