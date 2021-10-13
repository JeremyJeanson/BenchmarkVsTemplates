Imports System
Imports BenchmarkDotNet.Running

Namespace $safeprojectname$
    Module Program
        Sub Main(args As String())
            ' If arguments are available use BenchmarkSwitcher to run benchmarks
            If args.Length > 0 Then
                Dim summaries = BenchmarkSwitcher.FromAssembly(GetType(Program).Assembly) _
                    .Run(args, BenchmarkConfig.Get())
                Return
            End If
            ' Else, use BenchmarkRunner
            Dim summary = BenchmarkRunner.Run(Of Benchmarks)(BenchmarkConfig.Get())
        End Sub
    End Module
End Namespace
