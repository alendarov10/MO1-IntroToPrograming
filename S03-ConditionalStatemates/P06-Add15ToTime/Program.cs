using System;

public class Program
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;

        if (minutes >= 60)
        {
            minutes -= 60;
            hours++;
        }

        if (hours > 23)
        {
            hours = 0;
        }


        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}
