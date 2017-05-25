using System;

public class PrintingPrice
{
    public static void Main()
    {
        //Input
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        //Logic
        string drink = string.Empty;
        double price = 0.0;

        switch (profession)
        {
            case "Athlete":
                drink = "Water";
                price = 0.70;
                break;
            case "Businessman":
            case "Businesswoman":
                drink = "Coffee";
                price = 1.00;
                break;
            case "SoftUni Student":
                drink = "Beer";
                price = 1.70;
                break;
            default:
                drink = "Tea";
                price = 1.20;
                break;
        }

        double totalPrice = quantity * price;

        //Logic
        Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
    }
}