using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string weekday = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            string[] products = new string[]            {"banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };
            double[] pricesWeekend = new double[]       {2.70, 1.25, 0.90, 1.60, 3.00, 5.60, 4.20 };
            double[] pricesBusinessDay = new double[]   {2.50, 1.20, 0.85, 1.45, 2.70, 5.50, 3.85 };

            for (int i = 0; i < 7; i++)
            {
                if (fruit == products[i])
                {
                    if (weekday == "saturday" || weekday == "sunday")
                        price = pricesWeekend[i];
                    else if (weekday == "monday" || weekday == "tuesday" || weekday == "wednesday" || weekday == "thursday" || weekday == "friday")
                        price = pricesBusinessDay[i];
                }
            }

            if (price > 0)
                Console.WriteLine("{0:f2}", price * quantity);
            else
                Console.WriteLine("error");
        }
    }
}