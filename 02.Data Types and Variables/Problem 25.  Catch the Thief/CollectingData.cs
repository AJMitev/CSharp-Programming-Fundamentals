using System;

class CollectingData
{
    static void Main()
    {
        //Input
        string dataType = Console.ReadLine();
        byte timesDataCollected = byte.Parse(Console.ReadLine());

        //Logic
        long minNumber = 0;
        long maxNumber = 0;

        switch (dataType)
        {
            case "sbyte": minNumber = sbyte.MinValue; maxNumber = sbyte.MaxValue; break;
            case "int": minNumber = int.MinValue; maxNumber = int.MaxValue;  break;
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

        //Output
        Console.WriteLine(id);
    }
}