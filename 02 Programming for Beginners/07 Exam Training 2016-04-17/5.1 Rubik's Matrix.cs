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
            int numberOfCommands = int.Parse(Console.ReadLine());

            int[,] rotatedMatrix = CopyMatrix(matrix);
            rotatedMatrix = GetRotatedMatrix(rotatedMatrix, numberOfCommands);
            //PrintMatrix(matrix);
            //PrintMatrix(rotatedMatrix);

            SwapRotatedMatrixBackToOriginal(rotatedMatrix, matrix);
            //PrintMatrix(matrix);
            //PrintMatrix(rotatedMatrix);
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

        static int[,] GetRotatedMatrix(int[,] matrix, int numberOfCommands)
        {
            for (int command = 0; command < numberOfCommands; command++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                int rowColToRotate = int.Parse(input[0]);
                string rotationDirection = input[1];
                int numberOfRotations = int.Parse(input[2]);

                bool rowRotation = rotationDirection == "left"  || rotationDirection == "right";
                bool colRotation = rotationDirection == "up"    || rotationDirection == "down";

                if (rowRotation)        numberOfRotations %= matrix.GetLength(1);   // cols
                else if (colRotation)   numberOfRotations %= matrix.GetLength(0);   // rows
                                
                for (int rotation = 0; rotation < numberOfRotations; rotation++)
                {
                    if (colRotation)        matrix = RotateMatrixCol(matrix, rowColToRotate, rotationDirection);
                    else if (rowRotation)   matrix = RotateMatrixRow(matrix, rowColToRotate, rotationDirection);
                }                        
            }
            return matrix;
        }

        static int[,] RotateMatrixRow(int[,] matrix, int rowToRotate, string rotationDirection)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] rotatedRow = new int[rows];

            // get rotated Row elements
            if (rotationDirection == "left")
            {
                for (int col = 0; col < cols - 1; col++)
                    rotatedRow[col] = matrix[rowToRotate, col + 1]; // rotated[col] = original[col+1]
                rotatedRow[cols - 1] = matrix[rowToRotate, 0];      // rotated[LastCol] = original[0]
            }
            else if (rotationDirection == "right")
            {
                rotatedRow[0] = matrix[rowToRotate, cols - 1];      // rotated[0] = original[LastCol]
                for (int col = 1; col < cols; col++)
                    rotatedRow[col] = matrix[rowToRotate, col - 1]; // rotated[col] = original[col-1]
            }
            // update rotated row in matrix 
            for (int col = 0; col < cols; col++)
                matrix[rowToRotate, col] = rotatedRow[col];
            return matrix;
        }

        static int[,] RotateMatrixCol(int[,] matrix, int colToRotate, string rotationDirection)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] rotatedCol = new int[cols];

            // get rotated Col elements
            if (rotationDirection == "down")
            {
                rotatedCol[0] = matrix[rows - 1, colToRotate];      // rotated[0] = original[LastRow]
                for (int row = 1; row < rows; row++)
                    rotatedCol[row] = matrix[row - 1, colToRotate]; // rotated[row] = original[row-1]
            }
            else if (rotationDirection == "up")
            {
                for (int row = 0; row < rows - 1; row++)
                    rotatedCol[row] = matrix[row + 1, colToRotate]; // rotated[row] = original[row+1]
                rotatedCol[rows - 1] = matrix[0, colToRotate];      // rotated[LastRow] = original[0]
            }
            // update rotated col in matrix
            for (int row = 0; row < rows; row++)
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

            for (int row = 0; row < rows; row++)    // 1,2,3...
            {
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = number++;
            }
            return matrix;
        }
    }
}