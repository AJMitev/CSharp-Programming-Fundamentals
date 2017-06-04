using System;

public class Race
{
    public static void Main()
    {
        //Input
        char firstPlayer = char.Parse(Console.ReadLine());
        char secondPlayer = char.Parse(Console.ReadLine());
        int moves = int.Parse(Console.ReadLine());

        //Logic
        int firstBoatScore = 0;
        int secondBoatScore = 0;
        bool isItBreaked = false;

        for (int i = 1; i <= moves; i++)
        {
            string currentMove = Console.ReadLine();
            int currentScore = currentMove.Length;

            if (firstBoatScore >= 50)
            {
                isItBreaked = true;
                Console.WriteLine(firstPlayer);
                break;

            }
            else if (secondBoatScore >= 50)
            {
                isItBreaked = true;
                Console.WriteLine(secondPlayer);
                break;
            }

            if (currentMove.Equals("UPGRADE"))
            {
                int temp = firstPlayer + 3;
                firstPlayer = (char)temp;
                temp = secondPlayer + 3;
                secondPlayer = (char)temp;
            }
            else
            {
                if (i % 2 == 1)
                {
                    firstBoatScore += currentScore;
                }
                else
                {
                    secondBoatScore += currentScore;
                }

            }
        }

        //Output if its not breaked
        if (!isItBreaked)
        {
            if (firstBoatScore > secondBoatScore)
            {
                Console.WriteLine(firstPlayer);
            }
            else
            {
                Console.WriteLine(secondPlayer);
            }
        }

    }
}