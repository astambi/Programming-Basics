using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine().ToLower();
            string outputMetric = Console.ReadLine().ToLower();

            number = number / ConversionCoefficient(sourceMetric) * ConversionCoefficient(outputMetric);
            Console.WriteLine("{0} {1}", number, outputMetric);
        }

        static double ConversionCoefficient(string metric)
        {
            double coefficient = 0.0;
            if (metric == "km")
                coefficient = 0.001;
            else if (metric == "m")
                coefficient = 1;
            else if (metric == "cm")
                coefficient = 100;
            else if (metric == "mm")
                coefficient = 1000;
            else if (metric == "mi")
                coefficient = 0.000621371192;
            else if (metric == "in")
                coefficient = 39.3700787;
            else if (metric == "ft")
                coefficient = 3.2808399;
            else if (metric == "yd")
                coefficient = 1.0936133;
            return coefficient;
        }
    }
}
