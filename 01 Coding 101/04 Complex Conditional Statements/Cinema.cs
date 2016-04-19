using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string[] screeningType = new string[] { "premiere", "normal", "discount" };
            double[] prices = new double[] { 12.00, 7.50, 5.00 };

            string screening = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double revenues = 0;
            for (int i = 0; i < 3; i++)
            {
                if (screening == screeningType[i])
                    revenues = prices[i] * rows * columns;
            }

            Console.WriteLine("{0:0.00} leva", revenues);
        }
    }
}