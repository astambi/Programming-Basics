﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_1._._.N_with_Step_3
{
    class Numbers_1_N_with_Step_3
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 3)
            Console.WriteLine("{0}", i);
        }
    }
}
