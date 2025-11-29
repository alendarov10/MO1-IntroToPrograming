using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        bool onLeftOrRight = (x == x1 || x == x2) && (y >= y1 && y <= y2);
        bool onTopOrBottom = (y == y1 || y == y2) && (x >= x1 && x <= x2);

        if (onLeftOrRight || onTopOrBottom)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}