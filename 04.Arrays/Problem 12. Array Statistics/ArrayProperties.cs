using System;
using System.Linq;

public class ArrayProperties
{
    public static void Main()
    {
        //Input
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int max = arrayOfNumbers[0];
        int min = arrayOfNumbers[0];
        int sum = arrayOfNumbers[0];

        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            max = Math.Max(max, arrayOfNumbers[i]);
            min = Math.Min(min, arrayOfNumbers[i]);
            sum += arrayOfNumbers[i];
        }

        double average = (double)sum / arrayOfNumbers.Length;


    //Output
    Console.WriteLine($"Min = {min}\nMax = {max}\nSum = {sum}\nAverage = {average}");
    }
}