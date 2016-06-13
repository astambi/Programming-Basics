using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fruit_Market
{
    class _01_Fruit_Market
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            string[] products = { "banana", "cucumber", "tomato", "orange", "apple" };
            decimal[] prices = { 1.80m, 2.75m, 3.20m, 1.60m, 0.86m };
            decimal[] discounts = { 0, 0, 0, 0, 0 };
            decimal totalPrice = 0;

            switch (day)
            {
                case "friday":
                    discounts[0] = discounts[1] = discounts[2] = discounts[3] = discounts[4] = 0.10m; break;
                case "sunday":
                    discounts[0] = discounts[1] = discounts[2] = discounts[3] = discounts[4] = 0.05m; break;
                case "tuesday":
                    discounts[0] = discounts[3] = discounts[4] = 0.20m; break;
                case "wednesday":
                    discounts[1] = discounts[2] = 0.10m; break;
                case "thursday":
                    discounts[0] = 0.30m; break;
                default: break;
            }
            for (int i = 0; i < 3; i++)
            {
                decimal quantity = decimal.Parse(Console.ReadLine());
                string product = Console.ReadLine().ToLower();
                for (int j = 0; j < 5; j++)
                    if (product == products[j])
                    {
                        totalPrice += quantity * prices[j] * (1 - discounts[j]);
                        break;
                    }
            }
            Console.WriteLine("{0:0.00}", totalPrice);
        }
    }
}
