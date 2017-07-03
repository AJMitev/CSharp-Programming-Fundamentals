using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Weather
{
    public static void Main()
    {
        string pattern = @"([A-Z]{2})(\d{2}\.\d{1,})([a-zA-Z]+)\b\|";

        var temperatureByCity = new Dictionary<string, double>();
        var weatherByCity = new Dictionary<string, string>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            bool isItMatch = Regex.IsMatch(input, pattern);

            if (isItMatch)
            {
                Match match = Regex.Match(input, pattern);
                string city = match.Groups[1].ToString();
                double temperature = double.Parse(match.Groups[2].ToString());
                string weatherType = match.Groups[3].ToString(); 

                if (!temperatureByCity.ContainsKey(city))
                {
                    temperatureByCity.Add(city,temperature);
                }
                temperatureByCity[city] = temperature;

                if (!weatherByCity.ContainsKey(city))
                {
                    weatherByCity.Add(city, weatherType);
                }
                weatherByCity[city] = weatherType;
            }

            input = Console.ReadLine();
        }

            foreach (var t in temperatureByCity.OrderBy(c=>c.Value))
            {
                string town = t.Key;
                Console.WriteLine($"{town} => {temperatureByCity[town]:f2} => {weatherByCity[town]}");
            }
    }
}
