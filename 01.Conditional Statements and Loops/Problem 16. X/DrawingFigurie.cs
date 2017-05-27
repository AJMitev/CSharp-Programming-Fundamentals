using System;

public class DrawingFigurie
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        for (int i = 0; i <= n/2-1; i++)
        {
            Console.WriteLine(new string(' ', i)+"x" +new string(' ',n-2-(i*2))+"x"+new string(' ',i));
        }
        Console.WriteLine(new string(' ',n/2) + "x" + new string(' ', n / 2));
        for (int k = n / 2 - 1; k >=0; k--)
        {
            Console.WriteLine(new string(' ', k) + "x" + new string(' ', n - 2 - (k * 2)) + "x" + new string(' ', k));
        }
    }
}