using System;
using System.Linq;

public class InventoryMatcher
{
    public static void Main()
    {
        //Input
        string[] productsNames = Console.ReadLine().Split(' ');
        long[] productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        decimal[] productsPrices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        //Logic
        while (true)
        {
            string[] productName = Console.ReadLine().Split(' ');

            if (productName[0].Equals("done"))
            {
                break;
            }

            int productIndex = 0;
            for (int i = 0; i < productsNames.Length; i++)
            {
                if (productName[0].Equals(productsNames[i]))
                {
                    productIndex = i;
                }
            }

            Console.WriteLine($"{productsNames[productIndex]} costs: {productsPrices[productIndex]}; Available quantity: {productsQuantities[productIndex]}");
        }
    }
}