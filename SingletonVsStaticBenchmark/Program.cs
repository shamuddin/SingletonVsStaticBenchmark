using BenchmarkDotNet.Running;
using SingletonVsStaticBenchmark.Benchmarking;

namespace SingletonVsStaticBenchmark;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Running Singleton vs Static Benchmark...");
        //BenchmarkRunner.Run<SingletonBenchmark>();

        Console.WriteLine("Running Advanced Singleton Benchmarks...");
        BenchmarkRunner.Run<AdvancedSingletonBenchmark>();
    }
}