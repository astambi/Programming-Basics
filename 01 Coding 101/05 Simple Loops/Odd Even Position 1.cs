using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Odd_Even_Position
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            double number = 0.0;
            double sumEven = 0.0;
            double minEven = double.MaxValue; 
            double maxEven = double.MinValue;
            double sumOdd = 0.0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;

            for (int i = 1; i <= n; i++) // [1,n] numbers
            {
                number = double.Parse(Console.ReadLine());
                bool evenPosition = i % 2 == 0;
                if (evenPosition)
                {
                    sumEven += number;
                    if (number > maxEven)
                        maxEven = number;
                    if (number < minEven)
                        minEven = number;
                }
                else //odd position
                {
                    sumOdd += number;
                    if (number > maxOdd)
                        maxOdd = number;
                    if (number < minOdd)
                        minOdd = number;
                }
            }
            if (n >= 1) 
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2},", sumOdd, minOdd, maxOdd);
            else 
                Console.WriteLine("OddSum={0},\nOddMin=No,\nOddMax=No,", sumOdd);
            if (n >= 2) 
                Console.WriteLine("EvenSum={0},\nEvenMin={1},\nEvenMax={2}", sumEven, minEven, maxEven);
            else 
                Console.WriteLine("EvenSum={0},\nEvenMin=No,\nEvenMax=No", sumEven);                        
        }
    }
}
