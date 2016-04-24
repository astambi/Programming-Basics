using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Targeted_Cell
{
    class Multiply_Targeted_Cell
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrix();

            // get the target cell
            int[] targetCell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int targetRow = targetCell[0];
            int targetCol = targetCell[1]; 
            // set the boundaries of the surrounding cells
            int boundariesTop =     Math.Max(targetRow - 1, 0); 
            int boundariesBottom =  Math.Min(targetRow + 1, matrix.GetLength(0) - 1); 
            int boundariesLeft =    Math.Max(targetCol - 1, 0);  
            int boundariesRight =   Math.Min(targetCol + 1, matrix.GetLength(1) - 1);
            
            // get the sum of the surrounding cells
            int sumSurrouningCells = -matrix[targetRow, targetCol];             // exclude target cell from sum
            for (int row = boundariesTop; row <= boundariesBottom; row++)       // row within [top, bottom] boundaries
            {
                for (int col = boundariesLeft; col <= boundariesRight; col++)   // col within [left, right] boundaries
                    sumSurrouningCells += matrix[row, col];
            }
            // modify the surrounding cells
            for (int row = boundariesTop; row <= boundariesBottom; row++)
            {
                for (int col = boundariesLeft; col <= boundariesRight; col++)
                {
                    bool isTargetCell = row == targetRow && col == targetCol;
                    if(!isTargetCell)
                        matrix[row, col] *= matrix[targetRow, targetCol];       // target cell initial value
                }
            }
            // modify the target cell
            matrix[targetRow, targetCol] *= sumSurrouningCells;
            // print the modified matrix
            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
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

        static int[,] GetMatrix()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                    matrix[row, col] = elements[col];
            }
            return matrix;
        }
    }
}
