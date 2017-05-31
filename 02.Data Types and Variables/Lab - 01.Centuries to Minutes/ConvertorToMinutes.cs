using System;

public class Convertor
{
    public static void Main()
    {
        //Input
        int centuries = int.Parse(Console.ReadLine());

        //Logic
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;

        //Output
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

    }
}
