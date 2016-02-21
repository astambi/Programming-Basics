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
            char treeSymbol = '^';
            char snowSymbol = '\'';
            char groundSymbol = '-';
            string tree = "";
            string snow = "";

            // tree top 
            snow = new string(snowSymbol, n);
            Console.WriteLine("{0}{1}{0}", snow, treeSymbol);
            // tree branches
            for (int j = 0; j < 2; j++)
            {
                for (int i = 3; i <= n; i += 2)
                {
                    snow = new string(snowSymbol, (width - i) / 2);
                    tree = new string(treeSymbol, i);
                    Console.WriteLine("{0}{1}{0}", snow, tree);
                }
            }
            // lowest branch
            snow = new string(snowSymbol, (width - n - 2) / 2);
            tree = new string(treeSymbol, n + 2);
            Console.WriteLine("{0}{1}{0}", snow, tree);           
            // trunk
            snow = new string(snowSymbol, (width - 3) / 2);
            for (int i = 0; i < heightTrunk; i++)
                Console.WriteLine("{0}| |{0}", snow);
            // ground
            string ground = new string(groundSymbol, width);
            Console.WriteLine(ground);
        }
    }
}
