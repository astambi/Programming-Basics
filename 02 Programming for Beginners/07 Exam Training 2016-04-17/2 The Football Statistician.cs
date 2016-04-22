using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_The_Football_Statistician
{
    class The_Football_Statistician
    {
        static void Main(string[] args)
        {
            decimal payment = decimal.Parse(Console.ReadLine());
            string inputOver = "End of the league.";
            string input = "";
            int countMatches = 0;

            // get sorted dictionary of teams and points
            string[] teams = "Arsenal Chelsea ManchesterCity ManchesterUnited Liverpool Everton Southampton Tottenham"
                            .Split(' ')
                            .OrderBy(w => w)
                            .ToArray();
            Dictionary<string, int> teamPoints = new Dictionary<string, int>();
            foreach (var team in teams)
                teamPoints.Add(team, 0);    //teamPoints[team] = 0;

            // get matches data
            while ((input = Console.ReadLine()) != inputOver)
            {
                countMatches++;
                string[] game = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string team1 = game[0];
                string outcome = game[1];
                string team2 = game[2];

                switch (outcome)
                {
                    case "1":
                        teamPoints[team1] += 3; break;
                    case "2":
                        teamPoints[team2] += 3; break;
                    case "X":
                        teamPoints[team1]++;
                        teamPoints[team2]++;    break;
                }
            }
            // calc revenue
            decimal revenue = countMatches * payment * 1.94m;
            Console.WriteLine("{0:0.00}lv.", revenue);

            // print team points and the correct team names (ManchesterCity => Manchester City)
            foreach (var pair in teamPoints)
            {
                string team = pair.Key;
                string teamNameToPrint = team;

                // count the number of capital letters in team name
                int countUpperChars = team
                                    .Where(ch => char.IsUpper(ch))  // filter capital letters in name
                                    .Count();
                // if more than 1 capital letter in name, insert a space before the second one
                if (countUpperChars > 1)    
                {
                    for (int i = 0; i < team.Length; i++)
                    {
                        // find the index of the second capital letter in team name & insert a space before it
                        if (i > 0 && char.IsUpper(team[i])) 
                        {
                            teamNameToPrint = team.Substring(0, i) 
                                            + " " 
                                            + team.Substring(i);
                        }
                    }
                }
                Console.WriteLine("{0} - {1} points.", teamNameToPrint, pair.Value);
            }
        }
    }
}