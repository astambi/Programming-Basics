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
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLen = Math.Max(arr1.Length, arr2.Length);
            int[] sum = new int[maxLen];

            for (int index = 0; index < maxLen; index++)
            {
                int index1 = index % arr1.Length;
                int index2 = index % arr2.Length;

                sum[index] = arr1[index1] + arr2[index2];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
