using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Matrix
{
    class Rotate_Matrix
    {
        static void Main(string[] args)
        {
            string[,] matrix = GetMatrix();

            string[,] rotatedMatrix = GetRotatedMatrix(matrix);

            PrintMatrix(rotatedMatrix);
        }

        static string[,] GetRotatedMatrix(string[,] matrix)
        {
            int rows = matrix.GetLength(0); // original matrix rows, cols
            int cols = matrix.GetLength(1);
            
            int rotRows = cols;             // rotated matrix rows, cols
            int rotCols = rows;
            string[,] rotatedMatrix = new string[rotRows, rotCols];

            for (int rotRow = 0; rotRow < rotRows; rotRow++)
            {
                for (int rotCol = 0; rotCol < rotCols; rotCol++)
                    rotatedMatrix[rotRow, rotCol] = matrix[rows - 1 - rotCol, rotRow];
            }
            return rotatedMatrix;
        }

        static string[,] GetMatrix()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = elements[col];
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