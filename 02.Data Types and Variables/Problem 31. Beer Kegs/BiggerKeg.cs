using System;

public class BiggerKeg
{
    public static void Main()
    {
        //Input
        int numberOfLines = int.Parse(Console.ReadLine());

        string biggestKeg = string.Empty;
        double biggestVolume = 0.0;

        for (int i = 0; i < numberOfLines ; i++)
        {
            string kegModel = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double currentVolume = Math.PI * Math.Pow(radius,2) * height;

            if (currentVolume > biggestVolume)
            {
                biggestKeg = kegModel;
                biggestVolume = currentVolume;
            }
           
        }

        //Output
        Console.WriteLine(biggestKeg);
    }
}