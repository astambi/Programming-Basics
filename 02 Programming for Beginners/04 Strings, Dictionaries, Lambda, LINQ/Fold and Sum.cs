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

            // get top folded row
            //var topLeft = numbers.Take(k).Reverse();
            //var topRight = numbers.Reverse().Take(k);
            int[] topLeft = numbers.Take(k).Reverse().ToArray();
            int[] topRight = numbers.Reverse().Take(k).ToArray(); 
            int[] top = topLeft.Concat(topRight).ToArray();

            // get bottom row
            int[] bottom = numbers.Skip(k).Take(2 * k).ToArray();

            // sum top and bottom arrays
            int[] sumTopBottom = top.Select((x, index) => x + bottom[index]).ToArray(); // NB!

            Console.WriteLine(string.Join(" ", sumTopBottom));           
        }
    }
}