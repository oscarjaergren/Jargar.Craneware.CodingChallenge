using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests;

[TestFixture]
public class StringUtilitiesTests
{
    [TestCase("FooBazQux", "xuQzaBooF")]
    [TestCase("Hello Bar", "raB olleH")]
    [TestCase("A", "A")]
    [TestCase("123!@#", "#@!321")]
    [TestCase("Unicode测试", "试验eciuDnoU")]
    public void Reverse_WhenCalledWithValidInput_ShouldReturnReversedString(string input, string expectedOutput)
    {
        string result = StringUtilities.Reverse(input);
        Assert.AreEqual(expectedOutput, result);
    }

    [TestCase(null, "")]
    public void Reverse_WhenCalledWithNullInput_ShouldReturnEmptyString(string input, string expectedOutput)
    {
        string result = StringUtilities.Reverse(input);
        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Reverse_WhenCalledWithWhitespaceOnly_ShouldPreserveWhitespace()
    {
        const string input = " \t\n\r\f\v";
        string result = StringUtilities.Reverse(input);
        Assert.AreEqual(input, result);
    }
}
