class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int roofRows = (n + 1) / 2;
        int baseRows = n / 2;

        for (int row = 0; row < roofRows; row++)
        {
            int stars = (n % 2 == 0) ? 2 + row * 2 : 1 + row * 2;
            int dashes = (n - stars) / 2;

            Console.Write(new string('-', dashes));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', dashes));
        }

        for (int row = 0; row < baseRows; row++)
        {
            Console.Write("|");
            Console.Write(new string('*', n - 2));
            Console.WriteLine("|");
        }
    }
}
