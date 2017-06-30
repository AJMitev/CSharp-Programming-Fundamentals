using System;
using System.Collections.Generic;
using System.Linq;

public class Palindromes
{
    public static void Main()
    {

        string[] text = Console.ReadLine().Split(new char[] {',',' ','.','!','?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var palindromes = new List<string>();

        foreach (var word in text)
        {
            if (word[0].Equals(word[word.Length-1]))
            {
                palindromes.Add(word);
            }
        }

        Console.WriteLine(string.Join(", ",palindromes.OrderBy(w => w).Distinct()));
    }
}