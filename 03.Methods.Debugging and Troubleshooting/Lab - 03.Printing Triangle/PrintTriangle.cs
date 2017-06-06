using System;

public class PrintTriangle
{
    public static void Main()
    {
        int max = int.Parse(Console.ReadLine());
        PrintingTriangle(max);

    }
    public static void PrintingTriangle(int max)
    {
        for (int row = 1; row <= max; row++)
        {
            PrintColumns(row);
        }
        for (int row = max - 1; row >= 1; row--)
        {
            PrintColumns(row);
        }
    }

    public static void PrintColumns(int row)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write($"{col} ");
        }
        Console.WriteLine();
    }
}
