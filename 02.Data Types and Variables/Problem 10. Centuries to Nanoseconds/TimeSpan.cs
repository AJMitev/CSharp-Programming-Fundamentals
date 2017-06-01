using System;
using System.Numerics;

public class TimeSpan
{
    public static void Main()
    {
        //Input
        int centuries = int.Parse(Console.ReadLine());

        //Logic
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;
        ulong seconds = (ulong)minutes * 60;
        BigInteger milliseconds = seconds * 1000;
        BigInteger microseconds = milliseconds * 1000;
        BigInteger nanoseconds = milliseconds * 1000000;

        //Output
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} " +
            $"milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}