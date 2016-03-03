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
            int areaRectangle = 0;
            int countRectangles = 0;
            // rectangle defined by diagonal (x1, y1) (x2, y2) 
            // -n <= x1 <= x2 <= n
            // -n <= y1 <= y2 <= n
            for (int x1 = -n; x1 <= n; x1++)                        // x1 [-n, n]
            {
                for (int y1 = -n; y1 <= n; y1++)                    // y1 [-n, n]
                {
                    for (int x2 = n; x2 > x1; x2--)                 // x2 (x1, n]
                    {
                        for (int y2 = n; y2 > y1; y2--)             // y2 (y1, n]
                        {
                            areaRectangle = (x2 - x1) * (y2 - y1);

                            if (areaRectangle >= areaMin)           // min area rectangle (x1, y1) (x2, y2)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", x1, y1, x2, y2, areaRectangle);
                                countRectangles++;
                            }
                        }
                    }
                }
            }
            if (countRectangles == 0)
                Console.WriteLine("No");
        }
    }
}
