public class Program
{
    public static void Main()
    {
        Console.Write("Enter grade: ");
        double grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent");
        }
    }
}