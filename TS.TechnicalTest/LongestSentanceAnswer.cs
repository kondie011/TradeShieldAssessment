
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        var delimeters = new char[] { '.', '?', '!' };
        var sentenses = s.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
        var longestSentenseLen = 0;

        foreach ( var sentense in sentenses )
        {
            var words = sentense.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var len = words.Length;

            if (len > longestSentenseLen)
            {
                longestSentenseLen = len;
            }
        }

        return longestSentenseLen;
    }
}
