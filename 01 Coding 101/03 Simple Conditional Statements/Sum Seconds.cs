using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            var totalSeconds = first + second + third;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);                              //format 1
            //Console.WriteLine("{0}:{1}", minutes, seconds.ToString().PadLeft(2, '0'));    //format 2

            //string format = "";                                                           //format 3
            //if (seconds < 10)
            //    format += "0";
            //Console.WriteLine("{0}:{1}{2}", minutes, format, seconds);                
        }
    }
}