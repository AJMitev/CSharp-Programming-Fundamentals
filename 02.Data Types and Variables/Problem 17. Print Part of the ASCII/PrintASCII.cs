using System;

public class PrintASCII
{
    public static void Main()
    {
        //Input
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        //
        for (int i =start; i <=end; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}