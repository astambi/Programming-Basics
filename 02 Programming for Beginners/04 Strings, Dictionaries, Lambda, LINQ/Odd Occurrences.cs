using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Odd_Occurrences
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>(); // not sorted to preserve order of appearance

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                    counts[word]++;
                else counts[word] = 1;
            }
            List<string> result = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0) // odd count of occurences
                    result.Add(pair.Key);
            }
            Console.WriteLine(string.Join(", ", result));        
        }
    }
}