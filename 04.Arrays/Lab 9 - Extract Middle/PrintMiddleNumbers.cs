using System;
using System.Linq;

public class PrintMiddleNumbers
{
    public static void Main()
    {
        //Input
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        double length = numbers.Length;

        if (length.Equals(1))
        {
            Console.WriteLine(numbers[0]);
        }
        else if (length % 2 == 0)
        {
            Console.WriteLine(numbers[(numbers.Length / 2) - 1] + " " + numbers[numbers.Length / 2]);
        }
        else if (length % 2 == 1)
        {
            Console.WriteLine(numbers[(numbers.Length / 2-1)] + " " + numbers[numbers.Length / 2] + " " + numbers[numbers.Length / 2+1]);
        }

    }
}