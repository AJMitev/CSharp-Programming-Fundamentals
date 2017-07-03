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

        //var replaced = Regex.Replace(textString, startKey.Groups[1].ToString(), "[");
        //replaced = Regex.Replace(replaced, endKey.Groups[1].ToString(), "]");

        //string extractPattern = @"\[(.*?)\]";
        //bool isItEmpty = true;
        //var matches = Regex.Matches(replaced, extractPattern);

        //foreach (Match match in matches)
        //{
        //    if (match.Length >= 3)
        //    {
        //        isItEmpty = false;
        //        Console.Write(match.Groups[1].ToString());
        //    } 
        //}
        //if (isItEmpty)
        //{
        //    Console.WriteLine("Empty result");
        //}
    }
}