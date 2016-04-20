using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_Equal_Elements_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // longest sequence of equal elements [maxIndex, maxIndex + maxLen)
            // begins at maxIndex, has length of maxLen 
            int maxIndex = 0;
            int maxLen = 1;
            int currentIndex = 0;
            int currentLen = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxIndex = currentIndex;
                    }
                }
                else
                {
                    currentIndex = i;
                    currentLen = 1;
                }
            }
            // print longest sequence
            for (int i = maxIndex; i < maxIndex + maxLen; i++)
                Console.Write("{0} ", numbers[i]);
        }
    }
}
