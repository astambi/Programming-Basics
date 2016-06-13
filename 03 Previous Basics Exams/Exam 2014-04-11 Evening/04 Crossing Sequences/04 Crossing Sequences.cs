using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Crossing_Sequences
{
    class Crossing_Sequences
    {
        static void Main(string[] args)
        {
            int lastNumber = 1000000;

            List<int> tribonacci = GetTribonacciSequence(lastNumber);
            List<int> numberSpiral = GetNumberSpiralSequence(lastNumber);

            GetCommonNumber(tribonacci, numberSpiral);
        }

        static void GetCommonNumber(List<int> tribonacci, List<int> numberSpiral)
        {
            bool foundCommonNumber = false;
            foreach (var number in tribonacci)
            {
                if (numberSpiral.Contains(number))
                {
                    Console.WriteLine(number);
                    foundCommonNumber = true;
                    break;
                }
            }
            if (!foundCommonNumber)
                Console.WriteLine("No");
        }

        static List<int> GetNumberSpiralSequence(int lastNumber)
        {
            List<int> numberSpiral = new List<int>();
            numberSpiral.Add(int.Parse(Console.ReadLine()));
            int spiralStep = int.Parse(Console.ReadLine());
            int spiralSize = 1;
            bool sequenceComplete = false;

            while (true)
            {
                for (int i = 0; i < 2; i++)
                {
                    int lastIndex = numberSpiral.Count - 1;
                    int nextNumber = numberSpiral[lastIndex] + 
                                    spiralSize * spiralStep;
                    if (nextNumber <= lastNumber)
                        numberSpiral.Add(nextNumber);
                    else
                    {
                        sequenceComplete = true;
                        break;
                    }
                }
                if (sequenceComplete) break;
                spiralSize++;
            }
            return numberSpiral;
        }

        static List<int> GetTribonacciSequence(int lastTribonacci)
        {
            List<int> tribonacciSeq = new List<int>();
            for (int i = 0; i < 3; i++)
                tribonacciSeq.Add(int.Parse(Console.ReadLine()));  // get first 3 numbers in sequence

            while (true)
            {
                int lastIndex = tribonacciSeq.Count - 1;
                int nextTribonacci = tribonacciSeq[lastIndex] +
                                    tribonacciSeq[lastIndex - 1] +
                                    tribonacciSeq[lastIndex - 2]; // indices exist after the first 3 numbers
                if (nextTribonacci <= lastTribonacci)
                    tribonacciSeq.Add(nextTribonacci);
                else break;
            }
            return tribonacciSeq;
        }

    }
}
