using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] count = { 0, 0, 0, 0, 0 };
            double countAll = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                ++countAll;
                if (number >= 800)
                    ++count[4];
                else if (number >= 600)
                    ++count[3];
                else if (number >= 400)
                    ++count[2];
                else if (number >= 200)
                    ++count[1];
                else
                    ++count[0];
            }

            for (int i = 0; i < 5; i++)
                Console.WriteLine("{0:0.00}%", 100 * count[i] / countAll);
        }
    }
}
