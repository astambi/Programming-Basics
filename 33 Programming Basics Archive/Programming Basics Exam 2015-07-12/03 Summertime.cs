using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Summertime
{
    class Summertime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int widthTop = n + 1;
            int widthBottom = 2 * n;
            char bottle = '*';
            char liquid = '@';
            char background = ' ';
            char empty = '.';

            string topBackground = new string(background, (widthBottom - widthTop) / 2);
            string top = new string(bottle, widthTop);
            Console.WriteLine("{0}{1}", topBackground, top);

            int curveCount = (widthBottom - widthTop) / 2; 

            string topEmpty = new string(background, widthTop - 2);
            for (int i = 0; i < n - curveCount; i++)
                Console.WriteLine("{0}{1}{2}{1}", topBackground, bottle, topEmpty);

            for (int i = 1; i < curveCount; i++)
            {
                widthTop += 2;
                int widthCurve = (widthBottom - widthTop)/2;
                string curveBackground = new string(background, widthCurve);
                string curveEmpty = new string(background, widthBottom - 2 - 2 * widthCurve);
                Console.WriteLine("{0}{1}{2}{1}", curveBackground, bottle, curveEmpty); 
            }
            
            string insideEmpty = new string(empty, widthBottom - 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}{1}{0}", bottle, insideEmpty);

            string insideLiquid = new string(liquid, widthBottom - 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}{1}{0}", bottle, insideLiquid);

            string bottom = new string(bottle, widthBottom);
            Console.WriteLine(bottom);
        }
    }
}
