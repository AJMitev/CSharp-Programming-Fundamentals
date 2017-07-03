using System;
using System.Linq;
using System.Text.RegularExpressions;

public class KeyReplacer
{
    public static void Main()
    {
        string startPattern = @"^(\b[a-zA-Z]+)\b[<|\\|]";
        string endPattern = @"[<|\\|](\b[a-zA-Z]+)\b$";

        string keyString = Console.ReadLine();
        string textString = Console.ReadLine();

        Match startKey = Regex.Match(keyString, startPattern);
        Match endKey = Regex.Match(keyString, endPattern);

        string wordPattern = startKey.Groups[1].ToString() + @"(.*?)" + endKey.Groups[1].ToString();

        string[] words = Regex.Matches(textString, wordPattern)
               .Cast<Match>()
               .Select(w => w.Groups[1].Value)
               .Where(w => w != "")
               .ToArray();

        if (words.Length != 0)
        {
            Console.WriteLine(string.Join("", words));
        }
        else
        {
            Console.WriteLine("Empty result");

        }
    }
}