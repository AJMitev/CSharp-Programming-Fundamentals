using System;
using System.Collections.Generic;
using System.Linq;

public class PrintProducts
{
    public static void Main()
    {
        //Logic
        var productsPrice = new Dictionary<string, double>();
        var productsQuantity = new Dictionary<string, int>();
        var productsCalculatedPrice = new Dictionary<string, double>();

        while (true)
        {
            string[] productsData = Console.ReadLine().Split().ToArray();
            if (productsData[0].Equals("stocked"))
            {
                break;
            }

            string productName = productsData[0];
            double productPrice = double.Parse(productsData[1]);
            int productQuantity = int.Parse(productsData[2]);

            if (!productsQuantity.ContainsKey(productName))
            {
                productsQuantity[productName] = 0;
            }

            productsQuantity[productName] += productQuantity;

            if (productsPrice.ContainsKey(productName))
            {
                productsPrice[productName] = 0.0;
            }

            productsPrice[productName] = productPrice;

            productsCalculatedPrice[productName] = productsPrice[productName] * productsQuantity[productName];
        }

        var productsNameList = new List<string>();

        foreach (var product in productsCalculatedPrice)
        {
            productsNameList.Add(product.Key);
        }

        for (int i = 0; i < productsCalculatedPrice.Count(); i++)
        {
            string name = productsNameList[i];

            Console.WriteLine($"{name}: ${productsPrice[name]:F2} * {productsQuantity[name]} = ${productsCalculatedPrice[name]:F2}");
        }
        Console.WriteLine(new string('-',30));
        Console.WriteLine($"Grand Total: ${productsCalculatedPrice.Values.Sum():f2}");


    }
}
