using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dumbbell
{
    class Dumbbell
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n always odd
            int middle = (n + 1) / 2;
            char dumbbellEdgeSymbol = '&';
            char dumbbellInsideSymbol = '*';
            char backgroundSymbol = '.';
            char handleSymbol = '=';

            string dumbbellTop = new string(dumbbellEdgeSymbol, middle);
            string handle = new string(handleSymbol, n);
            string backgroundMid = new string(backgroundSymbol,n);

            int outsideWidth = n - middle;
            // upper half
            for (int i = 1; i <= middle; i++)
            {
                int insideWidth = n - 2 - outsideWidth;
                string backgroundEdge = new string(backgroundSymbol, outsideWidth);
                string inside = new string(dumbbellInsideSymbol, insideWidth);

                if (i == 1)             //first row
                    Console.WriteLine("{0}{1}{2}{1}{0}", backgroundEdge, dumbbellTop, backgroundMid);   
                else if (i == middle)   //handle
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", backgroundEdge, dumbbellEdgeSymbol, inside, handle);        
                else
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", backgroundEdge, dumbbellEdgeSymbol, inside, backgroundMid);
                --outsideWidth;
            }
            // lower half
            outsideWidth = 1;
            for (int i = middle - 1; i > 0 ; i--)
            {
                int insideWidth = n - 2 - outsideWidth;
                string backgroundEdge = new string(backgroundSymbol, outsideWidth);
                string inside = new string(dumbbellInsideSymbol, insideWidth);
                if (i == 1)             //last row
                    Console.WriteLine("{0}{1}{2}{1}{0}", backgroundEdge, dumbbellTop, backgroundMid); 
                else
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", backgroundEdge, dumbbellEdgeSymbol, inside, backgroundMid);
                ++outsideWidth;
            }
        }
    }
}
