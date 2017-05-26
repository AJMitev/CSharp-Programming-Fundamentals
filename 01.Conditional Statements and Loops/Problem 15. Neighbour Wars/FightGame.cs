using System;

public class FightGame
{
    public static void Main()
    {
        //Input
        int peshosDMG = int.Parse(Console.ReadLine());
        int goshosDMG = int.Parse(Console.ReadLine());

        //Logic
        int peshosHealth = 100;
        int goshosHealth = 100;
        int roundsCount = 0;

        do
        {
             goshosHealth = goshosHealth - peshosDMG;
            roundsCount++;

            if (goshosHealth > 0)
            {
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {roundsCount}th round.");
                break;
            }

            if (roundsCount % 3 == 0)
            {
                peshosHealth += 10;
                goshosHealth += 10;
            }

            peshosHealth = peshosHealth - goshosDMG;
            roundsCount++;

            if (peshosHealth > 0)
            {
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {roundsCount}th round.");
                break;
            }

            if (roundsCount % 3 == 0)
            {
                peshosHealth += 10;
                goshosHealth += 10;
            }

        } while (true);

    }
}