using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lists = Console.ReadLine().Split('|');

            List<string> result = new List<string>();
            for (int i = lists.Length - 1; i >= 0; i--)
            {
                string[] currentList = lists[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in currentList)
                    result.Add(item);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
