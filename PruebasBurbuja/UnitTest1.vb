Imports System.Text
Imports BurbujaVBCajaBlanca
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Dim lista As List(Of Integer) = New List(Of Integer) From {2, 3, 4, 53, 1}
    Dim vector As VectorA = New VectorA(lista)

    <TestMethod()> Public Sub ComprobarForPrueba()
        Dim aux As List(Of Integer) = lista
        aux.Sort()
        Assert.AreEqual(vector.burbujaFor(), aux)
    End Sub

    <TestMethod()> Public Sub ComprobarWhilePrueba()
        Dim aux As List(Of Integer) = lista
        aux.Sort()
        Assert.AreEqual(vector.burbujaFor(), aux)
    End Sub

    <TestMethod()> Public Sub ComprobarDoWhilePrueba()
        Dim aux As List(Of Integer) = lista
        aux.Sort()
        Assert.AreEqual(vector.burbujaDoWhile(), aux)
    End Sub

End Class