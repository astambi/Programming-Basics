using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Elements
{
    class Middle_Elements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = numbers.Length;
            int midIndex = len / 2;

            // odd len
            int start = midIndex - 1;
            int end = midIndex + 1;

            if (len == 1)
                start = end = 0;
            else if (len % 2 == 0)
                end--;

            for (int index = start; index <= end; index++)
                Console.Write("{0} ", numbers[index]);
        }
    }
}
