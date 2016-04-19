using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Sum_Arrays
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int len = Math.Max(numbers1.Length, numbers2.Length);
            int[] sums = new int[len];

            for (int i = 0; i < len; i++)
            {
                sums[i] = numbers1[i % numbers1.Length] +
                          numbers2[i % numbers2.Length];
            }
            Console.WriteLine(string.Join(" ", sums));
        }
    }
}