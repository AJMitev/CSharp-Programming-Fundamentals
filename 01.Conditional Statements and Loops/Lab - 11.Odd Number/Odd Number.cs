using System;

class OddNumber
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());

            int numberAbs = Math.Abs(number);

            if (numberAbs % 2 == 1)
            {
                Console.WriteLine($"The number is: {numberAbs}");
                break;
            }

            Console.WriteLine("Please write an odd number.");
        }
    }
}