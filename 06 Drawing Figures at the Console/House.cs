using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int heightRoof = (n + 1) / 2;
            int heightBase = n - heightRoof;
            char symbol = '*';
            char background = '-';

            int roofCount = 1;
            if (n % 2 == 0)
                roofCount = 2;
            for (int i = 1; i <= heightRoof; i++)
            {
                string roof = new string(symbol, roofCount);
                string outside = new string(background, (n - roofCount) / 2);
                Console.WriteLine("{0}{1}{0}", outside, roof);
                roofCount += 2;
            }
            string house = new string(symbol, n - 2);
            for (int i = 0; i < heightBase; i++)
                Console.WriteLine("|{0}|", house);
        }
    }
}
