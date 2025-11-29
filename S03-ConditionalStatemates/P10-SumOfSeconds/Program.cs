using System;

public class Program
{
    public static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int totalSeconds = first + second + third;
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}