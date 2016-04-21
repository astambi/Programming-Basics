using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_String_Letters
{
    class Print_String_Letters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
                Console.WriteLine("str[{0}] -> '{1}'", i, text[i]);
        }
    }
}
