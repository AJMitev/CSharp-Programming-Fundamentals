using System;

public class GameTime
{
    public static void Main()
    {
        //Input
        decimal currentBalance = decimal.Parse(Console.ReadLine());

        //Logic
        string currentGame = string.Empty;
        decimal gamePrice = 0.0m;
        decimal spent = 0.0m;

        do
        {
            currentGame = Console.ReadLine();

            if (currentGame.Equals("Game Time"))
            {
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${currentBalance:f2}");
                break;
            }

            switch (currentGame.ToLower())
            {
                case "outfall 4": gamePrice = 39.99m; break;
                case "cs: og": gamePrice = 15.99m; break;
                case "zplinter zell": gamePrice = 19.99m; break;
                case "honored 2": gamePrice = 59.99m; break;
                case "roverwatch": gamePrice = 29.99m; break;
                case "roverwatch origins edition": gamePrice = 39.99m; break;
                default:  gamePrice = -10; break;
            }

            if (gamePrice < 0)
            {
                Console.WriteLine("Not Found");
            }
            if (currentBalance < gamePrice)
            {
                Console.WriteLine("Too Expensive");
                continue;
            }
            else if (gamePrice > 0)
            {
                currentBalance -= gamePrice;
                spent += gamePrice;
                Console.WriteLine($"Bought {currentGame}");
            }

            if (currentBalance.Equals(0))
            {
                Console.WriteLine("Out of money!");
                break;
            }
        } while (true);
    }
}