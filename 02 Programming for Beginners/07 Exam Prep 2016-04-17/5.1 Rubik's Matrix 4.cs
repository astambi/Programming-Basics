using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Rubik_s_Matrix
{
    class Rubik_s_Matrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrix();
            int[,] rotatedMatrix = CopyMatrix(matrix);
            int numberOfCommands = int.Parse(Console.ReadLine());

            rotatedMatrix = RotateMatrix(rotatedMatrix, numberOfCommands);

            SwapRotatedMatrixBackToOriginal(rotatedMatrix, matrix);
        }

        static int[,] RotateMatrix(int[,] matrix, int numberOfCommands)
        {
            for (int command = 0; command < numberOfCommands; command++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                int rowColToRotate = int.Parse(input[0]);
                string rotationDirection = input[1];
                int numberOfRotations = int.Parse(input[2]);

                if (rotationDirection == "up" || rotationDirection == "down")
                {
                    numberOfRotations %= matrix.GetLength(0);   // rows
                    for (int rotation = 0; rotation < numberOfRotations; rotation++)
                        matrix = GetRotatedMatrixCol(matrix, rowColToRotate, rotationDirection);
                }
                else if (rotationDirection == "left" || rotationDirection == "right")
                {
                    numberOfRotations %= matrix.GetLength(1);   // cols
                    for (int rotation = 0; rotation < numberOfRotations; rotation++)
                        matrix = GetRotatedMatrixRow(matrix, rowColToRotate, rotationDirection);
                }
            }
            return matrix;
        }

        static void SwapRotatedMatrixBackToOriginal(int[,] rotatedMatrix, int[,] targetMatrix)
        {
            int rows = targetMatrix.GetLength(0);
            int cols = targetMatrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (rotatedMatrix[row, col] == targetMatrix[row, col])
                        Console.WriteLine("No swap required");
                    else
                    {
                        bool foundSwapElement = false;
                        for (int swapRow = row; swapRow < rows; swapRow++)
                        {
                            for (int swapCol = 0; swapCol < cols; swapCol++)
                            {
                                if (rotatedMatrix[swapRow, swapCol] == targetMatrix[row, col] &&
                                    rotatedMatrix[swapRow, swapCol] != rotatedMatrix[row, col])
                                {
                                    Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", row, col, swapRow, swapCol);
                                    rotatedMatrix[swapRow, swapCol] = rotatedMatrix[row, col];
                                    rotatedMatrix[row, col] = targetMatrix[row, col];
                                    foundSwapElement = true;
                                    break;
                                }
                            }
                            if (foundSwapElement) break;
                        }
                    }
                }
            }
        }

        static int[,] GetRotatedMatrixRow(int[,] matrix, int rowToRotate, string rotationDirection)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] rotatedRow = new int[rows];

            // rotate matrix row
            if (rotationDirection == "left")
            {
                for (int col = 0; col < cols - 1; col++)
                    rotatedRow[col] = matrix[rowToRotate, col + 1];
                rotatedRow[cols - 1] = matrix[rowToRotate, 0];  // first element in original matrix
            }
            else if (rotationDirection == "right")
            {
                rotatedRow[0] = matrix[rowToRotate, cols - 1];  // last element in original matrix
                for (int col = 1; col < cols; col++)
                    rotatedRow[col] = matrix[rowToRotate, col - 1];
            }
            // update matrix 
            for (int col = 0; col < matrix.GetLength(1); col++)
                matrix[rowToRotate, col] = rotatedRow[col];
            return matrix;
        }

        static int[,] GetRotatedMatrixCol(int[,] matrix, int colToRotate, string rotationDirection)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] rotatedCol = new int[cols];

            // rotate matrix col
            if (rotationDirection == "down")
            {
                rotatedCol[0] = matrix[rows - 1, colToRotate];  // last col element in original matrix
                for (int row = 1; row < rows; row++)
                    rotatedCol[row] = matrix[row - 1, colToRotate];
            }
            else if (rotationDirection == "up")
            {
                for (int row = 0; row < rows - 1; row++)
                    rotatedCol[row] = matrix[row + 1, colToRotate];
                rotatedCol[rows - 1] = matrix[0, colToRotate];  // first col element in original matrix
            }
            // update matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
                matrix[row, colToRotate] = rotatedCol[row];
            return matrix;
        }

        static int[,] CopyMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] matrixCopy = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    matrixCopy[row, col] = matrix[row, col];
            }
            return matrixCopy;
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
            int number = 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = number++;
            }
            return matrix;
        }
    }
}