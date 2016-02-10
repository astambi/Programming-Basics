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
            string[] inputDetails = new string[4];                          // {weekday,phoneNumber,braSize,name}
            int perfectCount = 0;

            while ((input = Console.ReadLine()) != endOfInput)
            {
                inputDetails = input.Split('\\');                           // splits input [weekday\phoneNumber\braSize\name] 
                string weekday = inputDetails[0].ToLower();                 // into array[] {weekday,phoneNumber,braSize,name}
                string phoneNumber = inputDetails[1];                       // 0123456789
                string bra = inputDetails[2];                               // 123X
                string name = inputDetails[3];                              // Name
                int result = 0;
                
                for (int i = 0; i < 7; i++)                                 // adds weekday digit
                {
                    if (weekday == weekdays[i])
                        result += i + 1;
                }
                while (phoneNumber.Length > 0)                              // adds phoneNumber digits
                {
                    int digit = phoneNumber[phoneNumber.Length - 1] - 48;   // ASCII table '0' = 48 (last digit)
                    phoneNumber = phoneNumber.Substring(0, phoneNumber.Length - 1); 
                    result += digit;                                        // Substring(staring index, length) => phoneNumber less last digit
                }
                // adds (bra size * ASCII code of bra 'letter')
                int size = int.Parse(bra.Substring(0, bra.Length - 1));     // bra size = bra string less last 'letter'
                result += size * bra[bra.Length - 1];                       // ASCII table bra 'letter' (last char = [n-1])
                // subtracts (name length * ASCII code of first letter)
                result -= name.Length * name[0];                            // ASCII table first 'letter' => first char = name[0]

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
