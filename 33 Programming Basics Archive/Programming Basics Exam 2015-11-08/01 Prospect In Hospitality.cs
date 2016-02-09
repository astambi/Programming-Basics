using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Prospect_In_Hospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] salaries = new decimal[] { 1500.04m, 2102.10m, 1465.46m, 2053.33m, 3010.98m, 0m, 0m };
            long[] numPersonel = new long[] { 0, 0, 0, 0, 0, 1, 1 };

            for (int i = 0; i < 5; i++)
                numPersonel[i] = long.Parse(Console.ReadLine());

            salaries[5] = decimal.Parse(Console.ReadLine()) * decimal.Parse(Console.ReadLine()); //salary in USD & FX
            salaries[6] = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal expenses = 0m;
            for (int i = 0; i < 7; i++)
                expenses += salaries[i] * numPersonel[i];

            Console.WriteLine("The amount is: {0:0.00} lv.", expenses);
            string symbol = "\\"; //!
            if (budget >= expenses)
                Console.WriteLine("YES {1} Left: {0:0.00} lv.", budget - expenses, symbol);
            else
                Console.WriteLine("NO {1} Need more: {0:0.00} lv.", expenses - budget, symbol);
        }
    }
}