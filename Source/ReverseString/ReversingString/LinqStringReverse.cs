using System;
using System.Linq;

namespace CodingChallenge.ReversingString;

public class LinqStringReverse : IStringUtilities
{
    public string ReverseString(string input)
    {
        return new string(input.Reverse().ToArray());
    }
}
