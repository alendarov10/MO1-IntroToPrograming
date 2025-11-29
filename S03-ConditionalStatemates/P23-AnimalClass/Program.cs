using System;

public class Program
{
    public static void Main(string[] args)
    {
        string animal = Console.ReadLine();

        if (animal == "dog")
        {
            Console.WriteLine("mammal");
        }
        else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
        {
            Console.WriteLine("reptile");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}