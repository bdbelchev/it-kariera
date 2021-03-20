using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double minorBorder = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            double diff = CalculateDiff(price, newPrice);
            bool isSignificant = CheckIfSignificant(minorBorder, diff);

            string message = DisplayChange(newPrice, price, diff, isSignificant);
            Console.WriteLine(message);

            price = newPrice;
        }
    }

    private static string DisplayChange(double current, double last, double diff, bool isSignificant)
    {
        string message = "";

        if (diff == 0)
        {
            message = $"NO CHANGE: {current}";
        }

        else if (!isSignificant)
        {
            message = $"MINOR CHANGE: {last} to {current} ({diff * 100:F2}%)";
        }

        else if (diff > 0)
        {
            message = $"PRICE UP: {last} to {current} ({diff * 100:F2}%)";
        }

        else if (diff < 0)
        {
            message = $"PRICE DOWN: {last} to {current} ({diff * 100:F2}%)";
        }

        return message;
    }

    private static bool CheckIfSignificant(double minorBorder, double diff)
    {
        return Math.Abs(diff) >= minorBorder;
    }

    private static double CalculateDiff(double last, double current)
    {
        return (current - last) / last;
    }
}