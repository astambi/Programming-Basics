using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ",;:.!()\"'/\\[] ".ToArray(); // no split !
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            // ToArray() not absolutely required, ToList() - absolutely required !

            List<string> wordsLowerCase = new List<string>();
            List<string> wordsMixedCase = new List<string>();
            List<string> wordsUpperCase = new List<string>();

            foreach (var word in words)
            {
                int countLowerLetters = 0;
                int countUpperLetters = 0;
                foreach (char letter in word)
                {
                    if (char.IsLower(letter))       countLowerLetters++;
                    else if (char.IsUpper(letter))  countUpperLetters++;
                }
                if (countLowerLetters == word.Length)       wordsLowerCase.Add(word);
                else if (countUpperLetters == word.Length)  wordsUpperCase.Add(word);
                else                                        wordsMixedCase.Add(word);
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", wordsLowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", wordsMixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", wordsUpperCase));
        }
    }
}
