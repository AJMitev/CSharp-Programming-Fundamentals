using System;
using System.Linq;

public class SinoTheWallker
{
    public static void Main()
    {
        long[] timeLeaved = Console.ReadLine().Split(':').Select(long.Parse).ToArray();
        long stepsMade = long.Parse(Console.ReadLine());
        long secondsPerStep = long.Parse(Console.ReadLine());

        long timeToBack = stepsMade * secondsPerStep;
        double hoursToAdd = 0;
        double minutesToAdd = timeToBack / 60;
        if (minutesToAdd > 59)
        {
            hoursToAdd = minutesToAdd / 60;
            minutesToAdd = minutesToAdd % 60;
        }
        long secondsToAdd = timeToBack % 60;

        long totalSeconds = 0;
        long totalMinutes = 0;
        long totalHours = 0;

        totalSeconds = timeLeaved[2] + secondsToAdd;
        if (totalSeconds>59)
        {
            totalMinutes++;
            totalSeconds = totalSeconds % 60;
        }

        totalMinutes += timeLeaved[1] + (long)minutesToAdd;
        if (totalMinutes>59)
        {
            totalHours++;
            totalMinutes = totalMinutes % 60;
        }

        totalHours += timeLeaved[0] + (long)hoursToAdd;
        if (totalHours>23)
        {
            totalHours = totalHours % 24;
        }

        Console.WriteLine($"Time Arrival: {totalHours:D2}:{totalMinutes:D2}:{totalSeconds:D2}");
    }
}