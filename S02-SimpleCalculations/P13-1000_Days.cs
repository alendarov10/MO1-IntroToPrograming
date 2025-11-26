using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        // Add 999 days because the start date counts as day 1
        DateTime resultDate = startDate.AddDays(999);

        Console.WriteLine(resultDate.ToString("dd-MM-yyyy"));
    }
}