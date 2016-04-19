using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._9_to_Text_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] numName = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            if ((number < 0) || (number > 9))
                Console.WriteLine("number too big");
            else
                for (int i = 0; i < 10; i++)
                {
                    if (number == i)
                        Console.WriteLine(numName[i]);
                }
        }
    }
}