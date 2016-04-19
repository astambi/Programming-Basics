using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Rounding_Numbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("{0} => {1}", numbers[i], roundedNumbers[i]);
        }
    }
}
