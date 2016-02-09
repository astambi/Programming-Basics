using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Impress_the_girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] FX = new double[] { 3.5 / 100, 1.5, 1.95, 1, 1 }; //{RUB,USD,EUR,BGNb,BGNm}
            double[] priceBGN = new double[5];
            double maxPrice = 0;

            for (int i = 0; i < 5; ++i)
                priceBGN[i] = long.Parse(Console.ReadLine()) * FX[i]; //NB long! {RUB,USD,EUR,BGNb,BGNm}
            priceBGN[3] /= 2; //special price for 2 games

            for (int i = 0; i < 5; ++i)
            {
                if (priceBGN[i] > maxPrice)
                    maxPrice = priceBGN[i];
            }

            if (maxPrice > Math.Round(maxPrice))
                maxPrice = Math.Round(maxPrice) + 1;
            else
                maxPrice = Math.Round(maxPrice);

            Console.WriteLine("{0:0.00}", maxPrice);
        }
    }
}