using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Randomize_Words
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random(); // NB! outside loop

            for (int originalIndex = 0; originalIndex < words.Length; originalIndex++)
            {
                int destinationIndex = rnd.Next(0, words.Length);
                // swap word at original index with word at destination index
                string temp = words[originalIndex];
                words[originalIndex] = words[destinationIndex];
                words[destinationIndex] = temp;
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}