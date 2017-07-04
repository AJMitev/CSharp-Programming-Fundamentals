using System;

public class CharityMarathon
{
    public static void Main()
    {
        //Input
        int days = int.Parse(Console.ReadLine());
        int participition = int.Parse(Console.ReadLine());
        int averageLapsPerRunner = int.Parse(Console.ReadLine());
        int trackLenght = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        double moneyRaisedPerKm = double.Parse(Console.ReadLine());

        //Logic
        int maximumParticipiants = trackCapacity * days;

        if (maximumParticipiants<participition)
        {
            participition = maximumParticipiants;
        }

        double totalMeeters = (participition * averageLapsPerRunner) * (double)trackLenght;
        double totalKilometers = totalMeeters / 1000.00;
        double totalMoney = totalKilometers * moneyRaisedPerKm;

        //Output
        Console.WriteLine($"Money raised: {Math.Round(totalMoney, 2):f2}");
    }
}