using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Even_Sum
{
    class _02_Odd_Even_Sum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                if (i % 2 == 0)
                    sumEven += int.Parse(Console.ReadLine());
                else
                    sumOdd += int.Parse(Console.ReadLine());
            }
            if (sumOdd == sumEven)
                Console.WriteLine("Yes, sum={0}", sumOdd);
            else
                Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
        }
    }
}
