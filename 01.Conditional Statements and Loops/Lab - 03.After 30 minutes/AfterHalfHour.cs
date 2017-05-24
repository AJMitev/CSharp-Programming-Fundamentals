using System;

public class AfterHalfHour
{
    public static void Main(string[] args)
    {
        //Input
        double hours = double.Parse(Console.ReadLine());
        double minutes = double.Parse(Console.ReadLine()) + 30;

        //Logic
        if (hours <= 23 && minutes <= 59)
        {
            Console.WriteLine($"{hours}:{minutes:00}");
        }
        if (hours < 23 && minutes > 59)
        {
            hours = hours + 1;
            minutes = minutes - 60;
            Console.WriteLine($"{hours}:{minutes:00}");
        }
        else if (minutes > 59 && hours >= 23)
        {
            Console.WriteLine($"0:{minutes - 60:00}");
        }
    }
}