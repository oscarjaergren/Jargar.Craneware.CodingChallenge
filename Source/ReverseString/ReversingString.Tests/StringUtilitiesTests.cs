using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodingChallenge.ReversingString.Tests;

[TestFixture]
[TestFixture]
public class StringUtilitiesTests
{
    [TestCaseSource(nameof(TestCases))]
    [Category("ToCharArrayStringReverse")]
    public void ToCharArrayStringReverse_WhenCalledWithValidInput_ShouldReturnReversedString(
        string input,
        string expectedOutput,
        string failureReason)
    {
        ExecuteReverseTest(new ToCharArrayStringReverse(), input, expectedOutput, failureReason);
    }

    [TestCaseSource(nameof(TestCases))]
    [Category("StringBuilderReverse")]
    public void StringBuilderReverse_WhenCalledWithValidInput_ShouldReturnReversedString(
        string input,
        string expectedOutput,
        string failureReason)
    {
        ExecuteReverseTest(new StringBuilderReverse(), input, expectedOutput, failureReason);
    }

    [TestCaseSource(nameof(TestCases))]
    [Category("LinqStringReverse")]
    public void LinqStringReverse_WhenCalledWithValidInput_ShouldReturnReversedString(
        string input,
        string expectedOutput,
        string failureReason)
    {
        ExecuteReverseTest(new LinqStringReverse(), input, expectedOutput, failureReason);
    }

    private static void ExecuteReverseTest(
        IStringUtilities implementation,
        string input,
        string expectedOutput,
        string failureReason)
    {
        string result = null;
        try
        {
            result = implementation.ReverseString(input);
        }
        catch (Exception ex)
        {
            Assert.Fail($"{implementation.GetType().Name} failed for input: '{input}'. Reason: {failureReason} with exception {ex.Message}");
        }

        Assert.AreEqual(expectedOutput, result, $"{implementation.GetType().Name} failed for input: '{input}'. \n Reason: {failureReason}");
    }

    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[] { "FooBazQux", "xuQzaBooF", "Reverse order of characters" };
        yield return new object[] { "Hello Bar", "raB olleH", "Reverse order of characters with space" };
        yield return new object[] { "A", "A", "Single character input" };
        yield return new object[] { "123!@#", "#@!321", "Alphanumeric characters and symbols" };
        yield return new object[] { "Unicode测试", "试测edocinU", "Unicode characters" };
        yield return new object[] { null, null, "Null input" };
        yield return new object[] { " \t\n\r\f\v", " \t\n\r\f\v", "Whitespace input" };
    }
}