using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sum_Of_Elements
{
    class _02_Sum_Of_Elements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long max = int.MinValue;
            long sum = 0;

            string[] numbersStr = input.Split(' ');

            for (int i = 0; i < numbersStr.Length; i++)
            {
                long number = long.Parse(numbersStr[i]);
                sum += number;
                if (max < number)
                    max = number;
            }
            if (2 * max == sum)
                Console.WriteLine("Yes, sum={0}", max);
            else
                Console.WriteLine("No, diff={0}", Math.Abs(2 * max - sum));
        }
    }
}
