using System;

public class Program
{
    public static void Main(string[] args)
    {
        int size = 5; // size of the square

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); // move to next line
        }
    }
}