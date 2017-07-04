using System;
using System.Linq;

public class DecriptingMessage
{
    public static void Main()
    {
        string[] encryptedMessage = Console.ReadLine().Split('|').ToArray();
        string decryptedMessage = string.Empty;

        foreach (var code in encryptedMessage)
        {
            int totalAsciiSum = 0;
            var repreatedOnes = code.Split(new[] { '0'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var repreatedZeros = code.Split(new[] { '1' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            char[] allOnes = code.Where(c => c.Equals('1')).ToArray();
            char[] allZeros = code.Where(c => c.Equals('0')).ToArray();

            var repeatedNumbers = 0;

            foreach (var ones in repreatedOnes.Where(n => n.Length > 1))
            {
                repeatedNumbers += ones.Count();
            }

            foreach (var zero in repreatedZeros.Where(n => n.Length > 1))
            {
                repeatedNumbers += zero.Count();
            }

            totalAsciiSum = (allOnes.Count()*5) + (allZeros.Count()*3) + repeatedNumbers;
            decryptedMessage += (char)totalAsciiSum;
        }

        Console.WriteLine(decryptedMessage);
    }
}

