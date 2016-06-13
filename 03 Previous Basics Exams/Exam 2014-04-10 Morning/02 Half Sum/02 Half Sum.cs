using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Half_Sum
{
    class _02_Half_Sum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumR = 0;
            int sumL = 0;

            for (int i = 0; i < n; i++)
                sumL += int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                sumR += int.Parse(Console.ReadLine());
            if (sumL == sumR)
                Console.WriteLine("Yes, sum={0}", sumL);
            else
                Console.WriteLine("No, diff={0}", Math.Abs(sumL - sumR));
        }
    }
}
