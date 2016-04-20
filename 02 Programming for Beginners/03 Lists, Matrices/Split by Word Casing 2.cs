using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' };
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> upperCaseWords = new List<string>();
            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                bool isAllUpperCase = true;
                bool isAllLowerCase = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))          isAllLowerCase = false;
                    else if (char.IsLower(word[i]))     isAllUpperCase = false;
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperCase = false; 
                    }             
                }
                if (isAllUpperCase)         upperCaseWords.Add(word);
                else if (isAllLowerCase)    lowerCaseWords.Add(word);
                else                        mixedCaseWords.Add(word);
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
