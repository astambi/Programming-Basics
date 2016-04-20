using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // get matrix
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());            
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] cells = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = cells[col];
            }

            // rotate matrix to the right
            string[,] rotatedMatrix = new string[cols, rows];

            for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
                    rotatedMatrix[row, col] = matrix[matrix.GetLength(0) - 1 - col, row];
            }                

            // print rotated matrix
            for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
                    Console.Write("{0} ",rotatedMatrix[row, col]);
                Console.WriteLine();
            }            
        }
    }
}
