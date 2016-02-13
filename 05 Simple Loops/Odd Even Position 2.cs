using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position_2
{
    class Odd_Even_Position_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 0.0;
            double[] min = new double[] { 1000000000.0, 1000000000.0 };     // {odd, even}
            double[] max = new double[] { -1000000000.0, -1000000000.0 };   // {odd, even}
            double[] sum = new double[] { 0.0, 0.0 };                       // {odd, even}

            for (int i = 1; i <= n; i++) // [1,n] numbers
            {
                number = double.Parse(Console.ReadLine());
                bool evenPosition = i % 2 == 0;
                int j = 0;
                if (evenPosition)
                    j = 1;
                sum[j] += number;
                if (number > max[j])
                    max[j] = number;
                if (number < min[j])
                    min[j] = number;
            }
            if (max[0] != -1000000000.0) //neutral value change
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2},", sum[0], min[0], max[0]);
            else // no change in neutral value => no input 
                Console.WriteLine("OddSum={0},\nOddMin=No,\nOddMax=No,", sum[0]);
            if (max[1] != -1000000000.0) //neutral value change
                Console.WriteLine("EvenSum={0},\nEvenMin={1},\nEvenMax={2}", sum[1], min[1], max[1]);
            else // no change in neutral value => no input
                Console.WriteLine("EvenSum={0},\nEvenMin=No,\nEvenMax=No", sum[1]);
        }
    }
}
