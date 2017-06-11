using System;
using System.Linq;

public class CompareCharArrays
{
    public static void Main()
    {
        //Input
        char[] firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        //Logic

        if (firstCharArray.Length < secondCharArray.Length)
        {
            Console.WriteLine("{0}\n{1}", string.Join("", firstCharArray), string.Join("", secondCharArray));
        }
        else if (firstCharArray.Length > secondCharArray.Length)
        {
            Console.WriteLine("{0}\n{1}", string.Join("", secondCharArray), string.Join("", firstCharArray));
        }
        else if (firstCharArray.Length == secondCharArray.Length)
        {
            for (int i = 0; i < Math.Min(firstCharArray.Length, secondCharArray.Length); i++)
            {

                if (firstCharArray[i] > secondCharArray[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", secondCharArray), string.Join("", firstCharArray));
                    break;
                }
                if (secondCharArray[i] > firstCharArray[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", firstCharArray), string.Join("", secondCharArray));
                    break;
                }
                if (secondCharArray[i] == firstCharArray[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", firstCharArray), string.Join("", secondCharArray));
                    break;
                }
            }
        }
    }
}