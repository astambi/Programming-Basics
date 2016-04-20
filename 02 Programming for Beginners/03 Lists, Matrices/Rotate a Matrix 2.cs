using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_a_Matrix_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            // get matrix
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] cells = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = cells[col];
            }

            // rotate matrix to the right
            string[,] rotatedMatrix = new string[cols, rows];
            for (int rotRow = 0; rotRow < cols; rotRow++)
            {
                for (int rotCol = 0; rotCol < rows; rotCol++)
                    rotatedMatrix[rotRow, rotCol] = matrix[rows - 1 - rotCol, rotRow];
            }

            // print rotated matrix
            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                    Console.Write("{0} ", rotatedMatrix[row,col]);
                Console.WriteLine();
            }
        }
    }
}
