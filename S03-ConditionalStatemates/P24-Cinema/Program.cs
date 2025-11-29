using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        double price = 0.0;

        if (projectionType == "Premiere")
        {
            price = 12.00;
        }
        else if (projectionType == "Normal")
        {
            price = 7.50;
        }
        else if (projectionType == "Discount")
        {
            price = 5.00;
        }

        double total = rows * cols * price;

        if (projectionType == "Discount")
        {
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture) + " leva");
        }
        else
        {
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}