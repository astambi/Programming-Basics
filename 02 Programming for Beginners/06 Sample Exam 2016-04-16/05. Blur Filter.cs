using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Blur_Filter
{
    class Blur_Filter
    {
        static void Main(string[] args)
        {
            long blurAmount = long.Parse(Console.ReadLine());
            long[,] matrix = GetMatrix();
            int[] targetPixel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // focus of blur filter

            long[,] modifiedMatrix = GetModifiedMatrix(matrix, targetPixel, blurAmount);

            PrintMatrix(modifiedMatrix);
            //PrintMatrix(matrix); // original matrix unchanged
        }

        static long[,] GetMatrix()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            long[,] matrix = new long[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                long[] elements = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = elements[col];
            }
            return matrix;
        }

        static void PrintMatrix(long[,] matrix)
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

        static long[,] GetModifiedMatrix(long[,] matrix, int[] targetPixel, long blurAmount)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int targetRow = targetPixel[0];
            int targetCol = targetPixel[1];

            long[,] modifiedMatrix = new long[rows, cols];  // NB! NEW matrix: original matrix unchanged
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    modifiedMatrix[row, col] = matrix[row, col];
            }
            // NB!!! modifiedMatrix = matrix => original matrix changes as well

            // filter boundaries (row +/-1, col +/- 1 away from targer pixel) cannot go outside matrix borders
            int filterLeft = Math.Max(0, targetCol - 1);          // limited by first col
            int filterRight = Math.Min(targetCol + 1, cols - 1);  // limited by last col
            int filterTop = Math.Max(0, targetRow - 1);           // limited by first row
            int filterBottom = Math.Min(targetRow + 1, rows - 1); // limited by last row

            // apply blur filter 
            for (int row = filterTop; row <= filterBottom; row++)
            {
                for (int col = filterLeft; col <= filterRight; col++)
                    modifiedMatrix[row, col] += blurAmount;
            }
            return modifiedMatrix;
        }
    }
}
