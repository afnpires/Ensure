namespace Ensure.Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Diagnostics.Windows.Configs;

    [MemoryDiagnoser, InliningDiagnoser]
    [MinColumn, MaxColumn]
    [MarkdownExporter, RPlotExporter]
    public class EnsureBenchmark
    {
        private const int Iterations = 1000;

        [Benchmark]
        public static void EnsureNotNull_Struct()
        {
            const int target = 1;
            for (int i = 0; i < Iterations; i++)
            {
                target.EnsureNotNull();
            }
        }

        [Benchmark]
        public static void EnsureNotNull_Object()
        {
            const string target = "target";
            for (int i = 0; i < Iterations; i++)
            {
                target.EnsureNotNull();
            }
        }

        [Benchmark]
        public static void Ensure_Struct()
        {
            const int target = 1;
            for (int i = 0; i < Iterations; i++)
            {
                target.Ensure(v => v == 1, "an error message");
            }
        }

        [Benchmark]
        public static void Ensure_Object()
        {
            const string target = "target";
            for (int i = 0; i < Iterations; i++)
            {
                target.Ensure(v => v?.Length > 0, "an error message");
            }
        }

        [Benchmark]
        public static void EnsureNotNullOrEmpty_String()
        {
            const string target = "target";
            for (int i = 0; i < Iterations; i++)
            {
                target.EnsureNotNullOrEmpty();
            }
        }

        [Benchmark]
        public static void EnsureNotNullOrWhitespace_String()
        {
            const string target = "target";
            for (int i = 0; i < Iterations; i++)
            {
                target.EnsureNotNullOrWhitespace();
            }
        }
    }
}
