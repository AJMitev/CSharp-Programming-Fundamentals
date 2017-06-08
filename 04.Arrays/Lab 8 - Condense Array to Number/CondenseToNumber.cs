using System;
using System.Linq;

public class CondenseToNumber
{
    public static void Main()
    {
        //Input
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic

        int[] condesed = new int[numbers.Length - 1];

        if (numbers.Length.Equals(1))
        {
            Console.WriteLine(numbers[0]);
            return;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int b = 0; b < condesed.Length-i; b++)
            {
                condesed[b] = numbers[b] + numbers[b + 1];
            }

            numbers = condesed;
        }

        //Output
        Console.WriteLine(condesed[0]);
    }
}
