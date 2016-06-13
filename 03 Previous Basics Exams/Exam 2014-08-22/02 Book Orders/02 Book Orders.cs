using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Book_Orders
{
    class Book_Orders
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            int books = 0;
            decimal payment = 0;

            for (int i = 0; i < orders; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                decimal bookPrice = decimal.Parse(Console.ReadLine());

                books += packets * booksPerPacket;
                decimal discount = 0;
                if (packets >= 10)
                    discount = Math.Min(11, packets / 10) + 4;

                payment += packets * booksPerPacket * bookPrice * (1 - discount / 100m);
            }
            Console.WriteLine(books);
            Console.WriteLine("{0:0.00}", payment);
        }
    }
}
