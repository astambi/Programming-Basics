using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Names
{
    class Game_of_Names
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());
            int maxScore = int.MinValue;
            string maxScorePlayer = "";

            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName = Console.ReadLine();
                int playerScore = int.Parse(Console.ReadLine());

                foreach (char letter in playerName)
                {
                    int letterASCIICode = (int)letter;
                    bool isEvenASCIICode = letterASCIICode % 2 == 0;

                    if (isEvenASCIICode)    playerScore += letterASCIICode;
                    else                    playerScore -= letterASCIICode;
                }
                if (playerScore > maxScore)
                {
                    maxScore = playerScore;
                    maxScorePlayer = playerName;
                }
            }            
            Console.WriteLine("The winner is {0} - {1} points", maxScorePlayer, maxScore);
        }
    }
}
