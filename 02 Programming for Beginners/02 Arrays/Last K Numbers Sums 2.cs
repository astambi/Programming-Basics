using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Last_K_Numbers_Sums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // [0, n-1]
            int stepK = int.Parse(Console.ReadLine());
            // [0]=1, any other element = sum of previous k elements

            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int currentIndex = 1; currentIndex < n; currentIndex++)    // [1, n-1]
                sequence[currentIndex] = GetSumPreviousKElements(sequence, currentIndex, stepK);

            Console.WriteLine(string.Join("\n", sequence));
        }
        static long GetSumPreviousKElements(long[] array, int currentIndex, int stepK)
        {
            // determine previous k elements [currentIndex - k; currentIndex - 1] 
            int prevEnd = currentIndex - 1;
            int prevStart = Math.Max(0, currentIndex - stepK); // index cannot be negative  
             
            long sum = 0;
            for (int prevIndex = prevStart; prevIndex <= prevEnd; prevIndex++)
                sum += array[prevIndex];
            return sum;
        }
    }
}
