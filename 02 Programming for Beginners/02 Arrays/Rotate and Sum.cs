using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Rotate_and_Sum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int len = numbers.Length;
            int[] sum = new int[len];

            for (int i = 0; i < rotations; i++)
            {
                int[] rotatedNumbers = RotateArrayRight(numbers);
                for (int j = 0; j < len; j++)
                {
                    sum[j] += rotatedNumbers[j];
                }
                numbers = rotatedNumbers;
            }
            Console.WriteLine(string.Join(" ",sum));
        }

        static int[] RotateArrayRight(int[] array)
        {
            int[] rotatedArray = new int[array.Length];
            rotatedArray[0] = array[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
                rotatedArray[i] = array[i - 1];
            return rotatedArray;
        }
    }
}
