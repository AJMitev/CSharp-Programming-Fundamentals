using System;
using System.Collections.Generic;

public class PrimesInGivenRange
{
    public static void Main()
    {
        int startNumbe = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        List<int> primesInRagne = FindPrimesInRange(startNumbe, endNumber);

        Console.WriteLine(string.Join(", ", primesInRagne));
    }

    public static List<int> FindPrimesInRange(int startNumber, int endNumber)
    {
        List<int> primeNumbers = new List<int>();

        for (int currentNum = startNumber; currentNum <= endNumber; currentNum++)
        {
            if (IsPrime(currentNum))
            {
                primeNumbers.Add(currentNum);
            }
        }

        return primeNumbers;
    }

    public static bool IsPrime(int n)
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
            return true;
        }
        else
        {
            return false;
        }
    }
}