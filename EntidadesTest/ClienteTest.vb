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
    End Sub
End Module
