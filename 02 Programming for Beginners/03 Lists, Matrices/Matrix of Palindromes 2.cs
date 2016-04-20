using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = GetMatrixOfPalindroms();

            PrintMatrix(matrix);
        }

        static string[,] GetMatrixOfPalindroms()
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            string[,] matrix = new string[rows, cols];
            char letter = 'a';

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = string.Empty
                                    + (char)((int)letter + row)
                                    + (char)((int)letter + row + col)
                                    + (char)((int)letter + row);
                }
            }
            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    Console.Write("{0} ", matrix[row, col]);
                Console.WriteLine();
            }
        }
    }
}