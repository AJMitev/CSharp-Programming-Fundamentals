using System;

public class ConvertNumberToString
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        long lastDigit = GetLastDigit(number);
        string digitToString = GetDigitToString(lastDigit);
        Console.WriteLine(digitToString);

    }

    public static int GetLastDigit(long number)
    {
        int result = 0;

        foreach (char symbol in number.ToString())
        {
            int digit = symbol - '0';
            result = digit;
        }

        return result;
    }

    public static string GetDigitToString(long number)
    {
        string numberInEnglish = string.Empty;

        switch (number)
        {
            case 0:
                numberInEnglish = "zero";
                break;
            case 1:
                numberInEnglish = "one";
                break;
            case 2:
                numberInEnglish = "two";
                break;
            case 3:
                numberInEnglish = "three";
                break;
            case 4:
                numberInEnglish = "four";
                break;
            case 5:
                numberInEnglish = "five";
                break;
            case 6:
                numberInEnglish = "six";
                break;
            case 7:
                numberInEnglish = "seven";
                break;
            case 8:
                numberInEnglish = "eight";
                break;
            case 9:
                numberInEnglish = "nine";
                break;
            default:
                Console.WriteLine("Wrong Input");
                break;
        }

        return numberInEnglish;
    }
}
