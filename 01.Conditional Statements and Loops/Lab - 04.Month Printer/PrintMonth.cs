using System;

public class MonthPrinter
{
    public static void Main()
    {
        //Input
        int monthAsNumber = int.Parse(Console.ReadLine());
        string monthAsString = string.Empty;

        //Logic
        switch (monthAsNumber)
        {
            case 1:
                monthAsString = "January";
                break;
            case 2:
                monthAsString = "February";
                break;
            case 3:
                monthAsString = "March";
                break;
            case 4:
                monthAsString = "April";
                break;
            case 5:
                monthAsString = "May";
                break;
            case 6:
                monthAsString = "June";
                break;
            case 7:
                monthAsString = "July";
                break;
            case 8:
                monthAsString = "August";
                break;
            case 9:
                monthAsString = "September";
                break;
            case 10:
                monthAsString = "October";
                break;
            case 11:
                monthAsString = "November";
                break;
            case 12:
                monthAsString = "December";
                break;
            default:
                monthAsString = "Error!";
                break;
        }

        //Output
        Console.WriteLine(monthAsString);

    }
}