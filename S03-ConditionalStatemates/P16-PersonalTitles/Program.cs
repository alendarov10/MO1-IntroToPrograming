using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        double age = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        string gender = Console.ReadLine();

        if (gender == "f")
        {
            if (age < 16)
                Console.WriteLine("Miss");
            else
                Console.WriteLine("Ms.");
        }
        else if (gender == "m")
        {
            if (age < 16)
                Console.WriteLine("Master");
            else
                Console.WriteLine("Mr.");
        }
    }
}