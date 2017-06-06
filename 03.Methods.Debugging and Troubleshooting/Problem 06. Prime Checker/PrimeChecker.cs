using System;

public class PrimeChecker
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));

    }

    public static string IsPrime(long n)
    {
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }
}