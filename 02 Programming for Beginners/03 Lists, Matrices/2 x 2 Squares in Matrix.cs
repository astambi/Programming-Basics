using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_x_2_Squares_in_Matrix
{
    class _2_x_2_Squares_in_Matrix
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            char[,] matrix = new char[rows, cols];
            // get matrix
            for (int row = 0; row < rows; row++)
            {
                char[] cells = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = cells[col];
            }
            // find 2 x 2 matrices of equal elements
            int countMatrices = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (IsMatrixOfEqualElements(matrix, row, col))
                        countMatrices++;
                }
            }
            Console.WriteLine(countMatrices);
        }
        static bool IsMatrixOfEqualElements(char[,] matrix, int row, int col)
        {
            return  matrix[row, col] == matrix[row, col + 1] &&
                    matrix[row, col] == matrix[row + 1, col] &&
                    matrix[row, col] == matrix[row + 1, col + 1];
        }
    }
}
