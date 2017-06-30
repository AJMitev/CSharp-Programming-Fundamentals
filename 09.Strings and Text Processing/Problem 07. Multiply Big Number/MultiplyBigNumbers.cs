using System;
using System.Text;

public class MultiplyBigNumbers
{
    public static void Main()
    {
        char[] number = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray();
        char[] multiplicator = Console.ReadLine().ToCharArray();

        StringBuilder result = new StringBuilder();

        int reminder = 0;
        
        for (int i = 0; i<multiplicator.Length; i++)
        { 
            for (int k = number.Length - 1; k >= 0; k--)
            {
                sbyte currMultiplicator = sbyte.Parse(multiplicator[i].ToString());
                sbyte currNumber = sbyte.Parse(number[k].ToString());

                if (currMultiplicator.Equals(0))
                {
                    result.Append(0);
                    break;
                }

                if ((currNumber * currMultiplicator) + reminder >= 10)
                {
                    int currResult = ((currNumber * currMultiplicator) + reminder) % 10;
                    result.Append(currResult);
                    reminder = ((currNumber * currMultiplicator) + reminder) / 10;
                }
                else
                {
                    int currentResult = (currNumber * currMultiplicator) + reminder;
                    reminder = 0;
                    result.Append(currentResult);
                }
            }
            if (reminder != 0)
            {
                result.Append(reminder);
            }
        }

        char[] endResult = result.ToString().ToCharArray();
        Array.Reverse(endResult);

        Console.WriteLine(string.Join("", endResult));
    }
}