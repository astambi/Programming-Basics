using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Chess_Queens
{
    class _04_Chess_Queens
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());       // chessboard size
            int distance = int.Parse(Console.ReadLine());   // distance between queens (in squares)

            List<string> positionsOfQueens = GetValidPositions(size, distance);

            if (positionsOfQueens.Count > 0)
                Console.WriteLine(string.Join("\n", positionsOfQueens));
            else Console.WriteLine("No valid positions");
        }

        static List<string> GetValidPositions(int size, int distance)
        {
            List<string> positions = new List<string>();
            // distance = number of cells between queens, d = diff in matrix indices
            int d = distance + 1; 
            // chessboard indices: rows = a, b, c... && cols = 1,2,3...
            for (int rowB = 1; rowB <= size; rowB++)
                for (int colB = 1; colB <= size; colB++)
                    for (int rowW = rowB - d; rowW <= rowB + d; rowW += d)  // white queen's possible positions away from black queen, diff row/col indices = d
                        for (int colW = colB - d; colW <= colB + d; colW += d)
                        {
                            bool isSamePosition = rowW == rowB && colW == colB; // queens taking the same position on chessboard
                            bool isWithinChessBoard =                           // position of queen inside chessboard
                                                rowW >= 1 && rowW <= size && 
                                                colW >= 1 && colW <= size;  
                            if (isWithinChessBoard && !isSamePosition)
                            {
                                string pairQueens = GetPairOfQueens(rowB, colB, rowW, colW);
                                positions.Add(pairQueens);
                            }
                        }
            return positions;
        }
        static string GetPairOfQueens(int rowB, int colB, int rowW, int colW)
        {
            // chessboard indices: rows = a, b, c... && cols = 1,2,3...
            string queenB = "" + (char)(rowB + 'a' - 1) + colB;     // 1 -> 'a'
            string queenW = "" + (char)(rowW + 'a' - 1) + colW;
            return string.Join(" - ", queenB, queenW);
        }
    }
}