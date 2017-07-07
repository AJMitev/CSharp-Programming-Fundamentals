using System;
using System.Text.RegularExpressions;

public class Hideout
{
    public static void Main()
    {
        string path = Console.ReadLine();

        while (true)
        {
            string[] tokens = Console.ReadLine().Split();

            string pattern = $@"\{tokens[0]}{{{tokens[1]},}}";

            Match match = Regex.Match(path, pattern);
            if (match.Success)
            {
                Console.WriteLine($"Hideout found at index {path.IndexOf(match.Value)} and it is with size {match.Value.Length}!");
                break;
            }

        }

    }
}