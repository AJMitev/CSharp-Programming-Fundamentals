using System;
using System.Collections.Generic;
using System.Linq;

public class ByteFlip
{
    public static void Main()
    {
        //Input
        var text = new List<string>(Console.ReadLine().Split().ToList());

        var selectedWords = new List<string>();
        foreach (var word in text)
        {
            if (word.Length.Equals(2))
            {
                selectedWords.Add(word);
            }
        }

        var reversedWords = new List<string>();
        foreach (string word in selectedWords)
        {
            var wordNew = word.ToCharArray();
            char temp = word[0];
            char tempTwo = word[1];
            wordNew[0] = word[1];
            wordNew[1] = word[0];
            string reversedWord = new string(wordNew);
            reversedWords.Add(reversedWord);

        }

        reversedWords.Reverse();
        var result = new List<string>();


        foreach (var hex in reversedWords)
        {
            int value = Convert.ToInt32(hex, 16);
            string stringValue = Char.ConvertFromUtf32(value);
            result.Add(stringValue);
        }

        Console.WriteLine(string.Join("", result));

       // string.Join("", input.Select(c => ((int)c).ToString("X2")));

    }
}