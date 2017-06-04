using System;

public class CalculateYears
{
    public static void Main()
    {
        //Input
        string dataType = Console.ReadLine();
        byte timesDataCollected = byte.Parse(Console.ReadLine());

        //Logic
        long id = GetId(dataType, timesDataCollected);  //Getting Prisoner ID

        sbyte divider = sbyte.MaxValue;
        if (id < 0)
        {
            divider = sbyte.MinValue;
        }

        double years = Math.Ceiling(id / (double)divider);


        //Output
        if (years > 1)
        {
            Console.WriteLine($"Prisoner with id {id} is sentenced to {years} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {id} is sentenced to {years} year");
        }

    }

    private static long GetId(string dataType, byte timesDataCollected)
    {
        long minNumber = 0;
        long maxNumber = 0;

        switch (dataType)
        {
            case "sbyte": minNumber = sbyte.MinValue; maxNumber = sbyte.MaxValue; break;
            case "int": minNumber = int.MinValue; maxNumber = int.MaxValue; break;
            case "long": minNumber = long.MinValue; maxNumber = long.MaxValue; break;
        }

        long id = minNumber;

        for (byte i = 0; i < timesDataCollected; i++)
        {
            long currentData = long.Parse(Console.ReadLine());

            if (currentData > id && currentData <= maxNumber)
            {
                id = currentData;
            }

        }

        return id;
    }

}