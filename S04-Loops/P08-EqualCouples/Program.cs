class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int previousSum = 0;
        int maxDiff = 0;
        bool firstPair = true;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int currentSum = a + b;

            if (!firstPair)
            {
                int diff = Math.Abs(currentSum - previousSum);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
            else
            {
                firstPair = false;
            }

            previousSum = currentSum;
        }

        if (maxDiff == 0)
        {
            Console.WriteLine($"Yes, value={previousSum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
