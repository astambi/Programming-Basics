using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Perfect_Girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            string endOfInput = "Enough dates!";
            string input = "";
            string[] weekdays = {"monday","tuesday","wednesday","thursday","friday","saturday","sunday"};
            string[] inputDetails = new string[4]; // {weekday,phoneNumber,braSize,name}
            int perfectCount = 0;

            while ((input = Console.ReadLine()) != endOfInput)
            {
                // splits input [weekday\phoneNumber\braSize\name] 
                // into array[] {weekday,phoneNumber,braSize,name}
                inputDetails = input.Split('\\');   // NB.\\!
                string weekday = inputDetails[0].ToLower();
                string phoneNumber = inputDetails[1]; //0123456789
                string bra = inputDetails[2];       //123X
                string name = inputDetails[3];      //Name
                int result = 0;

                // adds weekday digit
                for (int i = 0; i < 7; i++)
                {
                    if (weekday == weekdays[i])
                        result += i + 1;
                }
                // adds phoneNumber digits
                while (phoneNumber.Length > 0)
                {
                    // ASCII table '0' = 48 (last digit)
                    int digit = phoneNumber[phoneNumber.Length - 1] - 48;
                    // Substring(staring index, length) => phoneNumber less last digit
                    phoneNumber = phoneNumber.Substring(0, phoneNumber.Length - 1); 
                    result += digit;
                }
                // adds (bra size * ASCII code of bra 'letter')
                // bra size = bra string less last 'letter'
                // ASCII table bra 'letter' (last char = [n-1])
                int size = int.Parse(bra.Substring(0, bra.Length - 1)); 
                result += size * bra[bra.Length - 1];

                // subtracts (name length * ASCII code of first letter)
                // ASCII table first 'letter' => first char = name[0]
                result -= name.Length * name[0]; 

                bool perfectResult = result >= 6000;
                if (perfectResult)
                {
                    ++perfectCount;
                    Console.WriteLine("{0} is perfect for you.", name);
                }
                else
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
            }
            Console.WriteLine("{0}", perfectCount);
        }
    }
}
