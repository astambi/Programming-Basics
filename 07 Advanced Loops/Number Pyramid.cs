using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Number_Pyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 0;

            for (int i = 1; i <= (n + 1) / 2 + 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNumber < n)
                    {
                        currentNumber += 1;
                        Console.Write("{0} ", currentNumber);
                    }
                    else break;                    
                }
                Console.WriteLine();

                if (currentNumber == n)
                    break;
            }

        }
    }
}