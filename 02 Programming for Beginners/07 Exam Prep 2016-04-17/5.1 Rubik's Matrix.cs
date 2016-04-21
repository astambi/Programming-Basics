using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Rubik_s_Matrix
{
    class Rubik_s_Matrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrix();
            int numberOfCommands = int.Parse(Console.ReadLine());

            int[,] rotatedMatrix = matrix;
            rotatedMatrix = GetRotatedMatrix(rotatedMatrix, numberOfCommands);

            SwapMatrixElementsBackToOriginal(rotatedMatrix, matrix);
        }
        
        static void SwapMatrixElementsBackToOriginal (int[,] matrixToSwap, int[,] targetMatrix)
        {
            int rows = matrixToSwap.GetLength(0);
            int cols = matrixToSwap.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int currentElement = matrixToSwap[row, col];
                    int targetElement = targetMatrix[row, col];

                    if (currentElement != targetElement)
                    {
                        bool foundElement = false;
                        for (int searchRow = 0; searchRow < rows; searchRow++)
                        {
                            for (int searchCol = 0; searchCol < cols; searchCol++)
                            {
                                foundElement = matrixToSwap[searchRow, searchCol] == targetElement &&
                                               matrixToSwap[searchRow, searchCol] != currentElement;
                                if (foundElement)
                                {
                                    matrixToSwap[row, col] = targetElement;
                                    matrixToSwap[searchRow, searchCol] = currentElement;
                                    Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", row, col, searchRow, searchCol);
                                    break;
                                }
                            }
                            if (foundElement) break;
                        }
                    }
                    else Console.WriteLine("No swap required");
                }
            }
        }

        static int[,] GetRotatedMatrix(int[,] matrix, int numberOfCommands)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                // {row/ col to rotate} {rotation direction} {number of rotations}

                int rowColToRotate = int.Parse(input[0]);

                string direction = input[1];
                bool rowRotation = direction == "left" || direction == "right";
                bool colRotation = direction == "up"   || direction == "down";

                int numberOfRotations = int.Parse(input[2]);
                if (rowRotation)        numberOfRotations %= rows;
                else if (colRotation)   numberOfRotations %= cols;

                for (int rotation = 0; rotation < numberOfRotations; rotation++)
                {
                    int[,] tempMatrix = null;
                    if (rowRotation)
                        tempMatrix = GetMatrixAfterRowRotation(matrix, rowColToRotate, direction);
                    else if (colRotation)
                        tempMatrix = GetMatrixAfterColRotation(matrix, rowColToRotate, direction);
                    matrix = tempMatrix;
                }
            }
            return matrix;
        }

        static int[,] GetMatrixAfterRowRotation(int[,] matrix, int rotatedRow, string direction)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int lastRow = rows - 1;
            int lastCol = cols - 1;
            int[,] rotatedMatrix = new int[rows, cols];

            // get new elements for rotated row
            switch (direction)
            {
                case "left": 
                    // col: element (i) (Rotated matrix) = element (i+1) (Original matrix) 
                    // col: Last element (Rot matrix) = First element (Original matrix)
                    for (int col = 0; col < lastCol; col++)
                        rotatedMatrix[rotatedRow, col] = matrix[rotatedRow, col + 1];
                    rotatedMatrix[rotatedRow, lastCol] = matrix[rotatedRow, 0];
                    break;
                case "right":
                    // col: element (i) (Rotated matrix) = element (i-1) (Original matrix) 
                    // col: First element (Rot matrix) = Last element (Original matrix)
                    rotatedMatrix[rotatedRow, 0] = matrix[rotatedRow, lastCol];
                    for (int col = 1; col <= lastCol; col++)
                        rotatedMatrix[rotatedRow, col] = matrix[rotatedRow, col - 1];                       
                    break;
            }
            // copy the rest of the elements
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row != rotatedRow)
                        rotatedMatrix[row, col] = matrix[row, col];
                }
            }
            return rotatedMatrix;
        }

        static int[,] GetMatrixAfterColRotation(int[,] matrix, int rotatedCol, string direction)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int lastRow = rows - 1;
            int lastCol = cols - 1;
            int[,] rotatedMatrix = new int[rows, cols];

            // get new elements for rotated col
            switch (direction)
            {
                case "down":
                    // row: element (i) (Rotated matrix) = element (i-1) (Original matrix) 
                    // row: First element (Rot matrix) = Last element (Original matrix)
                    rotatedMatrix[0, rotatedCol] = matrix[lastRow, rotatedCol];
                    for (int row = 1; row <= lastRow; row++)
                        rotatedMatrix[row, rotatedCol] = matrix[row - 1, rotatedCol];
                    break;
                case "up":
                    // row: element (i) (Rotated matrix) = element (i+1) (Original matrix) 
                    // row: Last element (Rot matrix) = First element (Original matrix)
                    for (int row = 0; row < lastRow; row++)
                        rotatedMatrix[row, rotatedCol] = matrix[row + 1, rotatedCol];
                    rotatedMatrix[lastRow, rotatedCol] = matrix[0, rotatedCol]; 
                    break;
            }
            // copy the rest of the elements
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col != rotatedCol)
                        rotatedMatrix[row, col] = matrix[row, col];
                }
            }
            return rotatedMatrix;
        }
        
        static int[,] GetMatrix()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int number = 1;

            int[,] matrix = new int[rows, cols]; // 1,2,3,...
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = number++;
            }
            return matrix;
        }
    }
}