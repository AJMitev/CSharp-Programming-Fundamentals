using System;
using System.Collections.Generic;
using System.Linq;

public class SweetDesert
{
    public static void Main()
    {
        //Input
        double money = double.Parse(Console.ReadLine());
        int numberOfGuests = int.Parse(Console.ReadLine());
        double bananasPrice = double.Parse(Console.ReadLine());
        double eggsPrice = double.Parse(Console.ReadLine());
        double berriesPrice = double.Parse(Console.ReadLine());

        //Logic
        double numberOfSets = Math.Ceiling(numberOfGuests / 6.0);
        double moneyNeeded = ((bananasPrice * 2) + (eggsPrice * 4) + (berriesPrice * 0.2)) * numberOfSets;

        //Output
        if (money >= moneyNeeded)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", Math.Abs(money-moneyNeeded));
        }

    }
}