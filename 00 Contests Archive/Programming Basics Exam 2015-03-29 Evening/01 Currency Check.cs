using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Currency_Check
{
    class Currency_Check
    {
        static void Main(string[] args)
        {
            decimal[] FX = { 3.5m/100m, 1.5m, 1.95m, 1m, 1m };  // {RUB, USD, EUR, BGN b, BGN m}
            decimal[] priceBGN = { 0,0,0,0,0};                  // {RUB, USD, EUR, BGN b, BGN m}

            for (int i = 0; i < 5; i++)
                priceBGN[i] = decimal.Parse(Console.ReadLine()) * FX[i];
            priceBGN[3] /= 2;                                   // priceB for 2 copies

            decimal minPrice = priceBGN[0];                     // finds the cheapest game
            for (int i = 1; i <= 4; i++)                        
            {
                if (minPrice > priceBGN[i])
                    minPrice = priceBGN[i];
            }
            Console.WriteLine("{0:0.00}",minPrice);
        }
    }
}
