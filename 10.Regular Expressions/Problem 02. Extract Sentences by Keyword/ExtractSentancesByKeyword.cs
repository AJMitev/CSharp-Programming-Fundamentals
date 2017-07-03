using System;
using System.Linq;
using System.Text.RegularExpressions;

public class ExtractSentancesByKeyword
{
    public static void Main()
    {
        string pattern = Console.ReadLine();
        string[] textArray = Console.ReadLine().Split(new[] {'.', '!', '?'}).ToArray();

        Regex regex = new Regex(@"\b" + pattern + @"\b");

        foreach (var sentance in textArray)
        {
            var result = regex.IsMatch(sentance);

            if (result)
            {
                Console.WriteLine(sentance.Trim(' '));
            }
        }
 
    }
}