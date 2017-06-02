using System;

class Refactor
{
    static void Main()
    {
        //Input
        int num = int.Parse(Console.ReadLine());

        //Logic
        for (int curNum = 2; curNum <= num; curNum++)
        {
            bool isPrime = true;
            for (int devider = 2; devider <= Math.Sqrt(curNum); devider++)
            {
                if (curNum % devider == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            //Output
            Console.WriteLine($"{curNum} -> {isPrime}");
        }
    }

}