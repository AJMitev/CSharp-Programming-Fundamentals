using System;

public class Multiplicator
{
    public static void Main()
    {
        //Input
        int multiplicator = int.Parse(Console.ReadLine());
        int startedInteger = int.Parse(Console.ReadLine());

        //Logic
        if (startedInteger <= 10)
        {
            for (int i = startedInteger; i <= 10; i++)
            {
                int sum = i * multiplicator;
                Console.WriteLine($"{multiplicator} X {i} = {sum}");
            }
        }
        else
        {
            int sum = startedInteger * multiplicator;
            Console.WriteLine($"{multiplicator} X {startedInteger} = {sum}");
        }
    }
}