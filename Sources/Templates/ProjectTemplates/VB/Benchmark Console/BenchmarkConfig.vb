Imports BenchmarkDotNet.Analysers
Imports BenchmarkDotNet.Columns
Imports BenchmarkDotNet.Configs
Imports BenchmarkDotNet.Diagnosers
Imports BenchmarkDotNet.Environments
Imports BenchmarkDotNet.Exporters
Imports BenchmarkDotNet.Exporters.Csv
Imports BenchmarkDotNet.Jobs
Imports BenchmarkDotNet.Loggers

Namespace $safeprojectname$
    Public Class BenchmarkConfig

        ''' <summary>
        ''' Get a custom configuration
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function [Get]() As IConfig
            Return ManualConfig.CreateEmpty() _
                .AddJob(Job.Default _
                    .WithRuntime(CoreRuntime.Core90) _
                    .WithPlatform(Platform.X64)) _
                .AddDiagnoser(MemoryDiagnoser.Default) _
                .AddColumnProvider(DefaultColumnProviders.Instance) _
                .AddLogger(ConsoleLogger.Default) _
                .AddExporter(CsvExporter.Default) _
                .AddExporter(HtmlExporter.Default) _
                .AddAnalyser(GetAnalysers())
        End Function


        ''' <summary>
        ''' Get analyser for the cutom configuration
        ''' </summary>
        ''' <returns></returns>
        Private Shared Function GetAnalysers() As IAnalyser()
            Return New IAnalyser() {
                EnvironmentAnalyser.Default,
                OutliersAnalyser.Default,
                MinIterationTimeAnalyser.Default,
                MultimodalDistributionAnalyzer.Default,
                RuntimeErrorAnalyser.Default,
                ZeroMeasurementAnalyser.Default,
                BaselineCustomAnalyzer.Default
                }
        End Function

    End Class
End Namespace
