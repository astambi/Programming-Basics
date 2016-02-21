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
            //upper half
            for (int i = 1; i <= middle; i++)
            {
                int insideWidth = n - 2 - outsideWidth;
                string backgroundEdge = new string(backgroundSymbol, outsideWidth);
                string dumbbell = dumbbellEdgeSymbol + new string(dumbbellInsideSymbol, insideWidth) + dumbbellEdgeSymbol;

                if (i == 1) 
                    Console.WriteLine("{0}{1}{2}{1}{0}", backgroundEdge, dumbbellTop, backgroundMid); //first row
                else if (i == middle) 
                    Console.WriteLine("{0}{1}{0}", dumbbell, handle); //handle
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", backgroundEdge, dumbbell, backgroundMid);
                --outsideWidth;
            }
            //lower half
            outsideWidth = 1;
            for (int i = middle - 1; i > 0 ; i--)
            {
                int insideWidth = n - 2 - outsideWidth;
                string backgroundEdge = new string(backgroundSymbol, outsideWidth);
                string dumbbell = dumbbellEdgeSymbol + new string(dumbbellInsideSymbol, insideWidth) + dumbbellEdgeSymbol;
                if (i == 1)
                    Console.WriteLine("{0}{1}{2}{1}{0}", backgroundEdge, dumbbellTop, backgroundMid); //last row
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", backgroundEdge, dumbbell, backgroundMid);
                ++outsideWidth;
            }
        }
    }
}
