using System;

public class ForeignLanguages
{
    public static void Main()
    {
        //Input
        string country = Console.ReadLine();
        string language = string.Empty;

        //Logic
        switch (country)
        {
            case "England":
            case "USA":
                language = "English";
                break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                language = "Spanish";
                break;
            default:
                language = "unknown";
                break;
        }

        //Output
        Console.WriteLine(language);
    }
}