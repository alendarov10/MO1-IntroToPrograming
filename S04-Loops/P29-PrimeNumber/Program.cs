class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("Not Prime");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }
}
