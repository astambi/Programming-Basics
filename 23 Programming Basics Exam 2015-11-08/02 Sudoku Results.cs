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
            string endOfGame = "Quit";
            string lineInput = "";
            double resultSeconds = 0;
            int numGames = 0;
            string star = "";

            while ((lineInput = Console.ReadLine()) != endOfGame)
            {
                ++numGames;
                string[] time = lineInput.Split(':');
                resultSeconds += double.Parse(time[0]) * 60 + double.Parse(time[1]);
            }
            double averageSeconds = resultSeconds / numGames;
            if (averageSeconds < 720)
                star = "Gold Star";
            else if (averageSeconds <= 1400)
                star = "Silver Star";
            else
                star = "Bronze Star";

            Console.WriteLine("{0}", star);
            Console.WriteLine("Games - {0} \\ Average seconds - {1:0}", numGames, averageSeconds);
        }
    }
}