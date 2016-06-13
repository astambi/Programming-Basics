using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Longest_Alphabetical_Word
{
    class _04_Longest_Alphabetical_Word
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[,] matrix = GetMatrix(word);
            //PrintMatrix(matrix);

            if (matrix.GetLength(0) == 1)
            {
                Console.WriteLine(word[0]);
                return;
            }
            List<string> longestWords = GetLongestAlphWord(matrix);
            longestWords.Sort();

            Console.WriteLine(longestWords[0]);
        }

        static List<string> GetLongestAlphWord(char[,] matrix)
        {
            List<string> longestWords = new List<string>();
            int maxLen = 0;
            string word = "";

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // direction increasing right
                    word = matrix[row, col].ToString();
                    for (int right = col + 1; right < matrix.GetLength(1); right++)
                    {
                        char current = matrix[row, right];
                        char prev = matrix[row, right - 1];
                        bool isIncreasing = (int)current > (int)prev;

                        if (isIncreasing)
                        {
                            word += (char)current;
                            if (word.Length > maxLen)
                            {
                                maxLen = word.Length;
                                longestWords.Clear();
                                longestWords.Add(word);
                            }
                            else if (word.Length == maxLen)
                                longestWords.Add(word);
                        }
                        else break;
                    }
                    // direction increasing left
                    word = matrix[row, col].ToString();
                    for (int left = col - 1; left >= 0; left--)
                    {
                        char current = matrix[row, left];
                        char prev = matrix[row, left + 1];
                        bool isIncreasing = (int)current > (int)prev;

                        if (isIncreasing)
                        {
                            word += (char)current;
                            if (word.Length > maxLen)
                            {
                                maxLen = word.Length;
                                longestWords.Clear();
                                longestWords.Add(word);
                            }
                            else if (word.Length == maxLen)
                                longestWords.Add(word);
                        }
                        else break;
                    }
                    // direction increasing bottom
                    word = matrix[row, col].ToString();
                    for (int bottom = row + 1; bottom < matrix.GetLength(0); bottom++)
                    {
                        char current = matrix[bottom, col];
                        char prev = matrix[bottom - 1, col];
                        bool isIncreasing = (int)current > (int)prev;

                        if (isIncreasing)
                        {
                            word += (char)current;
                            if (word.Length > maxLen)
                            {
                                maxLen = word.Length;
                                longestWords.Clear();
                                longestWords.Add(word);
                            }
                            else if (word.Length == maxLen)
                                longestWords.Add(word);
                        }
                        else break;
                    }
                    // direction increasing top
                    word = matrix[row, col].ToString();
                    for (int top = row - 1; top >= 0; top--)
                    {
                        char current = matrix[top, col];
                        char prev = matrix[top + 1, col];
                        bool isIncreasing = (int)current > (int)prev;

                        if (isIncreasing)
                        {
                            word += (char)current;
                            if (word.Length > maxLen)
                            {
                                maxLen = word.Length;
                                longestWords.Clear();
                                longestWords.Add(word);
                            }
                            else if (word.Length == maxLen)
                                longestWords.Add(word);
                        }
                        else break;
                    }
                }
            }
            return longestWords;
        }

        static char[,] GetMatrix(string word)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int indexWord = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = word[indexWord];
                    indexWord++;
                    if (indexWord >= word.Length)
                        indexWord = 0;
                }
            }
            return matrix;
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write("{0} ", matrix[row, col]);
                Console.WriteLine();
            }
        }
    }
}
