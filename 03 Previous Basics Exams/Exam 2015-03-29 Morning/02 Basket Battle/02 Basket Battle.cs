using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Basket_Battle
{
    class Basket_Battle
    {
        static void Main(string[] args)
        {
            string[] players = {"Simeon", "Nakov" };
            players[0] = Console.ReadLine(); 
            if (players[0] == "Nakov")
                players[1] = "Simeon";

            int gameRounds = int.Parse(Console.ReadLine());
            int[] scores = { 0, 0 };
            int winningScore = 500;
            int winningRound = 0; 
            string winner = "";

            for (int i = 0; i < gameRounds; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int score = int.Parse(Console.ReadLine());  // scores
                    string result = Console.ReadLine();         // {success, fail}

                    int currentPlayer = (i + j) % 2;            // players switching turns

                    if (result == "success")
                    {
                        if (scores[currentPlayer] + score <= winningScore)
                            scores[currentPlayer] += score;
                        if (scores[currentPlayer] == winningScore)
                        {
                            winner = players[currentPlayer];
                            winningRound = i + 1;
                            break;
                        }
                    }
                }
                if (winner != "")
                    break;               
            }
            if (winner != "")
            {
                Console.WriteLine(winner);
                Console.WriteLine(winningRound);
                Console.WriteLine(Math.Min(scores[0],scores[1])); // points losing player
            }
            else if (scores[0] == scores[1])
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(scores[0]);
            }
            else 
            {
                if (scores[0] > scores[1])
                    Console.WriteLine(players[0]);
                else
                    Console.WriteLine(players[1]);
                Console.WriteLine(Math.Abs(scores[0] - scores[1]));
            }
        }
    }
}
