Imports System
Imports Entidades
Module Program
    Sub Main(args As String())
        Dim cliente1 As New Cliente()
        cliente1.Nombre = "Pepe"
        cliente1.Documento = 435345
        cliente1.FechaNacimiento = #01-01-2000#
        Console.WriteLine(cliente1.Nombre)
        Console.WriteLine(cliente1.Documento)
        Console.WriteLine(cliente1.FechaNacimiento)
    End Sub
End Module
