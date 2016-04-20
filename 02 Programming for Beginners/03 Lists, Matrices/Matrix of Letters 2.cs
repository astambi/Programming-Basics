using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Letters_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] matrixLetters = new char[rows, cols];
            char letter = 'A';

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrixLetters[row, col] = letter++; // NB!
                    if (letter > 'Z') letter = 'A';     // not actually required
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    Console.Write("{0} ", matrixLetters[row, col]);
                Console.WriteLine();
            }
        }
    }
}
