using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Exporters.Json;
using SingletonVsStaticBenchmark.Models;

namespace SingletonVsStaticBenchmark.Benchmarking;

// Benchmark Configuration for Visualization and Diagnosers
[Config(typeof(VisualizationConfig))]
public class AdvancedSingletonBenchmark
{
    private const int ThreadCount = 10;

    // Simulate Multi-Threading Access
    [Benchmark]
    public void MultiThreadedAccess()
    {
        Parallel.For(0, ThreadCount, _ =>
        {
            var instance = Singleton.Instance;
            var randomValue = instance.GetRandomValue();
        });
    }

    // Benchmark Singleton Initialization Cost
    [Benchmark]
    public Singleton InitializeSingleton()
    {
        return Singleton.Instance;
    }

    // Benchmark Heavy Singleton Initialization
    [Benchmark]
    public HeavySingleton InitializeHeavySingleton()
    {
        return HeavySingleton.Instance;
    }
}

// Custom Configuration for BenchmarkDotNet
public class VisualizationConfig : ManualConfig
{
    public VisualizationConfig()
    {
        // Exporters for multiple formats
        AddExporter(HtmlExporter.Default);  // HTML report
        AddExporter(JsonExporter.Full);    // Full JSON output
        AddExporter(CsvExporter.Default);  // CSV output

        // Diagnosers for memory and threading
        AddDiagnoser(MemoryDiagnoser.Default);
        AddDiagnoser(ThreadingDiagnoser.Default);
    }
}
