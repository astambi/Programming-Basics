using System;

class Firefighters
{
    static void Main(string[] args)
    {
        int firefighters = int.Parse(Console.ReadLine());
        int[] peopleSaved = new int[3]; // K, A, S 
        string inputOver = "rain";
        string input = "";

        while ((input = Console.ReadLine()) != inputOver)
        {
            int[] peopleToSave = new int[3]; // saving priority: K, A, S
            foreach (char letter in input)
            {
                if (letter == 'K')      peopleToSave[0]++;
                else if (letter == 'A') peopleToSave[1]++;
                else if (letter == 'S') peopleToSave[2]++;
            }
            // count saved people
            int availableFirefighters = firefighters;
            for (int i = 0; i < peopleToSave.Length; i++) 
            {
                if (availableFirefighters > 0)
                {
                    int countSaved = Math.Min(availableFirefighters, peopleToSave[i]);
                    peopleSaved[i] += countSaved;
                    availableFirefighters -= countSaved;
                }
                else break;
            }
        }
        Console.WriteLine("Kids: {0}", peopleSaved[0]);
        Console.WriteLine("Adults: {0}", peopleSaved[1]);
        Console.WriteLine("Seniors: {0}", peopleSaved[2]);
    }
}