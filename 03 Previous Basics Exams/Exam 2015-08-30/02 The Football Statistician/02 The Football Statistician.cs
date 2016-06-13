using System;
using System.Collections.Generic;
using System.Linq;

class The_Football_Statistician
{
    static void Main(string[] args)
    {
        decimal payment = decimal.Parse(Console.ReadLine());
        string inputOver = "End of the league.";
        string input = "";
        // teams & points
        Dictionary<string, int> teamPoints = new Dictionary<string, int>();
        string[] teams = "Arsenal Chelsea ManchesterCity ManchesterUnited Liverpool Everton Southampton Tottenham"
                        .Split(' ')
                        .OrderBy(w => w)
                        .ToArray();
        foreach (var team in teams)
            teamPoints.Add(team, 0);    // teamPoints[team] = 0;
        int countMatches = 0;

        while ((input = Console.ReadLine()) != inputOver)
        {
            countMatches++;
            string[] game = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string team1 = game[0];
            string outcome = game[1];
            string team2 = game[2];
            switch (outcome)
            {
                case "1": teamPoints[team1] += 3; break;
                case "2": teamPoints[team2] += 3; break;
                case "X":
                    teamPoints[team1]++;
                    teamPoints[team2]++; break;
            }
        }
        decimal revenue = countMatches * payment * 1.94m;
        Console.WriteLine("{0:f2}lv.", revenue);
        // print correct team names (ManchesterCity => Manchester City) & points
        foreach (var teamPair in teamPoints)
        {
            string teamName = teamPair.Key;
            for (int i = 1; i < teamName.Length; i++)
            {
                if (char.IsUpper(teamName[i]))
                {
                    teamName = teamName.Substring(0, i) + " "
                                + teamName.Substring(i);
                    break;
                }
            }
            Console.WriteLine("{0} - {1} points.", teamName, teamPair.Value);
        }
    }
}
