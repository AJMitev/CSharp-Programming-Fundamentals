using System;

public class TheatrePromotion
{
    public static void Main()
    {
        //Input
        string dayType = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        //Logic
        int ticketPrice = 0;

        if (dayType.Equals("Weekday"))
        {
            if (age >= 0 && age <= 18)
            {
                ticketPrice = 12;
            }
            else if (age > 18 && age <= 64)
            {
                ticketPrice = 18;
            }
            else if (age > 64 && age <= 122)
            {
                ticketPrice = 12;
            }
        }
        else if (dayType.Equals("Weekend"))
        {
            if (age >= 0 && age <= 18)
            {
                ticketPrice = 15;
            }
            else if (age > 18 && age <= 64)
            {
                ticketPrice = 20;
            }
            else if (age > 64 && age <= 122)
            {
                ticketPrice = 15;
            }
        }
        else if (dayType.Equals("Holiday"))
        {
            if (age >= 0 && age <= 18)
            {
                ticketPrice = 5;
            }
            else if (age > 18 && age <= 64)
            {
                ticketPrice = 12;
            }
            else if (age > 64 && age <= 122)
            {
                ticketPrice = 10;
            }
        }

        //Output
        if (ticketPrice!=0)
        {
            Console.WriteLine($"{ticketPrice}$");
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}