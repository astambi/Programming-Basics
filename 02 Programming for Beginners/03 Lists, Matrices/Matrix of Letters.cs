using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows =  int.Parse(Console.ReadLine());
            int cols =  int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, cols];

            char letter = 'A';
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = letter++;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write("{0} ", matrix[i, j]);
                Console.WriteLine();
            }                
        }
    }
}
