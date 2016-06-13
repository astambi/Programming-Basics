using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sequence_of_K_Numbers
{
    class Sequence_of_K_Numbers
    {
        static void Main(string[] args)
        {
            string input = "1 1 100 1 1";// Console.ReadLine();
            int sequence = 2;// int.Parse(Console.ReadLine());
            char previousChar = input[0];
            string result = "";

            string[] numbers = input.Split(' ');
            int len = numbers.Length;


            // TODO !!!
            for (int i = 0; i < len; i++)
            {
                int repeatingSequence = 1;
                for (int j = 0; j < sequence; j++)
                {
                    if (numbers[i] != numbers[i + j + 1])
                    {
                        repeatingSequence = 0;
                        break;
                    }
                }
                if (repeatingSequence == 0) // no repeating numbers
                {
                    for (int j = 0; j < sequence; j++)
                        result += numbers[i + j] + " ";
                }
                else
                    i += sequence;             
            }
            Console.WriteLine(result);
        }
    }
}
