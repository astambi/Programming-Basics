using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Stupid_Password_Generator
{
    class Stupid_Password_Generator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            string password = "";

            // stupid password length 5 "ijkmp" 
            // 1 & 2 = digit [1,n]
            // 3 & 4 = small letter [1,n]-position in the alphabet
            // 5 = digit [1,n], digit > password digits 1 & 2 

            for (int i = 1; i <= n; i++)                                    // digit [1,n]
            {
                for (int j = 1; j <= n; j++)                                // digit [1,n]
                {
                    for (int k = 97; k < 97 + L; k++)                       // small letter [a1, aL)
                    {
                        for (int m = 97; m < 97 + L; m++)                   // small letter [a1, aL)
                        {
                            for (int p = Math.Max(i, j) + 1; p <= n; p++)   // digit [1,n] > i, > j 
                            {
                                password = "" + i + j + (char)k + (char)m + p;
                                Console.Write("{0} ", password);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
