using System;
using System.Collections.Generic;
using System.Linq;

public class PrintLargestThreeNumbers
{
    public static void Main()
    {
        //Input
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //Output
        Console.WriteLine(string.Join(" ", numbers.OrderBy(p => -p).Take(3)));
    }
}
