using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int rows = (n % 2 == 0) ? n - 1 : n;
        int midRow = rows / 2;

        for (int row = 0; row < rows; row++)
        {
            int leftRight = Math.Abs(midRow - row);
            int mid = n - 2 * leftRight - 2;

            Console.Write(new string('-', leftRight));
            Console.Write("*");
            if (mid >= 0)
            {
                Console.Write(new string('-', mid));
                Console.Write("*");
            }
            Console.WriteLine(new string('-', leftRight));
        }
    }
}