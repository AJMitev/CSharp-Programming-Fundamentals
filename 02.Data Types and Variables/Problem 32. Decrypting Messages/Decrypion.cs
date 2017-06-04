using System;

public class Decrypion
{
    public static void Main()
    {
        //Input
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        //Logic
        string decrypted = string.Empty;

        for (int i = 0; i < n; i++)
        {
            char currChar = char.Parse(Console.ReadLine());
            int newChar = currChar + key;
            decrypted += (char)newChar;
        }

        //Logic
        Console.WriteLine(decrypted);
    }
}
