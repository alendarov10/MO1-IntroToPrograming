
public class Program
{
    public static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string inputUnit = Console.ReadLine();
        string outputUnit = Console.ReadLine();

        // convert input to meters
        double meters = value;

        switch (inputUnit)

        {
            case "mm": meters = value / 1000; break;
            case "cm": meters = value / 100; break;
            case "mi": meters = value / 0.000621371192; break;
            case "in": meters = value / 39.370787; break;
            case "km": meters = value / 0.001; break;
            case "ft": meters = value / 3.2808399; break;
            case "yd": meters = value / 1.0936133; break;
        }

        // convert meters to output unit
        double result = meters;

        switch (outputUnit)
        {
            case "mm": result = meters * 1000; break;
            case "cm": result = meters * 100; break;
            case "mi": result = meters * 0.000621371192; break;
            case "in": result = meters * 39.370787; break;
            case "km": result = meters * 0.001; break;
            case "ft": result = meters * 3.2808399; break;
            case "yd": result = meters * 1.0936133; break;
        }

        Console.WriteLine($"{result} {outputUnit}");
    }
}
