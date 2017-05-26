using System;

public class MagicNumber
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        //Logic
        int combos = 0;
        string lastCombination = string.Empty;

        for (int i = n; i <= m; i++)
        {

            for (int k = m; k >= n; k--)
            {
                combos++;
                int currentSum = i + k;

                if (currentSum.Equals(magicNumber))
                {
                    lastCombination = $"Number found! {i} + {k} = {magicNumber}";
                }
            }
        }

        //Output
        if (lastCombination.Contains("Number found"))
        {
            Console.WriteLine(lastCombination);
        }
        else
        {
            Console.WriteLine($"{combos} combinations - neither equals {magicNumber}");
        }
    }
}