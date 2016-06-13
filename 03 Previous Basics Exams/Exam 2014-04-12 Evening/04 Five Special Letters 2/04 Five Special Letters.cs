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
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e' };
            List<string> specialWords = new List<string>();

            for (int i1 = 0; i1 < 5; i1++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    for (int i3 = 0; i3 < 5; i3++)
                    {
                        for (int i4 = 0; i4 < 5; i4++)
                        {
                            for (int i5 = 0; i5 < 5; i5++)
                            {
                                string word = string.Empty + letters[i1] + letters[i2] + letters[i3] + letters[i4] + letters[i5];

                                // get sequence of non-repeating letters
                                string nonRepeatingSequence = string.Empty + letters[i1];
                                nonRepeatingSequence = AddNonRepeatingLetter(nonRepeatingSequence, letters[i2]);
                                nonRepeatingSequence = AddNonRepeatingLetter(nonRepeatingSequence, letters[i3]);
                                nonRepeatingSequence = AddNonRepeatingLetter(nonRepeatingSequence, letters[i4]);
                                nonRepeatingSequence = AddNonRepeatingLetter(nonRepeatingSequence, letters[i5]);
                                // calc sequence weight
                                int weight = 0;
                                for (int i = 0; i < nonRepeatingSequence.Length; i++)
                                {
                                    weight += (i + 1) * GetLetterWeight(nonRepeatingSequence[i], letters);
                                }
                                bool isInRange = weight >= start && weight <= end;
                                if (isInRange)
                                {
                                    specialWords.Add(word);
                                }
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
        static string AddNonRepeatingLetter(string word, char letter)
        {
            if (!word.Contains(letter))
                word += letter;
            return word;
        }
        static int GetLetterWeight(char letter, char[] letters)
        {
            int[] letterWeights = new int[] { 5, -12, 47, 7, -32 }; // { 'a', 'b', 'c', 'd', 'e' }
            for (int i = 0; i < 5; i++)
            {
                if (letter == letters[i])
                    return letterWeights[i];
            }
            return 0;
        }
    }
}
