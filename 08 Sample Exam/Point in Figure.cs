using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Figure
{
    class Point_in_Figure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool pointInsideFigL = (x >= 2 && x <= 4) && (y >= -3 && y <= 1);
            bool pointInsideFigC = (x >= 4 && x <= 10) && (y >= -5 && y <= 3);
            bool pointInsideFigR = (x >= 10 && x <= 12) && (y >= -3 && y <= 1);

            bool pointInsideFig = pointInsideFigL || pointInsideFigC || pointInsideFigR;

            if (pointInsideFig)
                Console.WriteLine("in");
            else
                Console.WriteLine("out");
        }
    }
}
