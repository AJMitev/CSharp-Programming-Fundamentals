using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class RageQuit
{
    public static void Main()
    {
        string sequence = Console.ReadLine();
        string pattern = @"(?<string>[^0-9]{1,20})(?<repeated>\d+)";

        var matches = Regex.Matches(sequence, pattern);
        StringBuilder stringBuilder = new StringBuilder(5000);

        foreach (Match match in matches)
        {

            string result = string.Empty;

            for (int i = 0; i < int.Parse(match.Groups["repeated"].Value); i++)
            {
                result += match.Groups["string"].Value.ToUpper();
            }

            stringBuilder.Append(result);
        }

        Console.WriteLine("Unique symbols used: {0}", stringBuilder.ToString().Distinct().Count());
        Console.WriteLine(stringBuilder);
    }
}