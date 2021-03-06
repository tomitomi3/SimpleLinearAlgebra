Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SimpleLinearAlgebra

<TestClass()> Public Class UnitTestMathUtil
    Public Const delta = 0.0000000001

    <TestMethod()> Public Sub CoVariance()
        Dim v1 = New DenseVector(New Double() {50, 60, 70, 80, 90})
        Dim v2 = New DenseVector(New Double() {40, 70, 90, 60, 100})
        Dim temp = MathUtil.CoVar(v1, v2)
        Console.WriteLine(temp)
        Assert.AreEqual(temp, 220.0, delta)
    End Sub

    <TestMethod()> Public Sub Variance()
        Dim v1 = New DenseVector(New Double() {1, 2, 3, 4, 5})
        Dim temp = MathUtil.Var(v1)
        Console.WriteLine(temp)
        Assert.AreEqual(temp, 2.0, delta)
    End Sub

    <TestMethod()> Public Sub Stddev()
        Dim v1 = New DenseVector(New Double() {1, 2, 3, 4, 5})
        Dim temp = MathUtil.Stddev(v1)
        Console.WriteLine(temp)
        Assert.AreEqual(temp, 1.4142135623731, delta)
    End Sub

    <TestMethod()> Public Sub Correlation()
        Dim v1 = New DenseVector(New Double() {1, 2, 3, 4, 5})
        Dim v2 = v1 * 2
        Dim temp = MathUtil.Cor(v1, v2)
        Console.WriteLine(temp)
        Assert.AreEqual(temp, 1.0, delta)
    End Sub
End Class