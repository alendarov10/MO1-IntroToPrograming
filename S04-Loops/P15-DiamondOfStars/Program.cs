class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Горна част
        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        // Долна част
        for (int row = n - 1; row >= 1; row--)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}