using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Nacepin
{
    class Nacepin
    {
        static void Main(string[] args)
        {
            string[] country = new string[] { "US", "UK", "Chinese" };
            decimal[] FX = new decimal[] { 0.58m, 0.41m, 1 / 0.27m }; 
            decimal[] pricesBGN = new decimal[3]; 

            // get input
            for (int i = 0; i < 3; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                decimal weight = decimal.Parse(Console.ReadLine());
                pricesBGN[i] = price / FX[i] / weight;
            }
            // get min price, price difference min/max, min price country
            int minPriceIndex = 0;
            for (int i = 0; i < 3; i++)
            {
                if (pricesBGN[i] == pricesBGN.Min())
                {
                    minPriceIndex = i; // only 1 min price exists
                    break;
                }
            }

            Console.WriteLine("{0} store. {1:f2} lv/kg", country[minPriceIndex], pricesBGN.Min());
            Console.WriteLine("Difference {0:f2} lv/kg", pricesBGN.Max() - pricesBGN.Min());
        }
    }
}