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

        Dim cliente2 As New Cliente("Rafa Nadal", 54857485)
        Console.WriteLine(cliente2.Nombre)
        Console.WriteLine(cliente2.Documento)
        Console.WriteLine(cliente2.FechaNacimiento)

        Dim cliente3 As New Cliente("Rafa Nadal", 54857485, #06-03-1986#)
        Console.WriteLine(cliente3.Nombre)
        Console.WriteLine(cliente3.Documento)
        Console.WriteLine(cliente3.FechaNacimiento)
    End Sub
End Module
