using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] numbers1 = numbers.Skip(k).Take(2 * k).ToArray();

            int[] numbers2Left = numbers.Take(k).Reverse().ToArray();
            int[] numbers2Right = numbers.Reverse().Take(k).ToArray();
            int[] numbers2 = numbers2Left.Concat(numbers2Right).ToArray();

            int[] sum = numbers1.Select((x, index) => x + numbers2[index]).ToArray();
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
