class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter even number: ");
            string input = Console.ReadLine();

            try
            {
                int num = int.Parse(input);
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}