using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_4_Numbers
{
    class Increasing_4_Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // a <= n1 < n2 < n3 < n4 <= b
            int count = 0;

            for (int n1 = a; n1 <= b; n1++)                     // n1 [a, b]
            {
                for (int n2 = n1 + 1; n2 <= b; n2++)            // n2 (n1, b]
                {
                    for (int n3 = n2 + 1; n3 <= b; n3++)        // n3 (n2, b]
                    {
                        for (int n4 = n3 + 1; n4 <= b; n4++)    // n4 (n3, b]
                        {
                            if (n1 < n2 && n2 < n3 && n3 < n4)
                            {
                                Console.WriteLine("{0} {1} {2} {3}",n1, n2, n3, n4);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("No");
        }
    }
}
