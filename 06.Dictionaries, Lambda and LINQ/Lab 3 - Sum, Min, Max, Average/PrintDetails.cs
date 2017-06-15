using System;
using System.Collections.Generic;
using System.Linq;

public class PritnDetails
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        //Logic

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Output
        Console.WriteLine("Sum = {0}", numbers.Sum());
        Console.WriteLine("Min = {0}", numbers.Min());
        Console.WriteLine("Max = {0}", numbers.Max());
        Console.WriteLine("Average = {0}", numbers.Average());
    }
}
