Imports System
Imports System.Text


Module Program
    Sub Main(args As String())
        Dim l As New Logic()
        Dim arabice As String = l.Addition()
        'Dim arabice As String = "Hello World"

        Console.OutputEncoding = Encoding.UTF8
        Console.WriteLine($"Test Word:{arabice}")
    End Sub
End Module
