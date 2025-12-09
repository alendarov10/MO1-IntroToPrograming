class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int num;
                if (row + col < n)
                {
                    num = row + col + 1;
                }
                else
                {
                    num = 2 * n - (row + col + 1);
                }
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
