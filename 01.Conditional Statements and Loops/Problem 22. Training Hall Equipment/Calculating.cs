using System;

public class Calculating
{
    public static void Main()
    {
        //Input
        double budget = double.Parse(Console.ReadLine());
        int items = int.Parse(Console.ReadLine());

        //Logic
        double total = 0.0;

        for (int i = 0; i < items; i++)
        {
            string productName = Console.ReadLine();
            double productPrice = double.Parse(Console.ReadLine());
            int productQuantity = int.Parse(Console.ReadLine());

            total += productPrice * productQuantity;

            if (productQuantity > 1)
            {
                Console.WriteLine($"Adding {productQuantity} {productName}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {productQuantity} {productName} to cart.");
            }
        }

        //Output
        Console.WriteLine($"Subtotal: ${total:f2}");

        double moneyLeft = budget - total;

        if (moneyLeft >= 0)
        {
            Console.WriteLine($"Money left: ${moneyLeft:f2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):f2} more.");
        }

    }
}