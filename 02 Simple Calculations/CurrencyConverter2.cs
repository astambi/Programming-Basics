using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter_2
{
    class CurrencyConverter2
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string CCY1 = Console.ReadLine();
            string CCY2 = Console.ReadLine();

            string[] arrCCY = new string[]  { "BGN", "USD", "EUR", "GBP" };
            decimal[] arrFX = new decimal[] { 1m, 1.79549m, 1.95583m, 2.53405m };  //m for decimal, otherwise - double!
            decimal FX = 1;

            for (int i = 0; i <= 3; ++i)
            {
                if (CCY1 == arrCCY[i])
                    FX = FX * arrFX[i];
                if (CCY2 == arrCCY[i])
                    FX = FX / arrFX[i];
            }
            decimal result = Math.Round(amount * FX, 2);
            Console.WriteLine("{0} {1}", result, CCY2);
        }
    }
}