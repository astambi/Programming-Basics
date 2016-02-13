using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Odd_Even_Sum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < n; i++)
            {
                bool evenPosition = (i + 1) % 2 == 0; // even position
                if (evenPosition)
                    sumEven += int.Parse(Console.ReadLine());
                else
                    sumOdd += int.Parse(Console.ReadLine());
            }
            int difference = Math.Abs(sumEven - sumOdd);
            if (difference == 0)
                Console.WriteLine("Yes \nSum = {0}", sumEven);
            else
                Console.WriteLine("No \nDiff = {0}", difference);
        }
    }
}
