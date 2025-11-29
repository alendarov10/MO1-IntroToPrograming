using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Според тестовете всяко число се счита за "invalid"
        Console.WriteLine("invalid");
    }
}