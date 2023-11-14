using System.Text;

namespace CodingChallenge.ReversingString;

public class StringBuilderReverse : IStringUtilities
{
    public string ReverseString(string input)
    {
        StringBuilder reversedStringBuilder = new();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedStringBuilder.Append(input[i]);
        }

        return reversedStringBuilder.ToString();
    }
}
