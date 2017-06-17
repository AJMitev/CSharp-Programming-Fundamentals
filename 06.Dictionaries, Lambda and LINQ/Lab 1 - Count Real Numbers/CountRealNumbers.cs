using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        //Input
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        //Logic
        var realNumbers = new SortedDictionary<double, int>();

        foreach (double number in numbers)
        {
            if (!realNumbers.ContainsKey(number))
            {
                realNumbers[number] = 1;
            }

            realNumbers[number]++;
        }

        foreach (var number in realNumbers)
        {
            Console.WriteLine(number.Key +  " -> " + number.Value);
        }
    }
}
