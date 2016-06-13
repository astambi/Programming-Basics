using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Jumping_Sums
{
    class Jumping_Sums
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int jumps = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;

            // split string into numbers
            string[] splitInput = input.Split(' ');
            int countNumbers = splitInput.Length;       // NB! count numbers in array
            int[] number = new int[countNumbers];
            for (int i = 0; i < countNumbers; i++)
                number[i] = int.Parse(splitInput[i]);   // {n[0], ..., n[countNumbers - 1]}
            // jump & sum
            for (int i = 0; i < countNumbers; i++)      // repeat for each number [0; n-1]
            {
                int sum = number[i];
                int index = i;
                for (int j = 0; j < jumps; j++)         // repeat for each jump
                {
                    index = (index + number[index]) % countNumbers;
                    sum += number[index];
                }
                if (maxSum < sum)
                    maxSum = sum;
            }
            Console.WriteLine("max sum = {0}", maxSum);
        }
    }
}
