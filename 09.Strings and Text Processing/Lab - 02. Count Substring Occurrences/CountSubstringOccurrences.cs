using System;
using System.Collections.Generic;
using System.Linq;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        var text = Console.ReadLine().ToLower();
        var pattern = Console.ReadLine().ToLower();

        var count = 0;
        var index = 0;

        while (true)
        {
            var found = text.IndexOf(pattern, index);

            if (found >= 0)
            {
                count++;
                index = found + 1;
            }
            else
            {
                break;
            }

        }

        Console.WriteLine(count);
    }
}
