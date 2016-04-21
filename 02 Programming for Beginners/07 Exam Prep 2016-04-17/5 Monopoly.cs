using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Monopoly
{
    class Monopoly
    {
        static void Main(string[] args)
        {
            decimal money = 50;
            int countHotels = 0;
            int countTurns = 0;

            char[,] matrix = GetMatrix();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                bool evenRow = row % 2 == 0;
                if (evenRow)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        switch (matrix[row, col])
                        {
                            case 'H':
                                countHotels++;
                                Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, countHotels);
                                money = 0;
                                break;
                            case 'J':
                                Console.WriteLine("Gone to jail at turn {0}.", countTurns);
                                countTurns += 2;
                                money += countHotels * 10 * 2;
                                break;
                            case 'S':
                                Console.WriteLine("Spent {0} money at the shop.", Math.Min((row + 1) * (col + 1), money));
                                money -= Math.Min((row + 1) * (col + 1), money);
                                break;
                        }
                        money += countHotels * 10;
                        countTurns++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        switch (matrix[row, col])
                        {
                            case 'H':
                                countHotels++;
                                Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, countHotels);
                                money = 0;
                                break;
                            case 'J':
                                Console.WriteLine("Gone to jail at turn {0}.", countTurns);
                                countTurns += 2;
                                money += countHotels * 10 * 2;
                                break;
                            case 'S':
                                Console.WriteLine("Spent {0} money at the shop.", Math.Min((row + 1) * (col + 1), money));
                                money -= Math.Min((row + 1) * (col + 1), money);
                                break;
                        }
                        money += countHotels * 10;
                        countTurns++;
                    }
                }
            }
            Console.WriteLine("Turns {0}", countTurns);
            Console.WriteLine("Money {0}", money);
        }

        static void PrintMatrix(char[,] matrix)
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

        static char[,] GetMatrix()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = elements[col];
            }
            return matrix;
        }
    }
}
