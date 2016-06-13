using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Text_Bombardment
{
    class _04_Text_Bombardment
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int cols = int.Parse(Console.ReadLine()); // line width
            int[] columnsToErase = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // create matrix
            int rows = text.Length / cols;
            if (text.Length % cols > 0) rows++;
            char[,] matrix = new char[rows, cols];
            FillInMatrix(matrix, text);

            // create bool matrix to track protected status of cells
            bool[,] protectedCells = new bool[rows, cols]; // cells = false by default
            MarkProtectedCells(protectedCells, matrix);

            // bomb matrix and print result
            GetBombedMatrix(matrix, columnsToErase, protectedCells);
            PrintMatrixToString(matrix, text.Length);

        }
        static void GetBombedMatrix(char[,] matrix, int[] columnsToErase, bool[,] statusMatrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < columnsToErase.Length; i++)
            {
                int col = columnsToErase[i];
                for (int row = 0; row < rows; row++) // bomb all unprotected cells, bombed cells new value = ' '
                    if (statusMatrix[row, col] == false)
                        matrix[row, col] = ' ';
            }
        }
        static void MarkProtectedCells(bool[,] protectedCells, char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
                for (int row = 1; row < rows; row++)
                    if (protectedCells[row - 1, col] == true)
                        for (int i = row; i < rows; i++)
                            protectedCells[i, col] = true; // mark all cells below (incl.current) as protected
                    else if (matrix[row - 1, col] != ' ' && matrix[row, col] == ' ')
                        for (int i = row; i < rows; i++)
                            protectedCells[i, col] = true; // mark all cells below (incl.current) as protected
        }
        static void FillInMatrix(char[,] matrix, string text)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int index = 0;
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    if (index < text.Length)
                    {
                        matrix[row, col] = text[index];
                        index++;
                    }
                    else break;
        }
        static void PrintMatrixToString(char[,] matrix, int textLength)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int index = 0;
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    if (index < textLength)
                    {
                        Console.Write("{0}", matrix[row, col]);
                        index++;
                    }
                    else break;
        }
    }
}