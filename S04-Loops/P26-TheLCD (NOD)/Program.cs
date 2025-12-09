class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());

        while (b != 0)
        {
            long r = a % b;
            a = b;
            b = r;
        }

        Console.WriteLine(a);
    }
}
