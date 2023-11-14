using System;

namespace CodingChallenge.ReversingString;

//Notes: 
//Approach 1, ToCharArrayStringReverse
//Approach 2: ForLoopStringBuilder
//Approach 3: Split in middle, merge array
//Approach 4 ReadOnlySpanReverse
//Approach 5: LinqReverse

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
