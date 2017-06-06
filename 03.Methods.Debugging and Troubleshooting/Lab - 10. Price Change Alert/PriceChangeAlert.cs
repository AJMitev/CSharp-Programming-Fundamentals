using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int numberOfStockPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStockPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double diviation = GetPercentage(lastPrice, currentPrice);
            bool hasDifference = HasDifference(diviation, threshold);

            string message = GetNotification(currentPrice, lastPrice, diviation, hasDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    public static string GetNotification(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
    {
        string to = string.Empty;
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return to;
    }

    public static bool HasDifference(double border, double isDiff)
    {
        if (Math.Abs(border) >= isDiff)
        {
            return true;
        }

        return false;
    }

    public static double GetPercentage(double lastPrice, double ccurrentPrice)
    {
        return (ccurrentPrice - lastPrice) / lastPrice;
    }
}