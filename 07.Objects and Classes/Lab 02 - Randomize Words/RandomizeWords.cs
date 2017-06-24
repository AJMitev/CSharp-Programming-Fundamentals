using System;

public class RandomizeWords
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');
        Random rnd = new Random();

        for (int positionOne = 0; positionOne < words.Length; positionOne++)
        {
            int positionTwo = rnd.Next(words.Length);
            if (positionTwo != positionOne)
            {
                string oldWord = words[positionOne];
                words[positionOne] = words[positionTwo];
                words[positionTwo] = oldWord;
            }
        }

        Console.WriteLine(string.Join("\r\n", words));
    }
}
