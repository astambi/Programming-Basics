using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Count_Real_Numbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Array.Sort(numbers);

            int count = 1;
            for (int i = 1; i <= numbers.Length; i++)
                if (i == numbers.Length || numbers[i] != numbers[i - 1]) // outside array range OR different than previous number
                {
                    Console.WriteLine("{0} -> {1} times", numbers[i-1], count);
                    count = 1;
                }
                else count++; // equal numbers within array range
        }
    }
}