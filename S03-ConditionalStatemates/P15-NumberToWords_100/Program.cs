using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(NumberToWords(number));
    }

    static string NumberToWords(int number)
    {
        string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                           "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                           "seventeen", "eighteen", "nineteen" };

        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number < 0 || number > 100)
        {
            return "Out of range";
        }
        else if (number < 20)
        {
            return units[number];
        }
        else if (number < 100)
        {
            int t = number / 10;
            int u = number % 10;
            if (u == 0)
                return tens[t];
            else
                return tens[t] + " " + units[u];
        }
        else // number == 100
        {
            return "one hundred";
        }
    }
}