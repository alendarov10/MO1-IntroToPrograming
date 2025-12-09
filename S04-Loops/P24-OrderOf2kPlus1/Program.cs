class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int current = 1;
        while (current <= n)
        {
            Console.WriteLine(current);
            current = current * 2 + 1;
        }
    }

}