using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double priceThreshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        double lastPrice = firstPrice;

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = GetPercentageDifference(lastPrice, currentPrice);
            bool isSignificantDifference = PriceChangeAlert.isSignificantDifference(difference, priceThreshold * 100);
            string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentprice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentprice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentprice, difference);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentprice, difference);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentprice, difference);
        }

        return result;
    }
    private static bool isSignificantDifference(double difference, double priceThrashold)
    {
        if (Math.Abs(difference) >= priceThrashold)
        {
            return true;
        }
            
        return false;
    }
    private static double GetPercentageDifference(double lastPrice, double currentPrice)
    {
        double result = ((currentPrice - lastPrice) / lastPrice) * 100;
        return result;
    }
}
