using System;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"(\w+[-|_|.])*([a-zA-Z]+)@([a-zA-Z0-9_-]+)(\.[a-zA-Z0-9_-]+)+";
        Regex regex = new Regex(pattern);
        var matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}