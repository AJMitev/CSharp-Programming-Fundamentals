using System;

public class Counter
{
    public static void Main()
    {
        //Input
        int bpm = int.Parse(Console.ReadLine());
        int numberOfBeats = int.Parse(Console.ReadLine());

        //Logic
        double bars = numberOfBeats / 4.0;
        double seconds = numberOfBeats * 60.0 / bpm;
        int minutes = (int)seconds / 60;
        seconds -= minutes * 60;

        //Output
        Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {Math.Floor(seconds)}s");
    }
}