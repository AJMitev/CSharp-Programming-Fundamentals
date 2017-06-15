using System;
using System.Collections.Generic;
using System.Linq;

public class PrintSelectedWords
{
    public static void Main()
    {
        //Input
        string sentanse = Console.ReadLine().ToLower();

        //Logic
        char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

        string[] words = sentanse.Split(separators);
        var result = words.Where(w => w != ""). Where( w => w.Length < 5). OrderBy(w => w).Distinct();

        Console.WriteLine(string.Join(", ", result));
    }
}
