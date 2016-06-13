using System;
using System.Linq;

class Sudoku_Results
{
    static void Main(string[] args)
    {
        string inputOver = "quit";
        string input = "";
        int games = 0;
        double scoreSeconds = 0;
        string prize = "";
        while ((input = Console.ReadLine().ToLower()) != inputOver)
        {
            games++;
            int[] score = input.Split(':').Select(int.Parse).ToArray(); // "mm:ss"
            scoreSeconds += score[0] * 60 + score[1];
        }
        if (games > 0)
        {
            double averageScore = scoreSeconds / games; 
            if (averageScore < 720)         prize = "Gold";
            else if (averageScore < 1440)   prize = "Silver";
            else                            prize = "Bronze";
            Console.WriteLine("{0} Star", prize);
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", games, Math.Ceiling(averageScore));
        }            
    }
}