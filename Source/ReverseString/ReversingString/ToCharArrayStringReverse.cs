using System;

namespace CodingChallenge.ReversingString;

public class ToCharArrayStringReverse : IStringUtilities
{
    public string ReverseString(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
