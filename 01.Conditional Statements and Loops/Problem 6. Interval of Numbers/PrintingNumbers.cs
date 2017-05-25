using System;

public class PrintingNumbers
{
    public static void Main()
    {
        //Input
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        //Logic
        if (numberTwo < numberOne)
        {
            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;
        }
  
        for (int index = numberOne; index <= numberTwo; index++)
        {
            Console.WriteLine(index);
        }
    }
}