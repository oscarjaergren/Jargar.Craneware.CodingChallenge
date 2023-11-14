using BenchmarkDotNet.Attributes;
using CodingChallenge.ReversingString;

namespace ReverseString.Benchmarks;

// Benchmarks cannot be static
#pragma warning disable CA1822 // Mark members as static

[MemoryDiagnoser]
public class StringReverseBenchmarks
{
    [Benchmark]
    public void ToCharArrayStringReverseBenchmark()
    {
        var implementation = new ToCharArrayStringReverse();
        ExecuteBenchmark(implementation);
    }

    [Benchmark]
    public void StringBuilderReverseBenchmark()
    {
        var implementation = new StringBuilderReverse();
        ExecuteBenchmark(implementation);
    }

    [Benchmark]
    public void LinqStringReverseBenchmark()
    {
        var implementation = new LinqStringReverse();
        ExecuteBenchmark(implementation);
    }

    private static void ExecuteBenchmark(IStringUtilities implementation)
    {
        const string input = "BenchmarkTest";
        string result = implementation.ReverseString(input);
        Console.WriteLine(result); // To prevent optimizations from removing the code
    }
}

#pragma warning restore CA1822 // Mark members as static