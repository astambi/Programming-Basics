﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class CurrencyConverter1
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string CCY1 = Console.ReadLine();
            string CCY2 = Console.ReadLine();

            decimal FX = 1;
            if (CCY1 == "USD")
                FX = FX * 1.79549m; // signifies a decimal number, otherwise - double
            else if (CCY1 == "EUR")
                FX = FX * 1.95583m;
            else if (CCY1 == "GBP")
                FX = FX * 2.53405m;
            
            if (CCY2 == "USD")
                FX = FX / 1.79549m;
            else if (CCY2 == "EUR")
                FX = FX / 1.95583m;
            else if (CCY2 == "GBP")
                FX = FX / 2.53405m;

            decimal result = Math.Round(amount * FX, 2);
            Console.WriteLine("{0} {1}", result, CCY2);
        }
    }
}