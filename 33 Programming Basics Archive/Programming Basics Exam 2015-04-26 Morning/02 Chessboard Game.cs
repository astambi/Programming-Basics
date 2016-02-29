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
            int n = int.Parse(Console.ReadLine());  // n always odd => n*n B & W chessboard
            string input = Console.ReadLine();      // string over chessboard
            int sumOdd = 0;                         // black = even position in string
            int sumEven = 0;                        // white = odd posiion in string

            for (int i = 0; i < Math.Min(n*n,input.Length); i++) // max n*n string chars calcalated
            {
                int value = (int)input[i];
                bool digit =    value >= 48 && value <= 57;
                bool small =    value >= 97 && value <= 122;
                bool capital =  value >= 65 && value <= 90;                
                bool evenPosition = i % 2 == 0;                
                
                if (evenPosition && (small || digit) )
                    sumEven += value;
                else if (evenPosition && capital)
                    sumOdd += value;
                else if (!evenPosition && (small || digit) )
                    sumOdd += value;                
                else if (!evenPosition && capital)
                    sumEven += value; 
                // value of other symbols = 0               
            }
            string winner = "";
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
