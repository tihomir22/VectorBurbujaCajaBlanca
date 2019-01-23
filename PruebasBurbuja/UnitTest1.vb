Imports System.Text
Imports BurbujaVBCajaBlanca
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Dim lista As List(Of Integer) = New List(Of Integer) From {2, 3, 4, 53, 1}
    Dim vector As VectorA = New VectorA(lista)
    <TestMethod()> Public Sub ComprobarForPrueba()

    End Sub

End Class