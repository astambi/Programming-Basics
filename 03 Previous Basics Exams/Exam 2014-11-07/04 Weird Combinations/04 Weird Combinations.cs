using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Weird_Combinations
{
    class _04_Weird_Combinations
    {
        static void Main(string[] args)
        {
            char[] sequence = Console.ReadLine().ToCharArray(); // 5 chars exactly
            int n = int.Parse(Console.ReadLine());

            int count = -1;
            bool elementFound = false;

            for (int i0 = 0; i0 < 5; i0++)
            {
                for (int i1 = 0; i1 < 5; i1++)
                {
                    for (int i2 = 0; i2 < 5; i2++)
                    {
                        for (int i3 = 0; i3 < 5; i3++)
                        {
                            for (int i4 = 0; i4 < 5; i4++)
                            {
                                string combination = string.Empty + sequence[i0] + sequence[i1] 
                                                    + sequence[i2] + sequence[i3] + sequence[i4];
                                if (++count == n)
                                {
                                    Console.WriteLine(combination);
                                    elementFound = true;
                                    break;
                                }
                            }
                            if (elementFound) break;
                        }
                        if (elementFound) break;
                    }
                    if (elementFound) break;
                }
                if (elementFound) break;
            }
            if (!elementFound)
                Console.WriteLine("No");
        }
    }
}