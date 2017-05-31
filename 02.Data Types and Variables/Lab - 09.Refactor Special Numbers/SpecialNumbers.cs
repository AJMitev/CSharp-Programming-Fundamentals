using System;

public class SpecialNumber
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        for (int i = 1; i <= n; i++)
        {
            int tens = i / 10;
            int ones = i % 10;
            int sum = tens + ones;
            bool isItSpecial = sum == 5 || sum == 7 || sum == 11;
            if (isItSpecial)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }

        }
    }
}