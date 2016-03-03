using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encoded_Answers
{
    class _02_Encoded_Answers
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long testNumber = 0;
            long testNumberRemainder = 0;
            long[] remainders = { 0, 1, 2, 3 };
            string[] answers = { "a","b","c","d"};
            int[] answersCount = { 0,0,0,0 };
            string decodedAnswers = "";

            for (int i = 0; i < n; i++)
            {
                testNumber = long.Parse(Console.ReadLine());
                testNumberRemainder = testNumber % 4;
                for (int j = 0; j < 4; j++)
                {
                    if (testNumberRemainder == remainders[j])
                    {
                        decodedAnswers += answers[j] + " ";
                        ++answersCount[j];
                    }
                }                
            }
            Console.WriteLine("{0}",decodedAnswers);
            for (int i = 0; i < 4; i++)
                Console.WriteLine("Answer {0}: {1}",answers[i].ToUpper(),answersCount[i]);
        }
    }
}
