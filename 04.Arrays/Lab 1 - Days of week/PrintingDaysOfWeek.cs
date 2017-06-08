using System;

public class PrintingDaysOfWeek
{
    public static void Main()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int someDay = int.Parse(Console.ReadLine());

        if (someDay > 0 && someDay <= 7)
        {
            Console.WriteLine(daysOfWeek[someDay - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }

    }
}