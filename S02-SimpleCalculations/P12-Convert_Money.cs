using System;

public class Program
{
    private const double BGNtoUSD = 1.79549;
    private const double BGNtoEUR = 1.95583;
    private const double BGNtoGBP = 2.53405;

    public static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        double result = 0.0;

        if (from == "BGN")
        {
            if (to == "USD") result = value / BGNtoUSD;
            else if (to == "EUR") result = value / BGNtoEUR;
            else if (to == "GBP") result = value / BGNtoGBP;
        }
        else if (from == "USD")
        {
            if (to == "BGN") result = value * BGNtoUSD;
            else if (to == "EUR") result = value * BGNtoUSD / BGNtoEUR;
            else if (to == "GBP") result = value * BGNtoUSD / BGNtoGBP;
        }
        else if (from == "EUR")
        {
            if (to == "BGN") result = value * BGNtoEUR;
            else if (to == "USD") result = value * BGNtoEUR / BGNtoUSD;
            else if (to == "GBP") result = value * BGNtoEUR / BGNtoGBP;
        }
        else if (from == "GBP")
        {
            if (to == "BGN") result = value * BGNtoGBP;
            else if (to == "USD") result = value * BGNtoGBP / BGNtoUSD;
            else if (to == "EUR") result = value * BGNtoGBP / BGNtoEUR;
        }

        Console.WriteLine($"{result:F2} {to}");
    }
}
