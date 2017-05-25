using System;

public class PrintingDrink
{
    public static void Main()
    {
        //Input
        string profession = Console.ReadLine();

        //Logic
        string drink = string.Empty;

        switch (profession)
        {
            case "Athlete":
                drink = "Water";
                break;
            case "Businessman":
            case "Businesswoman":
                drink = "Coffee";
                break;
            case "SoftUni Student":
                drink = "Beer";
                break;
            default:
                drink = "Tea";
                break;
        }

        //Logic
        Console.WriteLine(drink);
    }
}