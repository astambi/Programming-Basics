using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDateTime
{
    class CurrentDateTime
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("dd.M.yyyy г. hh:mm:ss ч."));
        }
    }
}
