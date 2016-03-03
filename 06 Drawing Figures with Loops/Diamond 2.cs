using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_2
{
    class Diamond_2
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int middle = (width + 1) / 2;
            bool isEven = width % 2 == 0;
            string diamondSymbol = "*";     //working solution for long strings
            string backgroundSymbol = "-";  //working solution for long strings        

            //upper half
            for (int i = 1; i <= middle; i++)
            {
                string inside = "";
                string outside = "";
                for (int j = 0; j < middle - i; j++)
                    outside += backgroundSymbol;
                for (int j = 0; j < width - 2 * (middle - i) - 2; j++)
                    inside += backgroundSymbol;
                if (i == 1) //first row
                {
                    if (isEven)
                        Console.WriteLine("{0}{1}{1}{0}", outside, diamondSymbol); //even n
                    else 
                        Console.WriteLine("{0}{1}{0}", outside, diamondSymbol); //odd n
                }
                else if (i == middle) //middle row
                    Console.WriteLine("{0}{1}{0}", diamondSymbol, inside);
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);                
            }
            //lower half
            for (int i = middle - 1; i >= 1; i--)
            {
                string inside = "";
                string outside = "";
                for (int j = 0; j < middle - i; j++)
                    outside += backgroundSymbol;
                for (int j = 0; j < width - 2 * (middle - i) - 2; j++)
                    inside += backgroundSymbol;
                if (i == 1) //last row
                {
                    if (isEven)
                        Console.WriteLine("{0}{1}{1}{0}", outside, diamondSymbol); //even n
                    else 
                        Console.WriteLine("{0}{1}{0}", outside, diamondSymbol); //odd n
                }
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);                
            }
        }
    }
}
