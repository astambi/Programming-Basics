using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Biggest_Triple
{
    class _02_Biggest_Triple
    {
        static void Main(string[] args)
        {
            // NB! 93/100 Judge
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countTriples = (int)Math.Ceiling(numbers.Length / 3.0);
            long[] sumTriples = new long[countTriples];
            long maxSum = long.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int index = i / 3;
                if (i % 3 == 0)
                    sumTriples[index] = 0;
                sumTriples[index] += numbers[i];

                if (sumTriples[index] > maxSum)
                {
                    maxSum = sumTriples[index];
                    maxIndex = index;
                }
            }
            //Console.WriteLine(string.Joint(" ", sumTriples));

            int beginningIndex = maxIndex * 3;
            int endingIndex = Math.Min(numbers.Length - 1, maxIndex * 3 + 2);

            for (int i = beginningIndex; i <= endingIndex; i++)
                Console.Write("{0} ", numbers[i]);
        }
    }
}
