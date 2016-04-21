using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    class Rectangle_Position
    {
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public bool IsInside(Rectangle r)
            {
                return  (r.Left <= Left) && (r.Right >= Right) && 
                        (r.Top <= Top) && (r.Bottom >= Bottom);
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle1 = GetRectangle();
            Rectangle rectangle2 = GetRectangle();

            bool isInside = rectangle1.IsInside(rectangle2);

            if (isInside)   Console.WriteLine("Inside");
            else            Console.WriteLine("Not inside");

            //Console.WriteLine(rectangle1.IsInside(rectangle2) ? "Inside" : "Not inside");
        }

        static Rectangle GetRectangle()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle() { Left = input[0],
                                                    Top = input[1],
                                                    Width = input[2],
                                                    Height = input[3] };
            return rectangle;
        }
    }
}