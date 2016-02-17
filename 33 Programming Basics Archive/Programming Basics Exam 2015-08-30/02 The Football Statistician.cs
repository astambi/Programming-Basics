using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_The_Football_Statistician
{
    class _02_The_Football_Statisticia
    {
        static void Main(string[] args)
        {
            decimal price = decimal.Parse(Console.ReadLine());
            string endOfInput = "End of the league.";
            string input = "";
            string[] team =     { "Arsenal", "Chelsea", "Everton", "Liverpool", "ManchesterCity", "ManchesterUnited", "Southampton", "Tottenham" };
            string[] teamPrint = { "Arsenal", "Chelsea", "Everton", "Liverpool", "Manchester City", "Manchester United", "Southampton", "Tottenham" };
            int[] scores = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int games = 0;

            while ((input = Console.ReadLine()) != endOfInput)
            {
                ++games;
                string[] gameDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // removing multiple spaces {team1 score team2}
                string team1 = gameDetails[0];
                string score = gameDetails[1].ToUpper(); // 1, 2, X
                string team2 = gameDetails[2];
                string winningTeam = "";

                if (score == "1")
                    winningTeam = team1;
                else if (score == "2")
                    winningTeam = team2;

                if (score == "1" || score == "2")
                    for (int j = 0; j < 8; j++)
                    {
                        if (winningTeam == team[j])
                            scores[j] += 3;
                    }
                else if (score == "X")
                    for (int j = 0; j < 8; j++)
                    {
                        if (team1 == team[j])
                            scores[j] += 1;
                        if (team2 == team[j])
                            scores[j] += 1;
                    }
            }
            decimal payment = 1.94m * price * games;
            Console.WriteLine("{0:0.00}lv.", payment);
            for (int i = 0; i < 8; i++)
                Console.WriteLine("{0} - {1} points.", teamPrint[i], scores[i]);
        }
    }
}