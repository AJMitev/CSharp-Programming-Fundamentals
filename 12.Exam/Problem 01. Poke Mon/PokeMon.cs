using System;

public class PokeMon
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int nAtStart = n;
        int pokeCntr = 0;

        while (n >= m)
        {

            n -= m;
            pokeCntr++;

            if (n == (double)(nAtStart / 2.0) && y > 0)
            {
                n = n / (int)y;
            }

        }

        Console.WriteLine($"{n}\n{pokeCntr}");
    }
}
    