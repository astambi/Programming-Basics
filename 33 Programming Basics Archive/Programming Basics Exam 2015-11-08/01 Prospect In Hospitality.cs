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
            long[] personnel = new long[] { 0, 0, 0, 0, 0, 1, 1 };

            for (int i = 0; i < 5; i++)
                personnel[i] = long.Parse(Console.ReadLine());

            salaries[5] = decimal.Parse(Console.ReadLine()) * decimal.Parse(Console.ReadLine()); //salary in USD & FXusd
            salaries[6] = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal expenses = 0m;
            for (int i = 0; i < 7; i++)
                expenses += salaries[i] * personnel[i];

            Console.WriteLine("The amount is: {0:0.00} lv.", expenses);
            if (budget >= expenses)
                Console.WriteLine("YES \\ Left: {0:0.00} lv.", budget - expenses); // NB."\\" instead of "\"
            else
                Console.WriteLine("NO \\ Need more: {0:0.00} lv.", expenses - budget);
        }
    }
}