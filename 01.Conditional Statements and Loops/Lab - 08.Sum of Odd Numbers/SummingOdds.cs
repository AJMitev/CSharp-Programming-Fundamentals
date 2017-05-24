using System;

public class SummingOdds
{
    public static void Main()
    {
        //Input
        int number = int.Parse(Console.ReadLine());

        //Logic
        int sum = 0;
        int cntr = 0;

        for (int i = 1; i <= 100; i ++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
                sum += i;
                cntr++;
            }
            if (cntr ==number)
            {
                break;
            }
        }

        //Output
        Console.WriteLine($"Sum: {sum}");
    }
}