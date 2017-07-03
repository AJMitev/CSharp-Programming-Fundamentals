using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ValidateUsernames
{
    public static void Main()
    {
        string usernamePatern = @"^\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b$";
        string[] text = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var matches = new List<Match>();

        foreach (var t in text)
        {

            bool isItMatch = Regex.IsMatch(t, usernamePatern,RegexOptions.Multiline);

            if (isItMatch)
            {
                var match = Regex.Match(t, usernamePatern, RegexOptions.Multiline);
                matches.Add(match);
            }
        }

        int maxLenght = 0;
        int bestIndex = 0;

        if (matches.Count > 1)
        {
            for (int i = 1; i < matches.Count; i++)
            {
                int result = matches[i].Length + matches[i - 1].Length;

                if (result > maxLenght)
                {
                    maxLenght = result;
                    bestIndex = i;
                }
            }

            Console.WriteLine($"{matches[bestIndex - 1]}");
            Console.WriteLine($"{matches[bestIndex]}");
        }
    }
}