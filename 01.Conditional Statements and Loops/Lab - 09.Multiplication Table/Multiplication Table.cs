using System;

public class MultiplicationTable
{
    public static void Main()
    {
        //Input
        int multiplicator = int.Parse(Console.ReadLine());

        //Logic
        for (int i = 1; i <= 10; i++)
        {
            int sum = i * multiplicator;
            Console.WriteLine($"{multiplicator} X {i} = {sum}");
        }
    }
}