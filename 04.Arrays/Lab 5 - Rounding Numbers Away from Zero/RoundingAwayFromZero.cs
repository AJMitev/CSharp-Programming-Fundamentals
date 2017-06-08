using System;

public class RoundingAwayFromZero
{
    public static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        double[] arr = new double[numbers.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(numbers[i]);

        }

        for (int i = 0; i < arr.Length; i++)
        {
            double currentNum = arr[i];
            Console.WriteLine(arr[i] + " => " + Math.Round(currentNum, 0, MidpointRounding.AwayFromZero));
        }
    }
}