using System;
using System.Collections.Generic;
using System.Linq;

public class PrintMessage
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] phrases = new string[] 
        { "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product." };

        string[] events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

        string[] city = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

        var random = new Random();

        for (int i = 0; i  <  n; i++)
        {
           var phraseIndex = random.Next(0, 6);
            var eventIndex = random.Next(0, 7);
            var authorIndex = random.Next(0, 8);
            var citiesIndex = random.Next(0, 5);

            Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} – {city[citiesIndex]}.");
        }
    }
}