using System;

    public class Convertor
    {
        public static void Main()
        {
        //Input
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;

        //Output
            Console.WriteLine($"{kilometers:f2}");
        }
    }