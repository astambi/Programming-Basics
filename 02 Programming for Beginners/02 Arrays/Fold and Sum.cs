using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Fold_and_Sum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] numbers1 = new int[2 * k];
            int[] numbers2 = new int[2 * k];
            int[] sum = new int[2 * k];

            for (int i = 0; i < 2*k; i++)
                numbers2[i] = numbers[k + i];

            for (int i = 0; i < k; i++)
                numbers1[i] = numbers[k - 1 - i];
            for (int i = 0; i < k; i++)
                numbers1[k + i] = numbers[4 * k - 1 - i];

            for (int i = 0; i < 2*k; i++)
                sum[i] = numbers1[i] + numbers2[i];

            //Console.WriteLine(string.Join(" ", numbers1));
            //Console.WriteLine(string.Join(" ", numbers2));
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
