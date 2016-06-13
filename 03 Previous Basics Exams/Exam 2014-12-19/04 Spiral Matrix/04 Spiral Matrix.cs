using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Spiral_Matrix
{
    class _04_Spiral_Matrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            char[,] matrix = GetMatrix(n, text);

            // Calc row max weight 
            int maxWeight = -1;
            int maxWeightRow = -1;
            for (int row = 0; row < n; row++)
            {
                int rowWeight = GetRowWeight(matrix, row);
                if (rowWeight > maxWeight)
                {
                    maxWeight = rowWeight;
                    maxWeightRow = row;
                }
            }
            Console.WriteLine("{0} - {1}", maxWeightRow, maxWeight);
        }

        static int GetRowWeight(char[,] matrix, int row)
        {
            int weight = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                char cell = matrix[row, col];
                char cellLower = cell.ToString().ToLower()[0];
                int index = (int)cellLower - (int)'a' + 1;

                weight += index;
            }
            return weight * 10;
        }
        static char[,] GetMatrix(int n, string text)
        {
            char[,] matrix = new char[n, n];
            int totalCount = n * n;
            int cellCount = 0;
            int textIndex = 0;
            // spiral direction: top, left -> top, right ->> top, right -> bottom, right ->> 
            // bottom, right -> bottom, left ->> bottom, left -> top-1, left, etc.
            int left = 0;
            int right = n - 1;
            int top = 0;
            int bottom = n - 1;

            while (true)
            {
                for (int col = left; col <= right; col++)   // Left -> Right, Top = const
                {
                    int row = top;
                    matrix[row, col] = text[textIndex];
                    cellCount++;
                    if (cellCount == totalCount) return matrix;
                    textIndex++;
                    if (textIndex == text.Length) textIndex = 0;
                }
                top++;
                for (int row = top; row <= bottom; row++)   // Top -> Bottom, Right = const
                {
                    int col = right;
                    matrix[row, col] = text[textIndex];
                    cellCount++;
                    if (cellCount == totalCount) return matrix;
                    textIndex++;
                    if (textIndex == text.Length) textIndex = 0;
                }
                right--;
                for (int col = right; col >= left; col--)   // Right -> Left, Bottom = const
                {
                    int row = bottom;
                    matrix[row, col] = text[textIndex];
                    cellCount++;
                    if (cellCount == totalCount) return matrix;
                    textIndex++;
                    if (textIndex == text.Length) textIndex = 0;
                }
                bottom--;
                for (int row = bottom; row >= top; row--)   // Bottom -> Top, Left = const
                {
                    int col = left;
                    matrix[row, col] = text[textIndex];
                    cellCount++;
                    if (cellCount == totalCount) return matrix;
                    textIndex++;
                    if (textIndex == text.Length) textIndex = 0;
                }
                left++;
            }
        }
    }
}