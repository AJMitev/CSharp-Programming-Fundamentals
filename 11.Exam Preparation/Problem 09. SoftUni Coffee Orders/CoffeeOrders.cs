using System;
using System.Globalization;

public class CoffeeOrders
{
    public static void Main()
    {
        int orders = int.Parse(Console.ReadLine());

        decimal totalPrice = 0m;
        for (int i = 0; i < orders; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string orderDate = Console.ReadLine();
            long capsulesCount = int.Parse(Console.ReadLine());

            DateTime dateAsDate = DateTime.ParseExact(orderDate, "d/M/yyyy", CultureInfo.InvariantCulture);
            var daysInMonth = DateTime.DaysInMonth(dateAsDate.Year, dateAsDate.Month);

            var price = (daysInMonth * (long)capsulesCount) * pricePerCapsule;
            totalPrice += price;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
        }
        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}