using System;

public class Program
{
    public static void Main(string[] args)
    {
        double baseLength = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseLength * height;

        // Print with 2 decimal places
        Console.WriteLine(area.ToString("F2"));
    }
}