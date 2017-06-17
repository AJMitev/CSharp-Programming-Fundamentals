using System;
using System.Collections.Generic;
using System.Linq;

public class PrintTime
{
    public static void Main()
    {
        //Input
        var sordtedTimes = new List<string>(Console.ReadLine().Split().ToList());

        sordtedTimes.Sort();

        Console.WriteLine(string.Join(", ", sordtedTimes));

    }
}
