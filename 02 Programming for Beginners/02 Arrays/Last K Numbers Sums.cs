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
            int n = int.Parse(Console.ReadLine());  
            int k = int.Parse(Console.ReadLine());
            // [0]=1, every other element = sum of k previous elements
            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int index = 1; index < n; index++) // [1, n-1]
            {
                int end = index - 1;
                int start = Math.Max(0, index - k);                
                long sum = 0;
                for (int i = start; i <= end; i++)
                    sum += sequence[i];                
                sequence[index] = sum;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(sequence[i]);
        }
    }
}
