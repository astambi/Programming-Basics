using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Dress_Pattern
{
    class Dress_Pattern
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 12 * n + 2;
            int widthSleeve = 3 * n;

            char outlineSymbol = '.';
            char dressSymbol = '*';
            char backgroundSymbol = '_';
            char beltSymbol = 'o';
            string dress = "";

            // straps top row
            int backgroundCount = 4 * n;
            string background = new string(backgroundSymbol, backgroundCount);
            Console.WriteLine("{0}.{0}.{0}", background);

            // straps            
            while (backgroundCount > 0)
            {
                backgroundCount -= 2; // == inside count
                background = new string(backgroundSymbol, backgroundCount);
                dress = new string(dressSymbol, (width - 4 - 3 * backgroundCount) / 2);
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}", background, dress);
            }

            // bodice 
            dress = new string(dressSymbol, width - 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine(".{0}.", dress);

            // waist
            background = new string(outlineSymbol, widthSleeve);
            dress = new string(dressSymbol, width - 2 * widthSleeve);
            Console.WriteLine("{0}{1}{0}", background, dress);

            // belt
            background = new string(backgroundSymbol, widthSleeve);
            dress = new string(beltSymbol, width - 2 * widthSleeve);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}{1}{0}", background, dress);

            // skirt
            for (int i = widthSleeve; i >= 0; i--)
            {
                background = new string(backgroundSymbol, i);
                if (i == 0)
                    dress = new string(outlineSymbol, width - 2 * i - 2);
                else
                    dress = new string(dressSymbol, width - 2 * i - 2);
                Console.WriteLine("{0}.{1}.{0}", background, dress);
            }
        }
    }
}