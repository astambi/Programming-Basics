using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden_Substrings
{
    class Forbidden_Substrings
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split(' ').ToArray();

            foreach (var word in forbiddenWords)
                text = text.Replace(word, new string('*', word.Length));

            Console.WriteLine(text);
        }
    }
}
