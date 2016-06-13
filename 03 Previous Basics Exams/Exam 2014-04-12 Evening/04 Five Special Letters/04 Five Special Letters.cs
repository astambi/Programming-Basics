using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Five_Special_Letters
{
    class _04_Five_Special_Letters
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<string> specialWords = new List<string>();
            
            for (char i1 = 'a'; i1 <= 'e'; i1++)
            {
                for (char i2 = 'a'; i2 <= 'e'; i2++)
                {
                    for (char i3 = 'a'; i3 <= 'e'; i3++)
                    {
                        for (char i4 = 'a'; i4 <= 'e'; i4++)
                        {
                            for (char i5 = 'a'; i5 <= 'e'; i5++)
                            {
                                string word = string.Empty + i1 + i2 + i3 + i4 + i5;
                                // TODO
                                int weight = GetWordsWeight(word);

                                bool isInRange = weight >= start && weight <= end;
                                if (isInRange)
                                    specialWords.Add(word);
                            }
                        }
                    }
                }
            }
            specialWords.Sort();
            if (specialWords.Count > 0)
                Console.WriteLine(string.Join(" ", specialWords));
            else Console.WriteLine("No");

        }
        static int GetWordsWeight(string word)
        {
            int[] letterWeights = new int[] { 5, -12, 47, 7, -32 }; 
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e' };

            string nonRepeatingLetters = word.Split().Distinct().ToString();
            int weight = 0;

            for (int i = 0; i < nonRepeatingLetters.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (nonRepeatingLetters[i] == letters[j])
                    {
                        weight += (i + 1) * letterWeights[j];
                        break;
                    }
                }               
            }
            return weight;
        }
    }
}
