using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Ending_in_7
{
    class Numbers_Ending_in_7
    {
        static void Main(string[] args)
        {
            int n = 1000;

            for (int i = 0; i < n; i++)
            {
                bool numberEndingIn7 = i % 10 == 7;
                if (numberEndingIn7)
                    Console.WriteLine(i);
            }
        }
    }
}
