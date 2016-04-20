using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i); // slower than creating a new list for the non-negative elements
                    i--;
                }
            }
            list.Reverse();
            if (list.Count > 0)
                Console.WriteLine(String.Join(" ", list));
            else
                Console.WriteLine("empty");
        }
    }
}
