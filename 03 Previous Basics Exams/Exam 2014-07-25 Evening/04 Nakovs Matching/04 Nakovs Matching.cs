using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nakovs_Matching
{
    class _04_Nakovs_Matching
    {
        static void Main(string[] args)
        {
            string wordA = Console.ReadLine(); 
            string wordB = Console.ReadLine();  
            int limit = int.Parse(Console.ReadLine()); 
            bool foundAGoodMatching = false;

            for (int splitIndexA = 0; splitIndexA < wordA.Length - 1; splitIndexA++)
                for (int splitIndexB = 0; splitIndexB < wordB.Length - 1; splitIndexB++)
                {
                    int nakovs = CalcNakovsDifference(wordA, wordB, splitIndexA, splitIndexB);
                    bool isAGoodMatching = nakovs <= limit;
                    if (isAGoodMatching)
                    {
                        PrintGoodMatchings(wordA, wordB, splitIndexA, splitIndexB, nakovs);
                        foundAGoodMatching = true;
                    }
                }
            if (!foundAGoodMatching)
                Console.WriteLine("No");
        }

        static int CalcNakovsDifference(string wordA, string wordB, int splitIndexA, int splitIndexB)
        {
            int weightALeft = GetSumCodes(wordA, 0, splitIndexA);
            int weightBLeft = GetSumCodes(wordB, 0, splitIndexB);
            int weightARight = GetSumCodes(wordA, splitIndexA + 1, wordA.Length - 1);
            int weightBRight = GetSumCodes(wordB, splitIndexB + 1, wordB.Length - 1);

            int nakovs = Math.Abs(weightALeft * weightBRight - weightARight * weightBLeft);
            return nakovs;
        }
        static int GetSumCodes(string word, int indexStart, int indexEnd)
        {
            int sum = 0;
            for (int i = indexStart; i <= indexEnd; i++)
                sum += (int)word[i];
            return sum;
        }
        static void PrintGoodMatchings(string wordA, string wordB, int splitIndexA, int splitIndexB, int nakovs)
        {
            string leftA = wordA.Substring(0, splitIndexA + 1);
            string leftB = wordB.Substring(0, splitIndexB + 1);
            string rightA = wordA.Substring(splitIndexA + 1);
            string rightB = wordB.Substring(splitIndexB + 1);

            Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",leftA, rightA, leftB, rightB, nakovs);
        }
    }
}