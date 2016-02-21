using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_King_of_Thieves
{
    class _03_King_of_Thieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n always odd
            char gemSymbol = Console.ReadLine()[0];
            char backgroundSymbol = '-';
            int halfWidth = (n + 1) / 2;

            //upper half
            int gemCount = 1;          
            for (int i = 1; i <= halfWidth; i++)
            {
                int backgroundCount = (n - gemCount) / 2;
                string gem = new string(gemSymbol, gemCount);
                string background = new string(backgroundSymbol, backgroundCount);
                Console.WriteLine("{0}{1}{0}", background, gem);
                gemCount += 2;
            }
            //lower half
            gemCount = n - 2;
            for (int i = halfWidth - 1; i > 0; i--)
            {
                int backgroundCount = (n - gemCount) / 2;
                string gem = new string(gemSymbol, gemCount);
                string background = new string(backgroundSymbol, backgroundCount);
                Console.WriteLine("{0}{1}{0}", background, gem);
                gemCount -= 2;
            }
        }
    }
}
