using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Reverse_Array
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
                SwapElements(numbers, i, numbers.Length - 1 - i);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void SwapElements(int[] arr, int indexToSwap, int indexToSwapWith)
        {
            int oldElement = arr[indexToSwap];
            arr[indexToSwap] = arr[indexToSwapWith];
            arr[indexToSwapWith] = oldElement;
        }
    }
}
