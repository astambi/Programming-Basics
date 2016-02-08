using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Point_in_the_Figure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            //inside either figure
            bool horizontalFigureInside = x > 0 && x < 3 * h && y > 0 && y < h;
            bool verticalFigureInside = x > h && x < 2 * h && y > h && y < 4 * h;
            bool commonSide = y == h && x > h && x < 2 * h;
            //outside both figures
            bool horizontalFigureOutside = x < 0 || x > 3 * h || y < 0 || y > h;
            bool verticalFigureOutside = x < h || x > 2 * h || y < h || y > 4 * h;

            if (horizontalFigureInside || verticalFigureInside || commonSide)
                Console.WriteLine("inside");
            else if (horizontalFigureOutside && verticalFigureOutside)
                Console.WriteLine("outside");
            else
                Console.WriteLine("border");
        }
    }
}