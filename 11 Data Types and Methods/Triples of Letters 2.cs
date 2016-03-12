using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters_2
{
    class Triples_of_Letters_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char letter1 = 'a'; letter1 < 'a' + n; letter1++)
                for (char letter2 = 'a'; letter2 < 'a' + n; letter2++)
                    for (char letter3 = 'a'; letter3 < 'a' + n; letter3++)
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
        }
    }
}