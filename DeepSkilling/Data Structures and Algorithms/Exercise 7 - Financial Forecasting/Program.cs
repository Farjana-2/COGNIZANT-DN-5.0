using System;

namespace FinancialForecasting
{
    class Program
    {
        // Recursive function to calculate future value
        static double Forecast(double currentValue, double growthRate, int years)
        {
            // Base case
            if (years == 0)
            {
                return currentValue;
            }

            // Recursive call
            return Forecast(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Financial Forecasting ===");

            Console.Write("Enter Current Investment Value: ");
            double currentValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (e.g., 0.10 for 10%): ");
            double growthRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number of Years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = Forecast(currentValue, growthRate, years);

            Console.WriteLine();
            Console.WriteLine("Future Value after " + years + " years = " + futureValue);

            Console.ReadKey();
        }
    }
}