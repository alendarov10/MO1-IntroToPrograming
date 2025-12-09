public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i <= n; i++)
        {
            string s = $"{new string(' ', n - i)}{new string('*', i)}| {new string('*', i)}";

            Console.WriteLine(s);
        }
    }
}