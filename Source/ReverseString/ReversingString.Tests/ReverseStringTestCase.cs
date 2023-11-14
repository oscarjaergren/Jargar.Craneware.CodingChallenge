namespace CodingChallenge.ReversingString.Tests;
internal sealed class ReverseStringTestCase
{
    internal required string Input { get; set; }
    internal required string ExpectedOutput { get; set; }
    internal required string FailureReason { get; set; }

    internal ReverseStringTestCase(string input, string expectedOutput, string failureReason)
    {
        Input = input;
        ExpectedOutput = expectedOutput;
        FailureReason = failureReason;
    }
}