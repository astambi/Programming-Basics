using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Christmas_Tree
{
    class _03_Christmas_Tree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int heightTrunk = (n + 1) / 2;
            char tree = '^';
            char snow = '\'';

            string snowTopLine = new string(snow, n);
            Console.WriteLine("{0}{1}{0}", snowTopLine, tree);
            for (int i = 3; i <= n; i += 2)
            {
                string snowTreeLine = new string(snow, (width - i) / 2);
                string midTreeLine = new string(tree, i);
                Console.WriteLine("{0}{1}{0}", snowTreeLine, midTreeLine);
            }
            for (int i = 3; i <= n + 2; i += 2)
            {
                string snowTreeLine = new string(snow, (width - i) / 2);
                string midTreeLine = new string(tree, i);
                Console.WriteLine("{0}{1}{0}", snowTreeLine, midTreeLine);

            }
            string snowTrunkLine = new string(snow, (width - 3) / 2);
            for (int i = 0; i < heightTrunk; i++)
                Console.WriteLine("{0}| |{0}", snowTrunkLine);
            string bottomLine = new string('-', width);
            Console.WriteLine(bottomLine);
        }
    }
}
