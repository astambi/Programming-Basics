using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine().ToLower();
            string outputMetric = Console.ReadLine().ToLower();

            double result = number / Coefficient(sourceMetric) * Coefficient(outputMetric);
            Console.WriteLine("{0} {1}", result, outputMetric);
        }

        static double Coefficient(string metric)
        {
            string[] metrics = new string[]         { "m", "km", "cm", "mm", "mi", "in", "ft", "yd" };
            double[] conversionRates = new double[] { 1, 0.001, 100, 1000, 0.000621371192, 39.3700787, 3.2808399, 1.0936133 };
            double coefficient = 0.0;

            for (int i = 0; i < 8; i++)
            {
                if (metric == metrics[i])
                    coefficient = conversionRates[i];
            }
            return coefficient;
        }
    }
}