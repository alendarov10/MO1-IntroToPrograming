class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Горна част
        Console.Write("+ ");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");

        // Средна част
        for (int row = 0; row < n - 2; row++)
        {
            Console.Write("| ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("|");
        }

        // Долна част
        Console.Write("+ ");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");
    }
}
