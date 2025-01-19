using BenchmarkDotNet.Attributes;
using SingletonVsStaticBenchmark.Models;

namespace SingletonVsStaticBenchmark.Benchmarking
{
    [MemoryDiagnoser] // Tracks memory usage
    [ThreadingDiagnoser] // Tracks thread usage
    [HardwareCounters] // Tracks CPU cache misses, branch mispredictions, etc. (requires elevated privileges)
    [DisassemblyDiagnoser(printSource: true, exportHtml: true)] // Shows IL and assembly code
    [JsonExporterAttribute.Full] // Exports results as JSON for detailed analysis
    public class SingletonBenchmark
    {
        // Direct access to Singleton
        [Benchmark]
        public int DirectAccess()
        {
            return Singleton.Instance.GetRandomValue();
        }

        // Cached access to Singleton
        [Benchmark]
        public int CachedAccess()
        {
            var cachedInstance = Singleton.Instance;
            return cachedInstance.GetRandomValue();
        }
    }
}
