Imports System
Imports Entidades
Module Program
    Sub ClienteTest()
        ' instanciación
        Dim cliente1 As Cliente
        'inicializacion
        cliente1 = New Cliente()
        'test de getters
        Console.WriteLine(cliente1.Nombre)
        Console.WriteLine(cliente1.Documento)
        Console.WriteLine(cliente1.FechaNacimiento)
        'test de setters
        cliente1.Nombre = "Pepe"
        cliente1.Documento = 435345
        cliente1.FechaNacimiento = #01-01-2000#
        'test de getters
        Console.WriteLine(cliente1.Nombre)
        Console.WriteLine(cliente1.Documento)
        Console.WriteLine(cliente1.FechaNacimiento)
        Console.WriteLine(cliente1.ToString)
        Console.WriteLine("SAldo cliente ")
        MostrarSaldo(cliente1)
        Dim cuenta1 As New CuentaCorriente(67436732, 5000, 1000, cliente1)
        Console.WriteLine("SAldo cuenta1: ")
        MostrarSaldo(cuenta1)
        Console.WriteLine("SAldo cliente: " & cliente1.Saldo)
        Dim cuenta2 As New CuentaCorriente(465465, 8000, 3000, cliente1)
        Console.WriteLine("SAldo cuenta2: ")
        MostrarSaldo(cuenta2)
        Console.WriteLine("SAldo cliente: " & cliente1.Saldo)
        cuenta1.Extraer(2000)
        Console.WriteLine("SAldo cuenta1: " & cuenta1.Saldo)
        Console.WriteLine("SAldo cliente: " & cliente1.Saldo)
        'cliente1.AddCuenta(cuenta1)
        Console.WriteLine("Cuenta cliente: " & cuenta1.Cliente.ToString)
        'cuenta1.Cliente = cliente1
        'cliente1.AddCuenta(New CuentaCorriente(465465, 1000, 3000))
        'cliente1.AddCuenta(New CuentaCorriente(666, 1000, 3000))

        For Each cuenta In cliente1.GetAllCuentas
            Console.WriteLine(cuenta)
        Next

        Dim cliente2 As New Cliente("Rafa Nadal", 54857485)
        Console.WriteLine(cliente2.Nombre)
        Console.WriteLine(cliente2.Documento)
        Console.WriteLine(cliente2.FechaNacimiento)

        Dim cliente3 As New Cliente("Rafa Nadal", 54857485, #06-03-1986#)
        Console.WriteLine(cliente3.Nombre)
        Console.WriteLine(cliente3.Documento)
        Console.WriteLine(cliente3.FechaNacimiento)
    End Sub

    Sub MostrarSaldo(oOperable As IOperable)
        Console.WriteLine(oOperable.Saldo)
    End Sub
End Module
