using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    class Matrix_of_Palindromes
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            // palindroms of 3 letters: row 0 => aaa aba... row 1 => bbb bcb...
            string[,] matrixOfPalindroms = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    matrixOfPalindroms[row, col] = GetPalindromOfLetters(row, col);
            }
            
            // print matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    Console.Write("{0} ", matrixOfPalindroms[row, col]);
                Console.WriteLine();
            }
        }
        static string GetPalindromOfLetters(int row, int col)
        {
            string palindrom = "";
            int startingIndex = (int)('a') + row;
            palindrom +=  (char)(startingIndex) + 
                        + (char)(startingIndex + col) + 
                        + (char)(startingIndex);
            return palindrom;
        }
    }
}
