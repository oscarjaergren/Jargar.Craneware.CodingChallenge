using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests;

[TestFixture]
public class StringUtilitiesTests
{
    readonly IStringUtilities _stringUtilities;

    public StringUtilitiesTests()
    {
        //Ideally would be constructor injected intead
        _stringUtilities = new StringUtilities();
    }

    [TestCase("FooBazQux", "xuQzaBooF")]
    [TestCase("Hello Bar", "raB olleH")]
    [TestCase("A", "A")]
    [TestCase("123!@#", "#@!321")]
    [TestCase("Unicode测试", "试测edocinU")]
    public void Reverse_WhenCalledWithValidInput_ShouldReturnReversedString(string input, string expectedOutput)
    {
        string result = _stringUtilities.ReverseString(input);
        Assert.AreEqual(expectedOutput, result);
    }

    [TestCase(null, null)]
    public void Reverse_WhenCalledWithNullInput_ShouldReturnEmptyString(string input, string expectedOutput)
    {
        string result = _stringUtilities.ReverseString(input);
        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Reverse_WhenCalledWithWhitespaceOnly_ShouldPreserveWhitespace()
    {
        const string input = " \t\n\r\f\v";
        string result = _stringUtilities.ReverseString(input);
        Assert.AreEqual(input, result);
    }
}
