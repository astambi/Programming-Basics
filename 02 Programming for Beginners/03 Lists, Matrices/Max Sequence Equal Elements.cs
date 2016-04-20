using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // find the longest sequence of equal elements 
            // starts at maxSeqStart, has length of maxLen => [maxSeqStart, maxSeqStart + maxLen - 1]
            int currentNumber = numbers[0];
            int currentSeqStart = 0;
            int currentSeqLength = 1;
            int maxSequenceStart = currentSeqStart;
            int maxSeqLength = currentSeqLength;

            int currentIndex = 1;
            while (currentIndex < numbers.Count)
            {
                if (currentNumber == numbers[currentIndex])
                {
                    currentSeqLength++;
                    if (currentSeqLength > maxSeqLength) // keep the leftmost max seq if several with the same max length
                    {
                        maxSeqLength = currentSeqLength;
                        maxSequenceStart = currentSeqStart;
                    }
                }                    
                else
                {
                    currentNumber = numbers[currentIndex];
                    currentSeqLength = 1;
                    currentSeqStart = currentIndex;                 
                }                
                currentIndex++;
            }
            for (int i = maxSequenceStart; i < maxSequenceStart + maxSeqLength; i++)
                Console.Write("{0} ", numbers[i]);
        }
    }
}
