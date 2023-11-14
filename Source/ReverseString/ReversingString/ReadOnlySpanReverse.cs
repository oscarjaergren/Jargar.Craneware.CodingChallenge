using System;
using System.Linq;

namespace CodingChallenge.ReversingString;
public class ReadOnlySpanStringReverse : IStringUtilities
{
    public string ReverseString(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        ReadOnlySpan<char> charSpan = input.AsSpan();
        Span<char> reversed = charSpan.ToArray();
        reversed.Reverse();

        return new string(reversed);
    }
}
