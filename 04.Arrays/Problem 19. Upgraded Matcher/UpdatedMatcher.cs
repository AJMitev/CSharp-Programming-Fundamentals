using System;
using System.Linq;

public class UpdatedMatcher
{
    public static void Main()
    {
        //Input
        string[] productsNames = Console.ReadLine().Split(' ');
        long[] productsQuantities = new long[productsNames.Length];
        string[] productsQuantitiesAsString = Console.ReadLine().Split(' ');
        double[] productsPrices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


        //Logic
        for (int i = 0; i < productsQuantitiesAsString.Length; i++)
        {
            productsQuantities[i] = long.Parse(productsQuantitiesAsString[i]);

        }

        long[] productsAvailableQuantity = new long[productsQuantities.Length];
        for (int i = 0; i < productsQuantities.Length; i++)
        {
            productsAvailableQuantity[i] = productsQuantities[i];
        }

        while (true)
        {
            string[] productRequest = Console.ReadLine().Split(' ');

            if (productRequest[0].Equals("done"))
            {
                break;
            }

            for (int i = 0; i < productsNames.Length; i++)
            {

                if (productRequest[0].Equals(productsNames[i]))
                {

                    if (productsAvailableQuantity[i] >= long.Parse(productRequest[1]))
                    {

                        double bill = productsPrices[i] * long.Parse(productRequest[1]);
                        Console.WriteLine($"{productsNames[i]} x {productRequest[1]} costs {bill:f2}");
                        productsAvailableQuantity[i] -= long.Parse(productRequest[1]);
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {productsNames[i]}");
                    }
                }
            }
        }
    }
}
