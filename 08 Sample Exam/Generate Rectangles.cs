using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Rectangles
{
    class Generate_Rectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int areaMin = int.Parse(Console.ReadLine());
            int areaFig = 0;
            int countFigures = 0;
            // -n <= x1 <= x2 <= n
            // -n <= y1 <= y2 <= n
            for (int x1 = -n; x1 <= n; x1++)
            {
                for (int y1 = -n; y1 <= n; y1++)
                {
                    for (int x2 = n; x2 > x1; x2--)
                    {
                        for (int y2 = n; y2 > y1; y2--)
                        {
                            areaFig = (x2 - x1) * (y2 - y1);

                            if (areaFig >= areaMin)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", x1, y1, x2, y2, areaFig);
                                countFigures++;
                            }
                        }
                    }
                }
            }
            if (countFigures == 0)
                Console.WriteLine("No");
        }
    }
}
