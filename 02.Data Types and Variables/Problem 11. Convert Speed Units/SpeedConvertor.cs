using System;

public class SpeedConvertor
{
    public static void Main()
    {
        //Input
        float distance = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());

        //Logic
        float timeInSeconds = (((hours * 60) + minutes) * 60.0f) + seconds;
        float timeInHours = hours + (minutes / 60) + ((seconds / 60) / 60);
        float distanceInMiles = distance / 1609f;

        float metersPerKm = distance / timeInSeconds;
        float kilometersPerHour = (distance / timeInHours) / 1000f;
        float milesPerHour = distanceInMiles / timeInHours;

        //Output
        Console.WriteLine($"{metersPerKm}\n{kilometersPerHour}\n{milesPerHour}");

    }
}