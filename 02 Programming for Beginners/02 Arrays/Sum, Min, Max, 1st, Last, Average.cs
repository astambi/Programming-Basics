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
            int[] number = new int[n];
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                sum += number[i];
                if (max < number[i]) max = number[i];
                if (min > number[i]) min = number[i];
            }
            double average = 1.00 * sum / n;
            Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nFirst = {3}\nLast = {4}\nAverage = {5}", sum, min, max, number[0], number[n - 1], average);
        }
    }
}
