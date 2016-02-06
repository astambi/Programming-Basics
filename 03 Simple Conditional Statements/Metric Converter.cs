using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            double coefficient1 = 0.0;
            double coefficient2 = 0.0;

            //convertion source measure to m
            if (sourceMetric == "km")
                coefficient1 = 0.001;
            else if (sourceMetric == "m")
                coefficient1 = 1;
            else if (sourceMetric == "cm")
                coefficient1 = 100;
            else if (sourceMetric == "mm")
                coefficient1 = 1000;
            else if (sourceMetric == "mi")
                coefficient1 = 0.000621371192;
            else if (sourceMetric == "in")
                coefficient1 = 39.3700787;
            else if (sourceMetric == "ft")
                coefficient1 = 3.2808399;
            else if (sourceMetric == "yd")
                coefficient1 = 1.0936133;

            //conversion m dest measure
            if (outputMetric == "km")
                coefficient2 = 0.001;
            else if (outputMetric == "m")
                coefficient2 = 1;
            else if (outputMetric == "cm")
                coefficient2 = 100;
            else if (outputMetric == "mm")
                coefficient2 = 1000;
            else if (outputMetric == "mi")
                coefficient2 = 0.000621371192;
            else if (outputMetric == "in")
                coefficient2 = 39.3700787;
            else if (outputMetric == "ft")
                coefficient2 = 3.2808399;
            else if (outputMetric == "yd")
                coefficient2 = 1.0936133;

            number = number / coefficient1 * coefficient2;
            Console.WriteLine("{0} {1}", number, outputMetric);
        }
    }
}