using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isEven = n % 2 == 0; 
            int middle = (n + 1) / 2;
            char diamondSymbol = '*';
            char background = '-';
            string outside = "";
            string inside = "";

            //fist & last rows
            int firstDiamondCount = 1; //odd n
            if (isEven)
                firstDiamondCount = 2; //even n
            string firstDiamond = new string(diamondSymbol, firstDiamondCount);
            //upper half
            int outsideCount = (n - firstDiamondCount) / 2;
            int insideCount = 0;
            for (int i = 0; i < middle; i++) 
            {
                outside = new string(background, outsideCount);
                inside = new string(background, insideCount);
                if (i == 0)
                    Console.WriteLine("{0}{1}{0}", outside, firstDiamond); //first row
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);
                --outsideCount;
                insideCount = n - 2 - 2 * outsideCount;
            }
            //lower half
            outsideCount = 1;
            for (int i = 1; i < middle - 1; i++) 
            {
                insideCount = n - 2 - 2 * outsideCount;
                outside = new string(background, outsideCount);
                inside = new string(background, insideCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);
                ++outsideCount;
            }
            //last row
            if (n > 2)
            {
                outside = new string(background, (n - firstDiamondCount) / 2);
                Console.WriteLine("{0}{1}{0}", outside, firstDiamond);
            }
        }
    }
}
