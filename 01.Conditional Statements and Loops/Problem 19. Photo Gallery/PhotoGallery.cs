using System;

public class PhotoGallery
{
    public static void Main()
    {
        //Input
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int sizeAsBytes = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        //Logic
        double size = 0;
        string sizeStandart = string.Empty;
        string photoOrientation = string.Empty;

        if (sizeAsBytes > 0 && sizeAsBytes <= 1024)
        {
            size = sizeAsBytes;
            sizeStandart = "B";
        }
        else if (sizeAsBytes > 1024 && sizeAsBytes <= 1048576)
        {
            size = sizeAsBytes / 1000;
            sizeStandart = "KB";
        }
        else
        {
            size = sizeAsBytes / 1000000.00;
            sizeStandart = "MB";
        }

        if (width > height)
        {
            photoOrientation = "landscape";
        }
        else if (width < height)
        {
            photoOrientation = "portrait";
        }
        else if (width.Equals(height))
        {
            photoOrientation = "square";
        }

        //Output
        Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:D2}");
        Console.WriteLine($"Size: {size}{sizeStandart}");
        Console.WriteLine($"Resolution: {width}x{height} ({photoOrientation})");

    }
}