using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Modifier
{
    class Array_Modifier
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string inputOver = "end";
            string input = "";

            while ( (input = Console.ReadLine()) != inputOver)
            {
                string[] inputDetails = input.Split(' ').ToArray();
                string command = inputDetails[0];

                if (command == "swap" || command == "multiply")
                {
                    int index1 = int.Parse(inputDetails[1]);
                    int index2 = int.Parse(inputDetails[2]);

                    switch (command)
                    {
                        case "swap":
                            long tempElement = numbers[index1];
                            numbers[index1] = numbers[index2];
                            numbers[index2] = tempElement;
                            break;
                        case "multiply":
                            numbers[index1] *= numbers[index2];
                            break;
                    }
                }
                else if(command == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                        numbers[i] -= 1;
                }                
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
