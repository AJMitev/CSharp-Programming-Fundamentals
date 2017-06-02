using System;

public class Notifier
{
    public static void Main()
    {
        //Input
        int countPictures = int.Parse(Console.ReadLine());
        int filterTimeForOnePicture = int.Parse(Console.ReadLine());
        int filterFactor = int.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

        //Logic
        double filterPicture = Math.Ceiling(countPictures * (filterFactor / 100.0));
        double firstAnswer = (double)countPictures * filterTimeForOnePicture;
        double secondAnswer = (double)filterPicture * uploadTime;
        double answer = (double)(firstAnswer + secondAnswer);

        //Output
        TimeSpan time = TimeSpan.FromSeconds(answer);
        string str = time.ToString(@"d\:hh\:mm\:ss");
        Console.WriteLine(str);



    }
}