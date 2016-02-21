using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree_3
{
    class Christmas_Tree_3

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char treeSymbol = '*';
            char backgroundSymbol = ' ';

            for (int i = 0; i <= n; i++)
            {
                string background = new string(backgroundSymbol, n - i);
                string tree = new string(treeSymbol, i);
                Console.WriteLine("{0}{1} | {1}", background, tree);
            }
        }
    }
}
