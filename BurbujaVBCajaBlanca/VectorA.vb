Public Class VectorA
    Private array As List(Of Integer)

    Public Sub New(array As List(Of Integer))
        Me.array = array
    End Sub


    Public Function burbujaFor()
        Dim auxArray As List(Of Integer) = Me.array
        For i As Integer = 0 To auxArray.Count()
            For j As Integer = i + 1 To auxArray.Count() - 1
                If auxArray(i) > auxArray(j) Then
                    Dim temp As Integer = auxArray(i)
                    auxArray(i) = auxArray(j)
                    auxArray(j) = temp
                End If

            Next
        Next
        Return auxArray
    End Function


    Public Function burbujaWhile()
        Dim auxArray As List(Of Integer) = Me.array
        Dim i As Integer = 0
        While i < auxArray.Count()
            Dim j As Integer = i + 1
            While j < auxArray.Count() - 1
                If auxArray(i) > auxArray(j) Then
                    Dim temp As Integer = auxArray(i)
                    auxArray(i) = auxArray(j)
                    auxArray(j) = temp
                End If
                j += 1
            End While
            i += 1
        End While
        Return auxArray
    End Function



    Public Function burbujaDoWhile()
        Dim auxArray As List(Of Integer) = Me.array
        Dim i As Integer = 0
        Do While i < auxArray.Count()
            Dim j As Integer = j + 1
            Do While j < auxArray.Count() - 1
                If auxArray(i) > auxArray(j) Then
                    Dim temp As Integer = auxArray(i)
                    auxArray(i) = auxArray(j)
                    auxArray(j) = temp
                End If
                j += 1
            Loop
            i += 1
        Loop
        Return auxArray
    End Function






    Public Function getArray()
        Return Me.array
    End Function

End Class
