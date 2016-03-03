using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fallen_In_Love
{
    class _03_Fallen_In_Love
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 6;
            char leavesSymbol = '~';
            char backgroundSymbol = '.';
            string background = "";
            string leave = "";
            string centre = "";
            int backgroundCount = 2*n;
            int centreCount = 0;

            for (int i = 0; i < n; i++)
            {
                leave = new string(leavesSymbol, i);
                background = new string(backgroundSymbol, backgroundCount);
                centre = new string(backgroundSymbol, centreCount);
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", leave, background, centre);
                backgroundCount -= 2;
                centreCount += 2;
            }
            backgroundCount = 1;
            for (int i = n; i >= 0; i--)
            {
                background = new string(backgroundSymbol, backgroundCount);
                leave = new string(leavesSymbol, i);
                centre = new string(backgroundSymbol, centreCount);
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", background, leave, centre);
                backgroundCount += 2;
                centreCount -= 2;
            }
            background = new string(backgroundSymbol, 2*n + 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}##{0}", background);
        }
    }
}
