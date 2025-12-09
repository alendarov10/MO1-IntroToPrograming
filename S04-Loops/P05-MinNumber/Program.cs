class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minValue = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < minValue)
            {
                minValue = number;
            }
        }

        Console.WriteLine(minValue);
    }
}