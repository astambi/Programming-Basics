using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int currentPosition = 0; currentPosition < numbers.Length; currentPosition++)
            {
                int currentMin = numbers[currentPosition];
                int currentMinIndex = currentPosition;
                for (int i = currentPosition + 1; i < numbers.Length; i++)
                {
                    if (currentMin > numbers[i])
                    {
                        currentMin = numbers[i];
                        currentMinIndex = i;
                    }
                }
                int temp = numbers[currentPosition];
                numbers[currentPosition] = currentMin;
                numbers[currentMinIndex] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
