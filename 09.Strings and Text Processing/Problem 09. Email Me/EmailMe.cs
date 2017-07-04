using System;
using System.Linq;

public class EmailMe
{
    public static void Main()
    {
        string email = Console.ReadLine();

        var atIndex = email.IndexOf('@');

        var stringBeforeAt = email.Substring(0, atIndex);
        var stringAfterAt = email.Substring(atIndex+1);

        int leftSum = 0;
        int rightSum = 0;

        foreach (char c in stringBeforeAt)
        {
            leftSum += (int)c;
        }

        foreach (char c in stringAfterAt)
        {
            rightSum += (int)c;
        }

        int result = leftSum - rightSum;

        if (result >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}