using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Letters_in_String
{
    class Count_Letters_in_String
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToLower().ToArray();
            Array.Sort(letters);

            int count = 1;
            for (int i = 1; i <= letters.Length; i++)
            {
                if (i == letters.Length || letters[i] != letters[i - 1]) // index outside array OR chars not equal
                {
                    Console.WriteLine("{0} -> {1}", letters[i - 1], count);
                    count = 1;
                }
                else count++; // equal chars
            }
        }
    }
}
