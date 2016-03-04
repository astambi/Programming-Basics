using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sudoku_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string endOfGame = "quit";
            string input = "";
            string prize = "";
            int games = 0;
            double scoreSeconds = 0.00;
            double averageSeconds = 0.00;

            while ((input = Console.ReadLine().ToLower()) != endOfGame)
            {
                string[] score = input.Split(':'); // splits input from "[mm:ss]" into array[] {mm,ss}
                scoreSeconds += int.Parse(score[0]) * 60 + int.Parse(score[1]);
                ++games;
            }

            if (games > 0)
            {
                averageSeconds = scoreSeconds / games;                
                if (averageSeconds < 720)
                    prize = "Gold";
                else if (averageSeconds < 1440)
                    prize = "Silver";
                else
                    prize = "Bronze";

                //Math.Ceiling
                //if (Math.Round(averageSeconds, 0) < averageSeconds)
                //    averageSeconds = Math.Round(averageSeconds, 0) + 1;
                //averageSeconds = Math.Round(averageSeconds, 0);          
            }
            Console.WriteLine("{0} Star", prize);
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", games, Math.Ceiling(averageSeconds));
        }
    }
}