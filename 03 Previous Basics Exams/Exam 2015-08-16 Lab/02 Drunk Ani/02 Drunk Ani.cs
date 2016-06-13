using System;

class Drunk_Ani
{
    static void Main(string[] args)
    {
        long cabins = long.Parse(Console.ReadLine()); // cabin No [0, cabins - 1]       
        string input = "";
        string endOfInput = "found a free one!";
        long stepsTaken = 0;
        long stepsTakenTotal = 0;
        long currentPosition = 0;
        long newPosition = 0;
        string directon = "";

        while ( ( input = Console.ReadLine().ToLower() ) != endOfInput)
        {
            long steps = long.Parse(input);
            newPosition = (currentPosition + steps) % cabins;
            stepsTaken = Math.Abs(newPosition - currentPosition);

            if (newPosition > currentPosition)
                directon = "right";
            else if (newPosition < currentPosition)
                directon = "left";                               

            if (stepsTaken != 0)
                Console.WriteLine("Go {0} steps to the {1}, Ani.",stepsTaken,directon);
            else 
                Console.WriteLine("Stay there, Ani.");

            stepsTakenTotal += stepsTaken;
            currentPosition = newPosition;
        }
        Console.WriteLine("Moved a total of {0} steps.", stepsTakenTotal);
    }
}