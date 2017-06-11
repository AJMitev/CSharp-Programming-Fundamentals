using System;

public class Sieve
{
    public static void Main()
    {
        //Input
        int number = int.Parse(Console.ReadLine());

        //Logic
        bool[] primes = new bool[number + 1];

        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = true;
        }

        primes[0] = primes[1] = false;

        for (int i = 0; i <= number; i++)
        {
            if (!primes[i])
            {
                continue;
            }

            Console.Write(i  +  " ");

            for (int p = 2 * i; p <= number; p += i)
            {
                primes[p] = false;
            }
        }

        Console.WriteLine();
    }
}