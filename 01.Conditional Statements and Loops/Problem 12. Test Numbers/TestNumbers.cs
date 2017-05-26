using System;

public class TestNumbers
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int controlingNumber = int.Parse(Console.ReadLine());

        //Logic

        int combos = 0;
        int result = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                combos++;
                result = result + 3 * (i * j);
                if (result >= controlingNumber)
                {
                    break;
                }
            }
            if (result >= controlingNumber)
            {
                break;
            }
        }

        //Output
        if (result >= controlingNumber)
        {
            Console.WriteLine($"{combos} combinations\nSum: {result} >= {controlingNumber}");
        }
        else
        {
            Console.WriteLine($"{combos} combinations\nSum: {result}");
        }

    }
}