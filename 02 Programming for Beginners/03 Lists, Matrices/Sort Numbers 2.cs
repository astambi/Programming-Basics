using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            // sort in descending order
            //numbers.Sort();
            //numbers.Reverse();
            // sort in descending order
            //numbers.Sort((num1, num2) => num2.CompareTo(num1));

            //sorting arrays
            string[] names = new string[] { "Zo", "Anna", "Martin" };

            Array.Sort(names);
            Array.Reverse(names);
            Array.Sort(names, (word1, word2) => word2.Length.CompareTo(word1.Length));

            foreach (var name in names)
                Console.WriteLine(name);
        }
    }
}
