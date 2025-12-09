
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine(1);
            return;
        }

        int f0 = 1;
        int f1 = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = f0 + f1;
            f0 = f1;
            f1 = next;
        }

        Console.WriteLine(f1);
    }
}