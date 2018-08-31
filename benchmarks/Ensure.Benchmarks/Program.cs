namespace Ensure.Benchmarks
{
    using BenchmarkDotNet.Running;

    public static class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<EnsureBenchmark>();
        }
    }
}
