using System;

class PrintingTriangle
{
    static void Main()
    {
        //Input
        int number = int.Parse(Console.ReadLine());

        //Logic
        for (int i = 1; i <=number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }
    }
}