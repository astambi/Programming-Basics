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
            // get the target cell and set the boundaries of the surrounding cells
            int[] targetCell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] boundaries = GetBoundariesSurroundingCells(targetCell, matrix);

            // modify the target cell and all surrounding cells 
            ModifyMatrix(matrix, targetCell, boundaries);
            // print the modified matrix
            PrintMatrix(matrix);
        }

        static int[] GetBoundariesSurroundingCells(int[] targetCell, int[,] matrix)
        {
            // target cell
            int targetRow = targetCell[0];
            int targetCol = targetCell[1];
            // set the boundaries of the surrounding cells
            int[] boundaries = new int[4] { Math.Max(targetRow - 1, 0),                         // top
                                            Math.Min(targetRow + 1, matrix.GetLength(0) - 1),   // bottom
                                            Math.Max(targetCol - 1, 0),                         // left
                                            Math.Min(targetCol + 1, matrix.GetLength(1) - 1)};  // right
            return boundaries;
        }

        static void ModifyMatrix(int[,] matrix, int[] targetedCell, int[] boundaries)
        {
            int sumSurrouningCells = GetSumSurroundingCells(matrix, targetedCell, boundaries);
            // target cell
            int targetRow = targetedCell[0];
            int targetCol = targetedCell[1];
            // modify all surrounding cells
            for (int row = boundaries[0]; row <= boundaries[1]; row++)          // row within [top, bottom] boundaries
            {
                for (int col = boundaries[2]; col <= boundaries[3]; col++)      // col within [left, right] boundaries
                {
                    bool isTargetedCell =   row == targetRow && col == targetCol;
                    if (!isTargetedCell)   
                        matrix[row, col] *= matrix[targetRow, targetCol];       // target cell initial value
                }
            }
            // modify the target cell
            matrix[targetRow, targetCol] *= sumSurrouningCells; 
        }

        static int GetSumSurroundingCells(int[,] matrix, int[] targetedCell, int[] boundaries)
        {
            // target cell
            int targetRow = targetedCell[0];
            int targetCol = targetedCell[1];
            // sum the values of the surrounding cells
            int sum = -matrix[targetRow, targetCol];                        // exclude target cell from sum
            for (int row = boundaries[0]; row <= boundaries[1]; row++)      // row within [top, bottom] boundaries
            {
                for (int col = boundaries[2]; col <= boundaries[3]; col++)  // col within [left, right] boundaries
                    sum += matrix[row, col];
            }
            return sum;
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