using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_Equal_Elements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // longest sequence of equal elements 
            // ends at lastIndex, has length of maxLen => [lastIndex + 1 - maxLen, lastIndex]
            int currentLen = 1;
            int maxLen = 1;
            int lastIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen) // keep the leftmost max len sequence
                    {
                        maxLen = currentLen;
                        lastIndex = i;
                    }
                }
                else currentLen = 1;
            }
            // print longest sequence
            for (int i = lastIndex + 1 - maxLen; i <= lastIndex; i++)
                Console.Write("{0} ", numbers[i]);
        }
    }
}
