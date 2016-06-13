using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // always odd
            int radius = int.Parse(Console.ReadLine());
            int mid = (n + 1) / 2;
            char outsideSymbol = '.';
            char insideSymbol = '*';

            // upper half
            for (int row = 1; row <= mid; row++)
            {
                for (int col = 1; col <= mid; col++)
                {
                    double x = Math.Pow(mid - row, 2) + Math.Pow(mid - col, 2);
                    x = Math.Sqrt(x);
                    bool withinDisk = x <= radius;
                    if (withinDisk) Console.Write(insideSymbol);
                    else Console.Write(outsideSymbol);
                }
                for (int col = mid-1; col>=1 ; col--)
                {
                    double x = Math.Pow(mid - row, 2) + Math.Pow(mid - col, 2);
                    x = Math.Sqrt(x);
                    bool withinDisk = x <= radius;
                    if (withinDisk) Console.Write(insideSymbol);
                    else Console.Write(outsideSymbol);
                }
                Console.WriteLine();
            }
            // lower half
            for (int row = mid - 1; row >= 1; row--)
            {
                for (int col = 1; col <= mid; col++)
                {
                    double x = Math.Pow(mid - row, 2) + Math.Pow(mid - col, 2);
                    x = Math.Sqrt(x);
                    bool withinDisk = x <= radius;
                    if (withinDisk) Console.Write(insideSymbol);
                    else Console.Write(outsideSymbol);
                }
                for (int col = mid - 1; col >= 1; col--)
                {
                    double x = Math.Pow(mid - row, 2) + Math.Pow(mid - col, 2);
                    x = Math.Sqrt(x);
                    bool withinDisk = x <= radius;
                    if (withinDisk) Console.Write(insideSymbol);
                    else Console.Write(outsideSymbol);
                }
                Console.WriteLine();
            }            
        }
    }
}
