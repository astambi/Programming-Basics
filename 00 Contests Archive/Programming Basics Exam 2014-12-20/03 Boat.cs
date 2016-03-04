using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Boat
{
    class Boat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n always odd
            int height = (n - 1) / 2;
            int mid = (n + 1) / 2;
            char boatSymbol = '*';
            char backgroundSymbol = '.';
            string background = "";
            string boat = "";
            string air = new string(backgroundSymbol, n);

            int sailWidth = -1;
            for (int i = 1; i <= mid; i++)
            {
                sailWidth += 2;
                background = new string(backgroundSymbol, n - sailWidth);
                boat = new string(boatSymbol, sailWidth);
                Console.WriteLine("{0}{1}{2}", background, boat, air);
            }
            for (int i = 1; i < mid; i++)
            {
                sailWidth -= 2;
                background = new string(backgroundSymbol, n - sailWidth);
                boat = new string(boatSymbol, sailWidth);
                Console.WriteLine("{0}{1}{2}", background, boat, air);
            }
            for (int i = 0; i < height; i++)
            {
                background = new string(backgroundSymbol, i);
                boat = new string(boatSymbol, 2 * n - 2 * i);
                Console.WriteLine("{0}{1}{0}", background, boat);
            }
        }
    }
}
