using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Left_and_Right_Sum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 2*n numbers
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
                sumLeft += int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                sumRight += int.Parse(Console.ReadLine());

            int difference = Math.Abs(sumLeft - sumRight);
            if (difference == 0)
                Console.WriteLine("Yes, sum = {0}", sumLeft);
            else
                Console.WriteLine("No, diff = {0}", difference);
        }
    }
}
