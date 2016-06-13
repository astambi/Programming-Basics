using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (var i = 2; i <= 11; ++i)
            {
                var j = Math.Pow(-1, i) * i;
                Console.Write(j);
                if (i < 11)
                    Console.Write(",");
                else
                    Console.WriteLine();
            }
        }
    }
}
