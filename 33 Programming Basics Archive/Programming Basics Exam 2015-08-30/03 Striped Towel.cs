using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Striped_Towel
{
    class _03_Striped_Towel
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            double height = Math.Floor(width * 1.5);
            char[] symbols = { '#', '.', '.' }; //[#..] [0,1,2]

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    Console.Write(symbols[(i + j) % 3]);
                Console.WriteLine();
            }
        }
    }
}
