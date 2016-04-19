using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Half_Sum_Element
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n numbers
            int number = int.Parse(Console.ReadLine()); //1st number
            int sum = number;
            int max = number;

            for (int i = 0; i < n - 1; i++) //next n-1 numbers
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > max)
                    max = number;
            }
            bool maxEqualsSumOfOtherNumbers = max == (sum - max);
            if (maxEqualsSumOfOtherNumbers) 
                Console.WriteLine("Yes\nSum = {0}", max);
            else
                Console.WriteLine("No\nDiff = {0}", Math.Abs(2 * max - sum)); //diff max & (sum-max)
        }
    }
}
