using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Letters_Symbols_Numbers
{
    class Letters_Symbols_Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLetters = 0;
            int sumDigits = 0;
            int sumSymbols = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().ToLower();
                int len = input.Length;
                for (int j = 0; j < len; j++)
                {
                    bool letter = input[j] >= 'a' && input[j] <= 'z';
                    bool digit = input[j] >= '0' && input[j] <= '9';
                    bool symbol = (int)input[j] >= 33 && (int)input[j] <= 126; // including letters & digits

                    if (letter)
                        sumLetters += 10 * ((int)input[j] - 97 + 1);
                    else if (digit)
                        sumDigits += 20 * ((int)input[j] - 48);
                    else if (symbol)
                        sumSymbols += 200;
                }
            }
            Console.WriteLine(sumLetters);
            Console.WriteLine(sumDigits);
            Console.WriteLine(sumSymbols);
        }
    }
}
