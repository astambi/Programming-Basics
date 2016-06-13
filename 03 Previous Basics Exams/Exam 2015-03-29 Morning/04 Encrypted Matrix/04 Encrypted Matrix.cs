using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encrypted_Matrix
{
    class _04_Encrypted_Matrix
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            char diagonalSymbol = Console.ReadLine()[0]; 

            // get encrypted number from message
            List<int> digits = ConvertMessageIntoNumber(message);
            string encryptedNumber = GetEncryptedNumber(digits);
            // create matrix
            int matrixSize = encryptedNumber.Length;
            int[,] matrix = new int[matrixSize, matrixSize];
            FillInMatrix(matrix, encryptedNumber, diagonalSymbol);
            // print matrix
            PrintMatrix(matrix);
        }
        static List<int> ConvertMessageIntoNumber (string message)
        {
            List<int> numbers = new List<int>();
            foreach (char letter in message)
            {
                int lastDigit = (int)letter % 10;
                numbers.Add(lastDigit);
            }
            return numbers;
        }
        static string GetEncryptedNumber (List<int> digits)
        {
            string encryptedNummber = "";
            for (int i = 0; i < digits.Count; i++)
            {
                bool isEven = digits[i] % 2 == 0;
                if (isEven)
                    encryptedNummber += (digits[i] * digits[i]);
                else 
                {
                    int prev = 0;
                    int next = 0;
                    if (i != 0)                 prev = digits[i - 1];
                    if (i != digits.Count - 1)  next = digits[i + 1];
                    encryptedNummber += (prev + digits[i] + next);
                }
            }
            return encryptedNummber;
        }
        static void FillInMatrix (int[,] matrix, string encryptedNumber, char diagonalSymbol)
        {
            int rows = matrix.GetLength(0);
            bool diagonal =     diagonalSymbol == '\\';
            bool antidiagonal = diagonalSymbol == '/';
            for (int i = 0; i < rows; i++)
                if (diagonal)
                    matrix[i, i] = int.Parse(encryptedNumber[i].ToString());
                else if (antidiagonal)
                    matrix[i, rows - 1 - i] = int.Parse(encryptedNumber[rows - 1 - i].ToString());
        }
        static void PrintMatrix (int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = rows;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                    Console.Write("{0} ",matrix[row,col]);
                Console.WriteLine();
            }
        }
    }
}