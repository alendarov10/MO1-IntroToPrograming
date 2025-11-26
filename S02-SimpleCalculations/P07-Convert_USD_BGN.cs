using System;

public class Program
{
    public static void Main(string[] args)
    {
        const decimal usdToBgnRate = 1.79549m; // Correct rate from tests
        decimal usd = decimal.Parse(Console.ReadLine());

        decimal bgn = usd * usdToBgnRate;
        Console.WriteLine($"{bgn:F2} BGN");
    }
}
