using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cinema
{
    class _01_Cinema
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            decimal[] prices = { 12.00m, 7.50m, 5.00m }; // Premiere, Normal, Discount 
            string[] projections = { "premiere", "normal", "discount" };

            decimal revenue = 0m;

            for (int i = 0; i < 3; i++)
                if (projectionType == projections[i])
                {
                    revenue = prices[i] * rows * columns;
                    break;
                }
            Console.WriteLine("{0:0.00} leva", revenue);
        }
    }
}
