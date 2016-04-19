using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Min_Max_First_Last_Average
{
    class Sum_Min_Max_First_Last_Average
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("First = {0}", numbers.First());
            Console.WriteLine("Last = {0}", numbers.Last());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}
