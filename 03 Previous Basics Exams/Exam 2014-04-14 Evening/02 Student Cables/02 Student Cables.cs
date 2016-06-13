using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Student_Cables
{
    class _02_Student_Cables
    {
        static void Main(string[] args)
        {
            int numCables = int.Parse(Console.ReadLine());
            int cableLength = 0; //cm
            int countCables = 0;

            for (int i = 0; i < numCables; i++)
            {
                int len = int.Parse(Console.ReadLine());
                string metric = Console.ReadLine().ToLower();
                if (metric == "meters") len *= 100;
                if (len >= 20)
                {
                    countCables++;
                    cableLength += len; // discard short cables	
                }
            }
            cableLength -= 3 * (countCables - 1);
            int studentCables = cableLength / 504;
            int remainingLength = cableLength % 504;
            Console.WriteLine("{0}\n{1}", studentCables, remainingLength);
        }
    }
}
