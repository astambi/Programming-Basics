using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latin_Letters
{
    class Latin_Letters
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++) //NB. char vs. int! <=> char vs. ASCI values 
                Console.WriteLine(i);
        }
    }
}
