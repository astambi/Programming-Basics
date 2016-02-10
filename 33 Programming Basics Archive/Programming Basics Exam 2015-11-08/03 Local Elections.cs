using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Local_Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            int lists = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            string votingSymbol = Console.ReadLine().ToUpper(); // X x V v

            string[] patternX = new string[] { "|.\\./.|", "|..X..|", "|./.\\.|" };
            string[] patternV = new string[] { "|\\.../|", "|.\\./.|", "|..V..|" };
            string[] pattern = new string[] { "...", "+-----+", "|.....|" };
            string line = new string('.', 13);

            for (int i = 0; i < lists; i++)
            {
                Console.WriteLine("{0}", line);

                if (vote != (i + 1)) // unchecked box empty pattern
                {
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[1]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[2]);
                    Console.WriteLine("{0:00}.{1}{2}", i + 1, pattern[2], pattern[0]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[2]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[1]);
                }
                else if (votingSymbol == "X") // voting patternX
                {
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[1]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], patternX[0]);
                    Console.WriteLine("{0:00}.{1}{2}", vote, patternX[1], pattern[0]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], patternX[2]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[1]);
                }
                else if (votingSymbol == "V") // voting patternV
                {
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[1]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], patternV[0]);
                    Console.WriteLine("{0:00}.{1}{2}", vote, patternV[1], pattern[0]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], patternV[2]);
                    Console.WriteLine("{0}{1}{0}", pattern[0], pattern[1]);
                }
            }
            Console.WriteLine("{0}", line);
        }
    }
}
