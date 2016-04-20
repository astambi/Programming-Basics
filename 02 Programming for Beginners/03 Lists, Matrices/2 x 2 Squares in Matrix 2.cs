using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = GetMatrix();

            int countMatrices = CountMatricesOfEqualElements(matrix);
            Console.WriteLine(countMatrices);
        }

        static int CountMatricesOfEqualElements(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int count = 0; // 2x2 matrices of equal elements

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    bool isMatrixOfEqualElements = matrix[row, col] == matrix[row, col + 1] &&                                                   
                                                   matrix[row, col] == matrix[row + 1, col] &&
                                                   matrix[row, col] == matrix[row + 1, col + 1];
                    if (isMatrixOfEqualElements)
                        count++;
                }
            }
            return count;
        }        

        static char[,] GetMatrix()
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            return matrix;
        }
    }
}
