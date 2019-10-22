Imports Entidades
Module BancoTest
    Sub hacer()
        Dim banco1 As New Banco("Banco Marco")
        banco1.AddCliente(New Cliente("Pepe", 123))
        Dim cliente1 As Cliente = New Cliente("Jaun", 123)
        banco1.AddCliente(cliente1)
        banco1.AddCliente(New Cliente("Rov", 123))
        MostrarTodos(banco1)
        banco1.RemoveCliente(cliente1)
        MostrarTodos(banco1)
    End Sub
    Sub MostrarTodos(banco As Banco)
        For Each cliente1 In banco.GetAllClientes
            Console.WriteLine(cliente1)
        Next
    End Sub
End Module
