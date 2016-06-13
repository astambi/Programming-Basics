using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Illuminati
{
    class _02_Illuminati
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine().ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] values = { 65, 69, 73, 79, 85 };

            int numVowels = 0;
            int sum = 0;

            for (int i = 0; i < title.Length; i++)
                for (int j = 0; j < 5; j++)
                    if (title[i] == vowels[j])
                    {
                        numVowels++;
                        sum += values[j];
                    }
            Console.WriteLine("{0}\n{1}", numVowels, sum);
        }
    }
}
