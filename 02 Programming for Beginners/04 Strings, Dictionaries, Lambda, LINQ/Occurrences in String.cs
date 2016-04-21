using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrences_in_String
{
    class Occurrences_in_String
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.IndexOf(word, i))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}