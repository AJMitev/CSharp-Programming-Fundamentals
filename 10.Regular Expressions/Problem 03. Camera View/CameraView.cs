using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class CameraView
{
    public static void Main()
    {
        int[] elemets = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string cameraInput = Console.ReadLine();
        string pattern = @"\|<";

        Regex regex = new Regex(pattern);

        string[] splited = regex.Split(cameraInput);
        var results = new List<string>();

        foreach (var word in splited.Skip(1))
        {
            string currnetWord = string.Empty;
            foreach (var letter in word.Skip(elemets[0]).Take(elemets[1]))
            {
                currnetWord += letter;
            }

            results.Add(currnetWord);
        }

        Console.WriteLine(string.Join(", ", results));
    }
}