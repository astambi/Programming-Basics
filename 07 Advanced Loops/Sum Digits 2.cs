using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits_2
{
    class Sum_Digits_2
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumDigits = 0;

            for (int i = 0; i < number.Length; i++)
                sumDigits += int.Parse(number[i].ToString());

            Console.WriteLine("{0}", sumDigits);
        }
    }
}
