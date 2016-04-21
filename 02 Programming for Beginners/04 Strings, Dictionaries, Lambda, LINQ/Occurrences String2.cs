using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrences_String2
{
    class Occurrences_in_String
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int count = 0;
            int offset = -1;

            while (true)
            {
                offset = text.IndexOf(word, offset + 1);
                if (offset == -1) break; // no occurrence
                count++;
            }
            Console.WriteLine($"Occurrencies: {count}");
        }
    }
}