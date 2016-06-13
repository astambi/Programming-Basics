using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Compound_Interest
{
    class Compound_Interest
    {
        static void Main(string[] args)
        {
            decimal PV = decimal.Parse(Console.ReadLine());
            int termLoan = int.Parse(Console.ReadLine());
            decimal rateBank = decimal.Parse(Console.ReadLine());
            decimal rateFriend = decimal.Parse(Console.ReadLine());
            decimal FV = 0;
            string lender = "Friend";

            decimal FVbank = PV;
            for (int i = 1; i <= termLoan; i++)
                FVbank *= (1m + rateBank);

            decimal FVfriend = PV * (1m + rateFriend);

            if (FVfriend > FVbank)
            {
                lender = "Bank";
                FV = FVbank;
            }
            else
                FV = FVfriend;

            Console.WriteLine("{0:0.00} {1}", FV, lender);
        }
    }
}
