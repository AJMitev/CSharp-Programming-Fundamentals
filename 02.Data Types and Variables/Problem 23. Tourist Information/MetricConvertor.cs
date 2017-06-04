using System;

public class MetricConvertor
{
    public static void Main()
    {
        //Input
        string imperialUnit = Console.ReadLine();
        double value = double.Parse(Console.ReadLine());

        //Logic
        double multiplyer = 0.0;
        string metricUnit = string.Empty;

        switch (imperialUnit)
        {
            case "miles": multiplyer = 1.6; metricUnit = "kilometers"; break;
            case "inches": multiplyer = 2.54; metricUnit = "centimeters"; break;
            case "yards": multiplyer = 0.91; metricUnit = "meters"; break;
            case "feet": multiplyer = 30; metricUnit = "centimeters"; break;
            case "gallons":multiplyer = 3.8; metricUnit = "liters"; break;
            default: Console.WriteLine("Wrong Input Data!"); break;
        }

        double convertedValue = value * multiplyer;

        //Output
        Console.WriteLine($"{value} {imperialUnit} = {convertedValue:f2} {metricUnit}");
    }
}