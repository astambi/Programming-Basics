using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fit_Box_in_Box
{
    class Fit_Box_in_Box
    {
        static void Main(string[] args)
        {
            int w1 = int.Parse(Console.ReadLine()); // box1: width, height, depth
            int h1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine()); // box2: width, height, depth
            int h2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());

            int min = Math.Min(Math.Min(w2, h2), d2);
            int max = Math.Max(Math.Max(w2, h2), d2);                      
            for (int i1 = min; i1 <= max; i1++)
                for (int i2 = min; i2 <= max; i2++)
                    for (int i3 = min; i3 <= max; i3++)
                    {
                        bool is2 =  Math.Min(Math.Min(i1, i2), i3) == min &&
                                    Math.Max(Math.Max(i1, i2), i3) == max &&
                                    i1 + i2 + i3 == w2 + h2 + d2;
                        bool fit1in2 = w1 < i1 && h1 < i2 && d1 < i3;
                        if (is2 && fit1in2)
                            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                                        w1, h1, d1, 
                                        i1, i2, i3);
                    }
            min = Math.Min(Math.Min(w1, h1), d1);
            max = Math.Max(Math.Max(w1, h1), d1);
            for (int i1 = min; i1 <= max; i1++)
                for (int i2 = min; i2 <= max; i2++)
                    for (int i3 = min; i3 <= max; i3++)
                    {
                        bool is1 =  Math.Min(Math.Min(i1, i2), i3) == min &&
                                    Math.Max(Math.Max(i1, i2), i3) == max &&
                                    i1 + i2 + i3 == w1 + h1 + d1;
                        bool fit2in1 = w2 < i1 && h2 < i2 && d2 < i3;
                        if (is1 && fit2in1)
                            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                                        w2, h2, d2, 
                                        i1, i2, i3);
                    }
        }
    }
}
