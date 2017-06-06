using System;

public class DrawingFigurie
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintHedar(n);
        PrintMiddleLine(n);
        PrintHedar(n);
    }

    public static void PrintHedar(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    public static void PrintMiddleLine(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-");
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}
