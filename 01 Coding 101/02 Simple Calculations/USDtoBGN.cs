using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            decimal USD = decimal.Parse(Console.ReadLine());

            decimal BGN = Math.Round(USD * 1.79549m, 2);
            Console.WriteLine(BGN);
        }
    }
}