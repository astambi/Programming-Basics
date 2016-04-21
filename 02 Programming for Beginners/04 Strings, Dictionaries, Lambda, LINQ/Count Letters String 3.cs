using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Letters_String
{
    class Count_Letters_in_String
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            // create an array big enouph to hold the max character present in text
            int[] count = new int[text.Max() + 1]; // [0, max]

            // count the frequency of occurence of all characters in the text
            foreach (char ch in text)
                count[ch]++;

            // Print the non-zero counts (zero counts => letters not present in the text)
            for (char ch = (char)0; ch < (char)count.Length; ch++)
            {
                if (count[ch] > 0)
                    Console.WriteLine("{0} -> {1}", ch, count[ch]);
            }
        }
    }
}
