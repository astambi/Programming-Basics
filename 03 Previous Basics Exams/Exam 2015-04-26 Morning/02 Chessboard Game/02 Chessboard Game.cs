using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Chessboard_Game
{
    class _02_Chessboard_Game
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // n always odd => black & white chessboard n * n
            string input = Console.ReadLine();      // string written over chessboard
            int sumEven = 0;                        // black position on chessboard = even position in string [0]
            int sumOdd = 0;                         // white position on chessboard =  odd position in string [1]
            int length = Math.Min(n*n, input.Length);
            string winner = "";

            for (int i = 0; i < length; i++) 
            {
                int value = (int)input[i];
                bool digit = value >= 48 && value <= 57;    // ASCII values of digits [48,57]
                bool small = value >= 97 && value <= 122;   // ASCII values of small letters [97,122]
                bool capital = value >= 65 && value <= 90;  // ASCII values of capital letters [65,90]  
                bool evenPosition = i % 2 == 0;  
                          
                if (evenPosition && (small || digit))
                    sumEven += value;
                else if (!evenPosition && (small || digit))
                    sumOdd += value;
                else if (evenPosition && capital)
                    sumOdd += value;                              
                else if (!evenPosition && capital)
                    sumEven += value;  
                // value of other symbols = 0 
            }
            int diff = Math.Abs(sumEven - sumOdd);

            if (diff == 0)
                Console.WriteLine("Equal result: {0}", sumOdd);
            else
            {
                if (sumEven > sumOdd)
                    winner = "black";
                else 
                    winner = "white";
                Console.WriteLine("The winner is: {0} team",winner);
                Console.WriteLine("{0}",diff);
            }        
        }
    }
}
