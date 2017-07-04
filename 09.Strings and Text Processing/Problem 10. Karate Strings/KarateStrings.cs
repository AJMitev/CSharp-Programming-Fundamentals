using System;

public class KarateStrings
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int punchPower = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Equals('>'))
            {
                punchPower += int.Parse(text[i + 1].ToString());

                if (text[i + 1] != '>' && punchPower > 0)
                {
                    text = text.Remove(i + 1, 1);
                    punchPower--;
                }
            }
            else
            {
                if (punchPower > 0)
                {
                    text = text.Remove(i, 1);
                    punchPower--;
                    i--;
                }
            }
        }

        Console.WriteLine(text);
    }
}