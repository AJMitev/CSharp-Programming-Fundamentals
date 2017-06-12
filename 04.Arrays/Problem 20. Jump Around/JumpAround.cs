using System;
using System.Linq;

public class JumpAround
{
    public static void Main()
    {
        //Input
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int sum = numbers[0];
        int currentNumber = 0;

        while (true)
        {
            int temp = currentNumber;

            try
            {
                currentNumber = temp + numbers[temp];
                sum += numbers[currentNumber];
            }
            catch (Exception)
            {

                try
                {
                    currentNumber = temp - numbers[temp];
                    sum += numbers[currentNumber]; ;
                }
                catch (Exception)
                {

                    break;
                }
            }
        }

        Console.WriteLine(sum);
    }
}