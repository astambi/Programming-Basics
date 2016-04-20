using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();

            foreach (var item in list)
            {
                if (item >= 0)
                    positiveNumbers.Add(item); 
                // adding non-negative elements to a new list is much faster than removing negative elements from the original list
            }
            positiveNumbers.Reverse();

            if (positiveNumbers.Count > 0)
                Console.WriteLine(String.Join(" ", positiveNumbers));
            else
                Console.WriteLine("empty");
        }
    }
}
