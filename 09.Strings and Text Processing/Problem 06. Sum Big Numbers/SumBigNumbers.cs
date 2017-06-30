using System;
using System.Text;

public class SumBigNumbers
{
    public static void Main()
    {
        string numberOne = Console.ReadLine().TrimStart(new char[] { '0' });
        string numberTwo = Console.ReadLine().TrimStart(new char[] { '0' });

        StringBuilder result = new StringBuilder();

        if (numberOne.Length > numberTwo.Length)
        {
            numberTwo = numberTwo.PadLeft(numberOne.Length, '0');
        }
        else if (numberOne.Length < numberTwo.Length)
        {
            numberOne = numberOne.PadLeft(numberTwo.Length, '0');
        }
        char[] numberOneAsChar = numberOne.ToCharArray();
        char[] numberTwoAsChar = numberTwo.ToCharArray();

        sbyte carry = 0;
        sbyte addition = 0;
        for (int i = numberOneAsChar.Length - 1; i >= 0; i--)
        {
            sbyte currNumOne = sbyte.Parse(numberOneAsChar[i].ToString());
            sbyte currNumTwo = sbyte.Parse(numberTwoAsChar[i].ToString());
            currNumOne += addition;
            addition = 0;
            if (currNumOne + currNumTwo < 10)
            {
                result.Append(currNumOne + currNumTwo);
            }
            else
            {
                carry = (sbyte)((currNumOne + currNumTwo) % 10);
                result.Append(carry);
                addition = (sbyte)((currNumOne + currNumTwo) / 10);
            }
        }
        if (addition != 0)
        {
            result.Append(addition);
        }

        char[] endResult = result.ToString().ToCharArray();
        Array.Reverse(endResult);

        Console.WriteLine(string.Join("", endResult));
    }
}