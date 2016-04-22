using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Firefighters
{
    class Firefighters
    {
        static void Main(string[] args)
        {
            int numbersOfFirefighters = int.Parse(Console.ReadLine());
            int[] peopleSaved = new int[3]; // K, A, S 
            string inputOver = "rain";
            string input = "";

            while ((input = Console.ReadLine())!= inputOver)
            {
                int[] peopleToSave = new int[3]; // saving priority: K, A, S

                // count people in need of saving
                foreach (char letter in input)
                {
                    if (letter == 'K')      peopleToSave[0]++;
                    else if (letter == 'A') peopleToSave[1]++;
                    else if (letter == 'S') peopleToSave[2]++;
                }
                // count actually saved people
                int availableFirefighters = numbersOfFirefighters;
                for (int i = 0; i < 3; i++) // saving priority
                {
                    if (availableFirefighters > 0)
                    {
                        int countCurrentlySaved = Math.Min(availableFirefighters, peopleToSave[i]);
                        peopleSaved[i]  += countCurrentlySaved;
                        availableFirefighters -= countCurrentlySaved;
                    }
                    else break;
                }
            }
            // print result
            Console.WriteLine("Kids: {0}", peopleSaved[0]);
            Console.WriteLine("Adults: {0}", peopleSaved[1]);
            Console.WriteLine("Seniors: {0}", peopleSaved[2]);
        }
    }
}