using BenchmarkDotNet.Attributes;
using CodingChallenge.ReversingString;

namespace ReverseString.Benchmarks;

// Benchmarks cannot be static
#pragma warning disable CA1822 // Mark members as static

[MemoryDiagnoser]
public class StringReverseBenchmarks
{
    [Benchmark]
    public string ToCharArrayStringReverseBenchmark()
    {
        var implementation = new ToCharArrayStringReverse();
        return ExecuteBenchmark(implementation);
    }

    [Benchmark]
    public string StringBuilderReverseBenchmark()
    {
        var implementation = new StringBuilderReverse();
        return ExecuteBenchmark(implementation);
    }

    [Benchmark]
    public string ReadOnlySpanStringReverseBenchmark()
    {
        var implementation = new ReadOnlySpanStringReverse();
        return ExecuteBenchmark(implementation);
    }

    [Benchmark]
    public string LinqStringReverseBenchmark()
    {
        var implementation = new LinqStringReverse();
        return ExecuteBenchmark(implementation);
    }

    private static string ExecuteBenchmark(IStringUtilities implementation)
    {
        const string input = "BenchmarkTest";
        return implementation.ReverseString(input);
    }
}

#pragma warning restore CA1822 // Mark members as static