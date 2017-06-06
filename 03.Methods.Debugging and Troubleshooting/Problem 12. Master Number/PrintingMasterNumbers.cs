using System;
using System.Collections.Generic;

public class PrintingMasterNumbers
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());


        for (int currentNum = 1; currentNum <= number; currentNum++)
        {
            if (IsPalindrome(currentNum) && SumOfDigits(currentNum) && ContainsEvenDigitt(currentNum)) //
            {
                Console.WriteLine(currentNum);
            }
        }

    }

    public static bool IsPalindrome(int number)
    {

        string str = number.ToString();
        if (str.Length < 4 && str[0] == str[str.Length - 1])
        {
            return true;
        }
        else if (str.Length < 6 &&
            (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]))
        {
            return true;
        }
        else if (str.Length < 8 &&
           (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]
           && str[2] == str[str.Length - 3]))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static bool SumOfDigits(int number)
    {
        int sumOfDigits = 0;
        int digits = number;

        while (digits > 0)
        {
            sumOfDigits += digits % 10;
            digits = digits / 10;
        }


        if (sumOfDigits % 7 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool ContainsEvenDigitt(int number)
    {
        string str = number.ToString();
        int evenCounter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            int currentDigit = int.Parse(str[i].ToString());
            if (currentDigit % 2 == 0)
            {
                evenCounter++;
            }
        }
        if (evenCounter > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}