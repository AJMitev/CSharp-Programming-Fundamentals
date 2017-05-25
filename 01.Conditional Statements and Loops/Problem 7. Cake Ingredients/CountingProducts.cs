using System;

public class CountingProducts
{
    public static void Main()
    {
        int counter = 0;
        do
        {
            string ingredient = Console.ReadLine();

            if (ingredient.Equals("Bake!"))
            {
                Console.WriteLine($"Preparing cake with {counter} ingredients.");
                break;
            }
            else
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }

        } while (true);
    }
}