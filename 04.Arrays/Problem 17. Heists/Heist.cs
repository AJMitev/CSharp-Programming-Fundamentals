using System;

class Heist
{
    static void Main()
    {
        //Input
        string[] elementsPrices = Console.ReadLine().Split(' ');

        int priceOfJewels = int.Parse(elementsPrices[0]);
        int priceOfGold = int.Parse(elementsPrices[1]);

        int totalEarnings = 0;
        int totalExpenses = 0;

        //Logic
        while (true)
        {
            string[] arrayOfWords = Console.ReadLine().Split(' ');

            if (arrayOfWords[0].Equals("Jail"))
            {
                int moneyEarned = totalEarnings - totalExpenses;
                if (totalEarnings >= totalExpenses)
                {
                    Console.WriteLine($"Heists will continue. Total earnings: {moneyEarned}.");
                }
                else
                {
                    moneyEarned = Math.Abs(moneyEarned);
                    Console.WriteLine($"Have to find another job. Lost: {moneyEarned}.");
                }

                break;
            }

            totalExpenses += int.Parse(arrayOfWords[1]);
            char[] loot = arrayOfWords[0].ToCharArray();

            for (int i = 0; i < loot.Length; i++)
            {

                if (loot[i].Equals('%'))
                {
                    totalEarnings += priceOfJewels;
                }
                if (loot[i].Equals('$'))
                {
                    totalEarnings += priceOfGold;
                }
            }
        }
    }
}
