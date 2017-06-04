using System;

public class WeatherForecast
{
    public static void Main()
    {
        //Input
        string input = Console.ReadLine();

        //Logic
        try
        {
            long number = long.Parse(input);

           
            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine($"Cloudy");
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine($"Windy");
            }
        }
        catch (Exception)
        {
            try
            {
                double number = double.Parse(input);
                Console.WriteLine("Rainy");

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Input");
            }
          
        }

    }
}