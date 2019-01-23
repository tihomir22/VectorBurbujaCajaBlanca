Module Module1

    Sub Main()

        Dim lista As List(Of Integer) = New List(Of Integer) From {2, 3, 4, 53, 1}
        Dim vector As VectorA = New VectorA(lista)
        imprimirArray(vector.getArray())
        Console.ReadLine()
        Console.WriteLine("Ordenados por for ")
        imprimirArray(vector.burbujaFor())
        Console.WriteLine("Ordenados por while")
        imprimirArray(vector.burbujaWhile())
        Console.WriteLine("Ordenados por do while ")
        imprimirArray(vector.burbujaDoWhile())
        Console.ReadLine()



    End Sub

    Public Sub imprimirArray(ByVal lista As List(Of Integer))
        For Each num In lista
            Console.WriteLine(num)
        Next

    End Sub

End Module
