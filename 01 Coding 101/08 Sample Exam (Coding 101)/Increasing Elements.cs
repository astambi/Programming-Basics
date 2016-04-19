using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Elements
{
    class Increasing_Elements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousNumber = 0;
            int maxLen = 1;
            int currentLen = 1;

            if (n > 0)
                previousNumber = int.Parse(Console.ReadLine());
            else
                maxLen = 0;

            for (int i = 2; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > previousNumber)
                    currentLen++;
                else
                    currentLen = 1;
                if (maxLen < currentLen)
                    maxLen = currentLen;

                previousNumber = currentNumber;
            }
            Console.WriteLine(maxLen);
        }
    }
}
