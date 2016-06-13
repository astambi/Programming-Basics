using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inside_the_Building
{
    class _01_Inside_the_Building
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                if (IsInside(x, y, h))
                    Console.WriteLine("inside");
                else Console.WriteLine("outside");
            }
        }
        public static bool IsInside(int x, int y, int h)
        {
            bool insideHorizontalFig = x >= 0 * h && x <= 3 * h &&
                                       y >= 0 * h && y <= 1 * h;
            bool insideVerticalFig = x >= 1 * h && x <= 2 * h &&
                                     y >= 0 * h && y <= 4 * h;
            return insideHorizontalFig || insideVerticalFig;
        }
    }
}