using System;

public class Substring
{
    public static void Main()
    {

        //Input
        string text = Console.ReadLine();
        int lettersCount = int.Parse(Console.ReadLine());

        //Logic
        char keyChar = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {

            string matchedString = string.Empty;    //Here result will be saved

            if (text[i].Equals(keyChar))
            {
                hasMatch = true;
                int maxLoops = text.Length - i-1;   //Catching overflow exeption.
                if (maxLoops < lettersCount)
                {
                    lettersCount = maxLoops;
                }

                for (int k = i; k < i+lettersCount+1; k++)
                {
                    matchedString += text[k];

                    if (true)
                    {

                    }
                    
                }
       
                Console.WriteLine(matchedString);
                i += lettersCount;
            }
        }

        //If there is no match result will be printed
        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
