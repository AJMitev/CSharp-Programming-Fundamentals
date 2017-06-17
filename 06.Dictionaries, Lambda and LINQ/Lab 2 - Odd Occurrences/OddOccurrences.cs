using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        //Input
        string[] input = Console.ReadLine().ToLower().Split().ToArray();

        //Logic
        var words = new Dictionary<string, int>();

        foreach (var word in input)
        {
            if (!words.ContainsKey(word))
            {
                words[word] = 1;
            }

            words[word]++;
        }

        var result = new List<string>();

        foreach (var word in words)
        {
            if (word.Value % 2 == 1)
            {
                result.Add(word.Key);
            }
        }

        //Output
        Console.WriteLine(string.Join(", ", result));

    }
}