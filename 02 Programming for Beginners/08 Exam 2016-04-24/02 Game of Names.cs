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
            string[] playerNames = new string[numberOfPlayers];
            int[] playerScores = new int[numberOfPlayers];
            // get input
            for (int i = 0; i < numberOfPlayers; i++)
            {
                playerNames[i] = Console.ReadLine();
                playerScores[i] = int.Parse(Console.ReadLine());
            }
            // calc new scores
            for (int i = 0; i < numberOfPlayers; i++)
            {
                foreach (char letter in playerNames[i])
                {
                    int letterASCIICode = (int)letter;
                    bool isEvenASCIICode = letterASCIICode % 2 == 0;

                    if (isEvenASCIICode)    playerScores[i] += letterASCIICode;
                    else                    playerScores[i] -= letterASCIICode;
                }
            }
            // find maxScore and maxScore player
            int maxScore = playerScores[0];
            int maxIndex = 0;
            for (int i = 1; i < numberOfPlayers; i++)
            {
                if (playerScores[i] > maxScore)
                {
                    maxScore = playerScores[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine("The winner is {0} - {1} points", playerNames[maxIndex], playerScores[maxIndex]);
        }
    }
}