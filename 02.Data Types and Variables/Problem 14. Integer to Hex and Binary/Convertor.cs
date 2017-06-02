using System;

public class Convertor
{
    public static void Main()
    {
        //Input
        int number = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine("{0}\n{1}",Convert.ToString(number,16).ToUpper(),Convert.ToString(number,2));
    }
}