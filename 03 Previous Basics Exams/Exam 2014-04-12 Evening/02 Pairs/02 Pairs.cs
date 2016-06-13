using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pairs
{
    class _02_Pairs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrevious = 0;
            int diffMax = 0;

            string[] numbersStr = input.Split(' ');
            for (int i = 0; i < numbersStr.Length; i += 2)
            {
                int sumCurrent = int.Parse(numbersStr[i]) + int.Parse(numbersStr[i + 1]);
                if (i != 0)
                {
                    int diffCurrent = Math.Abs(sumPrevious - sumCurrent);
                    if (diffCurrent > diffMax) diffMax = diffCurrent;
                }
                sumPrevious = sumCurrent;
            }
            if (diffMax == 0)
                Console.WriteLine("Yes, value={0}", sumPrevious);
            else
                Console.WriteLine("No, maxdiff={0}", diffMax);
        }
    }
}
