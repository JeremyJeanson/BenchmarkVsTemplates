Imports System
Imports BenchmarkDotNet
Imports BenchmarkDotNet.Attributes

Namespace $safeprojectname$
    Public Class Benchmarks
        <Benchmark(Baseline:=True)>
        Public Sub Scenario1()

            ' Implement your benchmark here

        End Sub

        <Benchmark>
        Public Sub Scenario2()

            ' Implement your benchmark here

        End Sub
    End Class
End Namespace