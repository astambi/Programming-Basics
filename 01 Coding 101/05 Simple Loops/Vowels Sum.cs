using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Vowels_Sum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] vowelValues = { 1, 2, 3, 4, 5 };
            int sumVowels = 0;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 5; j++) //char[] vowels
                {
                    bool letterIsVowel = text[i] == vowels[j];
                    if (letterIsVowel)
                        sumVowels += vowelValues[j];
                }
            }
            Console.WriteLine("{0}", sumVowels);
        }
    }
}
