using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();

            bool areAllDifferent = false;
            while (!areAllDifferent)
            {
                areAllDifferent = true;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i < list.Count - 1 && list[i] == list[i + 1])
                    {
                        result.Add(list[i] * 2);
                        i++;
                        areAllDifferent = false;
                    }
                    else
                        result.Add(list[i]);
                }
                list = result;
                result = new List<double>();
            }                       
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
