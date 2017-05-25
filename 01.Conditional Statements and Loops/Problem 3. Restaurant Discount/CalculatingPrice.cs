using System;

public class CalculatingPrice
{
    public static void Main()
    {
        //Input
        int people = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        //Logic
        int hallPrice = 0;
        string hallName = string.Empty;

        if (people > 0 && people <= 50)
        {
            hallPrice = 2500;
            hallName = "Small Hall";
        }
        else if (people > 50 && people <= 100 )
        {
            hallPrice = 5000;
            hallName = "Terrace";
        }
        else if (people > 100 && people <= 120)
        {
            hallPrice = 7500;
            hallName = "Great Hall";
        }

        double discount = 0;
        double servicePrice = 0;

        switch (package)
        {
            case "Normal":
                discount = 0.05;
                servicePrice = 500;
                break;
            case "Gold":
                discount = 0.10;
                servicePrice = 750;
                break;
            case "Platinum":
                discount = 0.15;
                servicePrice = 1000;
                break;
            default:
                Console.WriteLine("There is no suck package!");
                break;
        }

        double totalPrice = (servicePrice + hallPrice) - ((servicePrice + hallPrice) * discount);
        double pricePerPerson = totalPrice / people;

        //Output
        if (people > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
        else
        {
            Console.WriteLine($"We can offer you the {hallName}\nThe price per person is {pricePerPerson:f2}$");
        }
    }
}