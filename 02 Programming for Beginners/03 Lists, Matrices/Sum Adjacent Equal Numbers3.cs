using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            bool areAllDifferent = false;
            while (!areAllDifferent)
            {
                areAllDifferent = true;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i < list.Count - 1 && list[i] == list[i + 1])
                    {
                        list[i] *= 2;
                        list.RemoveAt(i+1);

                        areAllDifferent = false;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
